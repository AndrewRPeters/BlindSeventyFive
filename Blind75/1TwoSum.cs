using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class OneTwoSum : SolutionForDisplay
    {
        
        public OneTwoSum()
        {
            this.richTextBox1.Text = "Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.";
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "You may assume that each input would have exactly one solution, and you may not use the same element twice.");
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "You can return the answer in any order.");
            this.richTextBox2.Text = "First Example : [" + string.Join(", ", EXOne) + "]   Target : 9";
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : [" + string.Join(", ", EXTwo) + "]  Target: 6");
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : [" + string.Join(", ", EXThree) + "]  Target: 6");
            this.ValueChanged += RunTwoSum;
        }
        
        int[] EXOne = { 2, 7, 11, 15 };
        int[] EXTwo = { 3, 2, 4 };
        int[] EXThree = { 3, 3 };

        public int[] TwoSum(int[] nums, int target)
        {
            int[] ret = { 0, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ret[0] = i;
                        ret[1] = j;
                        return ret;
                    }
                }
            }
            return ret;
        }

        public void RunTwoSum(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + string.Join(", ", TwoSum(EXOne, 9)));
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + string.Join(", ", TwoSum(EXTwo, 6)));
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + string.Join(", ", TwoSum(EXThree, 6)));
        }

    }
}
