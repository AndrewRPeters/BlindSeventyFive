using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Blind75
{

    public class LinkedList
    {
        public ListNode head;

        public void Add(int data)
        {
            ListNode toAdd = new ListNode();
            toAdd.val = data;
            ListNode current = head;
            // traverse all nodes (see the print all nodes method for an example)
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = toAdd;
        }
        public void AddFirst(int data)
        {
            ListNode toAdd = new ListNode();

            toAdd.val = data;
            toAdd.next = head;

            head = toAdd;
        }
    }
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

    class TwentyOneMergeTwoSortedLIsts : SolutionForDisplay
    {
        public TwentyOneMergeTwoSortedLIsts()
        {
            this.richTextBox1.Text = "You are given the heads of two sorted linked lists list1 and list2.";
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.");
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "Return the head of the merged linked list.");

            this.richTextBox2.Text = "First Example : list1 = [1,2,4], list2 = [1,3,4]";
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : list1 = [], list2 = []");
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : list1 = [], list2 = [0]");
            this.ValueChanged += RunMergeTwoLIsts;

            SetupLinkedList();

        }

        LinkedList Example1List1 = new LinkedList();
        LinkedList Example1List2 = new LinkedList();
        LinkedList Example3List2 = new LinkedList();

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null)
                return list2;
            if (list2 is null)
                return list1;

            if (list1.val > list2.val)
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
            else
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
        }

        public void SetupLinkedList()
        {
            Example1List1.AddFirst(1);
            Example1List1.Add(2);
            Example1List1.Add(4);
            Example1List2.AddFirst(1);
            Example1List2.Add(3);
            Example1List2.Add(4);
            Example3List2.AddFirst(0);

        }

        public void RunMergeTwoLIsts(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");

           
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : "  + LinkedToString(MergeTwoLists(Example1List1.head, Example1List2.head)));
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + LinkedToString(MergeTwoLists(new LinkedList().head, new LinkedList().head)));
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + LinkedToString(MergeTwoLists(new ListNode(), Example3List2.head)));

        }

        private string LinkedToString(ListNode list)
        {
            string Result = "";
            if (list == null)
                return Result;
            while (list.next != null)
            {
                Result += list.val.ToString() + ",";
                list = list.next;
            }
                return Result;
        }
    }
}