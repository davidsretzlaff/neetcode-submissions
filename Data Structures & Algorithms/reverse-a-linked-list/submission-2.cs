
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            var nextTemp = curr.next;
            curr.next = prev;
            //Console.WriteLine($"curr.next.val: {curr?.next?.val}");

            prev = curr;
            //Console.WriteLine($"prev.val: {prev?.val}");

            curr = nextTemp;
            //Console.WriteLine($"curr.val: {curr?.val}");
            //Console.WriteLine($"");

        }
        return prev;
    }
}
