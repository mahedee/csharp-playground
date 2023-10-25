namespace BasicProgramming
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
        public ListNode AppendNode(int val, ListNode result)
        {
            ListNode head = result;

            if (head == null)
            {
                head = new ListNode(val);
                return head;
            }

            // reach to the last node


            ListNode temp = head;
            // iterate till last node
            // but doesn't change the value of head
            while (temp.next != null)
            {
                temp = temp.next;
            }

            // add new node to the last node
            temp.next = new ListNode(val);

            // how it change the value of head here??
            return head;
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode resultNode = null;
            int minVal = -101;

            //while break if list1 is null or list2 is null
            //after while check if list1 is not null then add next elements to result node
            //after while check if list2 is not null then add next elements to result node

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    //minVal = list1.val;
                    // add minVal to result node
                    resultNode = AppendNode(list1.val, resultNode);
                    list1 = list1.next;
                }
                else
                {
                    // minVal = list2.val;
                    // add minVal to result node
                    resultNode = AppendNode(list2.val, resultNode);
                    list2 = list2.next;
                }
            }

            while (list1 != null)
            {
                //minVal = list1.val;
                // add minVal to result node
                resultNode = AppendNode(list1.val, resultNode);
                list1 = list1.next;
            }

            while (list2 != null)
            {
                //minVal = list1.val;
                // add minVal to result node
                resultNode = AppendNode(list2.val, resultNode);
                list2 = list2.next;
            }

            return resultNode;
        }

    }
}

