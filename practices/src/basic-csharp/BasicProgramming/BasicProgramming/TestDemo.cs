namespace BasicProgramming.TestDemo
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            // check if head is null or not
            if (head != null)
            {
                // create new node
                ListNode current = head;
                // loop
                while (current.next != null)
                {
                    if (current.val == current.next.val)
                    {
                        ListNode temp = current.next;
                        current.next = temp.next;
                    }
                    else
                    {
                        // iterate and ignore 
                        current = current.next;
                    }
                }
            }
            return head;
        }
    }

    public class TestApp
    {
        public void Test()
        {
            // create new node
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);

            // create new object
            Solution solution = new Solution();
            // call method
            solution.DeleteDuplicates(head);
        }
    }
}
