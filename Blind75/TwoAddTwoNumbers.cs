using System;

namespace Blind75
{
    class TwoAddTwoNumbers : SolutionForDisplay
    {
        public TwoAddTwoNumbers()
        {
            this.richTextBox1.Text = "You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. ";
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + " Add the two numbers and return the sum as a linked list.");
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "You may assume the two numbers do not contain any leading zero, except the number 0 itself.");
            SetupLinkedList();

            this.richTextBox2.Text = "First Example : list1 = " + LinkedToString(Example1List1.head) + ", list2 = " + LinkedToString(Example1List2.head);
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : list1 = [0], list2 = [0]");
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : list1 = " + LinkedToString(Example3List1.head) + ", list2 = " + LinkedToString(Example3List2.head));
            this.ValueChanged += RunMergeTwoLIsts;


        }

        LinkedList Example1List1 = new LinkedList();
        LinkedList Example1List2 = new LinkedList();
        LinkedList Example3List1 = new LinkedList();
        LinkedList Example3List2 = new LinkedList();

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode Cur = dummy;
            int carry = 0;
            while (list1 != null || list2 != null || carry != 0)
            {
                int v1, v2 = 0;
                v1 = list1 == null ? 0 : list1.val;
                v2 = list2 == null ? 0 : list2.val;

                int val = v1 + v2 + carry;
                carry = val / 10;
                val = val % 10;
                Cur.next = new ListNode(val);
                Cur = Cur.next;
                if (list1 != null)
                    list1 = list1.next;
                if (list2 != null)
                    list2 = list2.next;
            }
            return dummy.next;
        }

        public void SetupLinkedList()
        {
            Example1List1.AddFirst(2);
            Example1List1.Add(4);
            Example1List1.Add(3);
            Example1List2.AddFirst(5);
            Example1List2.Add(6);
            Example1List2.Add(4);
            Example3List1.AddFirst(9);
            Example3List1.Add(9);
            Example3List1.Add(9);
            Example3List1.Add(9);
            Example3List1.Add(9);
            Example3List1.Add(9);
            Example3List1.Add(9);
            Example3List2.AddFirst(9);
            Example3List2.Add(9);
            Example3List2.Add(9);
            Example3List2.Add(9);
        }

        public void RunMergeTwoLIsts(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : "  + LinkedToString(MergeTwoLists(Example1List1.head, Example1List2.head)));
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + LinkedToString(MergeTwoLists(new LinkedList().head, new LinkedList().head)));
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + LinkedToString(MergeTwoLists(Example3List1.head, Example3List2.head)));

        }

        private string LinkedToString(ListNode list)
        {
            string Result = "[";
            if (list == null)
                return Result += "]";
            while (list != null)
            {
                Result += list.val.ToString();
                if (list.next != null)
                    Result += ",";
                list = list.next;
            }
            return Result += "]";
        }
    }
}