// https://leetcode.com/problems/add-two-numbers/description/

using System;

public class Test
{
    public class ListNode
    {

        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

    }

    public class MyList
    {
        public ListNode head;

        public void AddNext(int nextValue)
        {
            if (head == null)
            {
                head = new ListNode(nextValue);
                head.next = null;
                return;
            }

            ListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            ListNode newNode = new ListNode(nextValue);
            current.next = newNode;
        }

        public void PrintAllNodes()
        {
            ListNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }

        }

        public void PrintFromHeader(ListNode head1)
        {
            ListNode current = head1;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // while both List does not end. 
            ListNode currentL1 = l1;
            ListNode currentL2 = l2;
            ListNode newHead = null;
            ListNode currentNew = newHead;

            int addOneFor10Digit = 0;
            while (currentL1 != null || currentL2 != null || addOneFor10Digit == 1)
            {
                int tempValue = (currentL1 != null ? currentL1.val : 0) + (currentL2 != null ? currentL2.val : 0) + addOneFor10Digit;
                if (tempValue >= 10)
                {
                    addOneFor10Digit = 1;
                    tempValue = tempValue - 10;
                }
                else
                {
                    addOneFor10Digit = 0;
                }

                if (newHead == null)
                {
                    newHead = new ListNode(tempValue);
                    currentNew = newHead;
                }
                else
                {
                    ListNode newNode = new ListNode(tempValue);
                    currentNew.next = newNode;
                    currentNew = currentNew.next;
                }

                if (currentL1 != null)
                {
                    currentL1 = currentL1.next;
                }

                if (currentL2 != null)
                {
                    currentL2 = currentL2.next;
                }

            }

            return newHead;

        }

    }

    public static void Main()
    {
        MyList myList = new MyList();
        //myList.AddNext(1);
        myList.AddNext(5);

        MyList myList1 = new MyList();
        //myList1.AddNext(9);
        myList1.AddNext(5);
        //myList1.AddNext(2);

        MyList myList2 = new MyList();
        ListNode newNodeHeader = myList2.AddTwoNumbers(myList.head, myList1.head);

        myList2.PrintFromHeader(newNodeHeader);
        Console.ReadLine();
    }
}
