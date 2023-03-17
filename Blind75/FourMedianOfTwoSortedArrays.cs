using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class FourMedianOfTwoSortedArrays : SolutionForDisplay
    {
        public FourMedianOfTwoSortedArrays()
        {
            this.richTextBox1.Text = "Given a string s, find the length of the longest substring without repeating characters.";
            this.richTextBox2.Text = "First Example : s = " ;
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : s = " );
            this.ValueChanged += RunFindMedianSortedArrays;
        }

        int[] Example1List1 = { 1, 3};
        int[] Example1List2 = { 2 };
        int[] Example2List1 = { 1, 2};
        int[] Example2List2 = { 3, 4};
        int[] Example3List1 = { 1, 1 };
        int[] Example3List2 = { 1, 2 };


        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] sorted = nums1.Concat(nums2).OrderBy(i => i).ToArray();
            int mid = sorted.Length / 2;
            double median = (sorted.Length % 2 != 0) ? (double)sorted[mid] : ((double)sorted[mid] + (double)sorted[mid - 1]) / 2;
            return median;
        }

        public void RunFindMedianSortedArrays(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + FindMedianSortedArrays(Example1List1,Example1List2).ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + FindMedianSortedArrays(Example2List1,Example2List2).ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + FindMedianSortedArrays(Example3List1, Example3List2).ToString());

        }
    }
}
