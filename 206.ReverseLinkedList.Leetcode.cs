/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
    ListNode currentTarget = head;
        
        if (currentTarget == null)
        {
            return null;
        }
      
      ListNode current = currentTarget.next == null ? currentTarget : currentTarget.next;
      
      ListNode currentNextStart = current.next == null ? current : current.next;
      
      if (current != head)
      {
        head.next = null;
      }
      
      while (currentTarget != current)
      {
      //currentNextStart = current.next == null ? current : current.next;
      
      // Point current back to currentTaget
      current.next = currentTarget;

      
      // Set currentTarget as current
      currentTarget = current;

      
      // Move current to currentNextStart
      current = currentNextStart;

        
        currentNextStart = currentNextStart.next == null ? currentNextStart : currentNextStart.next;
      } 
      
      return currentTarget;  
        
    }
}
