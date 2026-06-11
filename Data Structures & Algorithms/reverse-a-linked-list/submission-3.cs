
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        ListNode nextPointer = null;
        while (curr != null)
        {
            nextPointer = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextPointer;
        }
        return prev;
    }    
}
