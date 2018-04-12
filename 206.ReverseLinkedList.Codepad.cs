// https://leetcode.com/submissions/detail/149668217/

using System;

public class Node {
 public Node next;
 public int data;
}

public class LinkedList {
 private Node head;

 public void printHead() {
  Console.WriteLine("print head" + head.data);
 }

 public void ReverseList() {

  Node currentTarget = head;

  Node current = currentTarget.next == null ? currentTarget : currentTarget.next;

  Node currentNextStart = current.next == null ? current : current.next;

  if (current != head) {
   head.next = null;
  }

  while (currentTarget != current) {
   //currentNextStart = current.next == null ? current : current.next;

   // Point current back to currentTaget
   current.next = currentTarget;
   Console.WriteLine("loop 1");
   Console.WriteLine("current" + current.data);
   Console.WriteLine("currentTarget" + currentTarget.data);
   Console.WriteLine("currentNextStart" + currentTarget.data);

   // Set currentTarget as current
   currentTarget = current;
   Console.WriteLine("loop 2");
   Console.WriteLine("current" + current.data);
   Console.WriteLine("currentTarget" + currentTarget.data);
   Console.WriteLine("currentNextStart" + currentTarget.data);

   // Move current to currentNextStart
   current = currentNextStart;
   Console.WriteLine("loop 3");
   Console.WriteLine("current" + current.data);
   Console.WriteLine("currentTarget" + currentTarget.data);
   Console.WriteLine("currentNextStart" + currentTarget.data);

   currentNextStart = currentNextStart.next == null ? currentNextStart : currentNextStart.next;
   Console.WriteLine("loop 4");
   Console.WriteLine("current" + current.data);
   Console.WriteLine("currentTarget" + currentTarget.data);
   Console.WriteLine("currentNextStart" + currentTarget.data);
  }

  head = currentTarget;
 }


 public void printAllNodes() {
  Node current = head;
  while (current != null) {
   Console.WriteLine(current.data);
   current = current.next;
  }
 }

 public void AddFirst(int data) {
  Node toAdd = new Node();

  toAdd.data = data;
  toAdd.next = head;

  head = toAdd;
 }

 public void AddLast(int data) {
  if (head == null) {
   head = new Node();

   head.data = data;
   head.next = null;
  } else {
   Node toAdd = new Node();
   toAdd.data = data;

   Node current = head;
   while (current.next != null) {
    current = current.next;
   }

   current.next = toAdd;
  }
 }
}

public class Program {
 public static void Main() {
  Console.WriteLine("Add First:");
  LinkedList myList1 = new LinkedList();

  myList1.AddLast(1);
  myList1.AddLast(2);
  myList1.AddLast(3);
  myList1.AddLast(4);
  myList1.AddLast(5);
  myList1.AddLast(6);
  myList1.AddLast(7);
  myList1.AddLast(8);
  myList1.printHead();
  myList1.ReverseList();
  myList1.printAllNodes();
  //myList1.printHead();

  Console.WriteLine();
 }
}
