using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class ThreeLongestSubString : SolutionForDisplay
    {
        public ThreeLongestSubString()
        {
            this.richTextBox1.Text = "Given a string s, find the length of the longest substring without repeating characters.";
            this.richTextBox2.Text = "First Example : s = " + Example1;
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : s = " + Example2);
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : s = " + Example3);
            this.ValueChanged += RunLengthOfSubstring;
        }

        string Example1 = "abcabcbb";
        string Example2 = "bbbbb";
        string Example3 = "pwwkew";

        public int LengthOfLongestSubstring(string s)
        {
            string longest = "";
            int l = 0;
            int res = 0;
            for( int r =0; r < s.Length; r++)
            {
                while (longest.Contains(s[r]))
                {
                    longest = longest.Remove(0,1);
                    l += 1;
                }
                longest += s[r];
                res = Math.Max(res,r-l+1);
            }

            return res;
        }

        public void RunLengthOfSubstring(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + LengthOfLongestSubstring(Example1).ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + LengthOfLongestSubstring(Example2).ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + LengthOfLongestSubstring(Example3).ToString());

        }
    }
}
