public class ListNode {
    public int val;
    public ListNode next;
    public ListNode prev;

    public ListNode(int val = 0, ListNode next = null, ListNode prev = null)
    {
        this.val = val;
        this.next = next;
        this.prev = prev;
    }
}


public class MyLinkedList {

    public ListNode left;
    public ListNode right;
    
    public MyLinkedList() {
        left = new ListNode(0);
        right = new ListNode(0);
        left.next = right;
        right.prev = left;
    }
    
    public int Get(int index) {
        var curr = left.next;
        while (curr != null && index > 0)
        {
            curr = curr.next;
            index --;
        }
        if (curr != null && curr != right && index == 0)
            return curr.val;
        return -1;
    }
    
    public void AddAtHead(int val) {
        var node = new ListNode(val);
        var next = left.next;
        var prev = left;
        prev.next = node;
        next.prev = node;
        node.prev = prev;
        node.next = next;
    }
    
    public void AddAtTail(int val) {
        var node = new ListNode(val);
        var next = right;
        var prev = right.prev;
        prev.next = node;
        next.prev = node;
        node.prev = prev;
        node.next = next;
    }
    
    public void AddAtIndex(int index, int val) {
        var curr = left.next;
        while (curr != null && index > 0)
        {
            curr = curr.next;
            index --;
        }
        if (curr != null && index == 0)
        {
            var node = new ListNode(val);
            var next = curr;
            var prev = curr.prev;
            prev.next = node;
            next.prev = node;
            node.next = next;
            node.prev = prev;
        }
    }
    
    public void DeleteAtIndex(int index) {
         var curr = left.next;
        while (curr != null && index > 0)
        {
            curr = curr.next;
            index -=1;
        }
        if (curr != null && curr != right && index == 0)
        {
            var next = curr.next;
            var prev = curr.prev;
            next.prev = prev;
            prev.next = next;
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */