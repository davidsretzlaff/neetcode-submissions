public class ListNode
{
    public string val;
    public ListNode prev;
    public ListNode next;
    public ListNode(string val = null, ListNode prev = null, ListNode next = null)
    {
        this.val = val;
        this.prev = prev;
        this.next = next;
    }    
}

public class BrowserHistory {
    public ListNode cur;

    public BrowserHistory(string homepage) {       
        cur = new ListNode(homepage);
    }
    
    public void Visit(string url) {
        cur.next = new ListNode(url, cur, null);
        cur = cur.next;
    }
    
    public string Back(int steps) {
        while (cur.prev != null && steps > 0)
        {
            cur = cur.prev;
            steps --;
        }
        return cur.val;
    }
    
    public string Forward(int steps) {
        while (cur.next != null && steps > 0)
        {
            cur = cur.next;
            steps --;
        }        
        return cur.val;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */