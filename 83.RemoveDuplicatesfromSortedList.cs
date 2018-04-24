using System;

public class ListNode {
 public ListNode next;
 public int val;
}

public class LinkedList {
 private ListNode head;

 public void AddFirst(int data) {
  ListNode toAdd = new ListNode();

  toAdd.val = data;
  toAdd.next = head;

  head = toAdd;
 }

 public void printAllNodes() {
  ListNode current = head;
  while (current != null) {
   Console.WriteLine(current.val);
   current = current.next;
  }
 }

 public ListNode DeleteDuplicates() {
  if (head == null) {
   return null;
  }

  ListNode current = head;

  while (current.next != null) {
   if (current.next.val == current.val) {
    current.next = current.next.next;
   } else {
    current = current.next;
   }
  }

  return head;

 }

 public void AddLast(int data) {
  if (head == null) {
   head = new ListNode();

   head.val = data;
   head.next = null;
  } else {
   ListNode toAdd = new ListNode();
   toAdd.val = data;

   ListNode current = head;
   while (current.next != null) {
    current = current.next;
   }

   current.next = toAdd;
  }
 }
}

public class Test {
 public static void Main() {
  LinkedList myList1 = new LinkedList();

  myList1.AddLast(1);
  myList1.AddLast(2);
  myList1.AddLast(3);
  myList1.AddLast(4);
  myList1.AddLast(5);
  myList1.AddLast(5);
  myList1.AddLast(5);
  myList1.AddLast(6);
  myList1.AddLast(6);
  myList1.AddLast(7);
  myList1.AddLast(8);
  myList1.AddLast(8);


  myList1.DeleteDuplicates();
  myList1.printAllNodes();
 }
}
