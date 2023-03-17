using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class FiveLongestPalindorme : SolutionForDisplay
    {
        public FiveLongestPalindorme()
        {
            this.richTextBox1.Text = "Given a string s, find the length of the longest substring without repeating characters.";
            this.richTextBox2.Text = "First Example : s = ";
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : s = ");
            this.ValueChanged += RunLongestPalindrome;
        }

        string Example1 = "babad";
        string Example2 = "cbbd";
        string Example3 = "aacabdkacaa";
        



        public string LongestPalindrome(string s)
        {
            string Res = "";
            int ResLen = 0;
            // find middle of string
            int half = s.Length / 2;
            for (int i = half; i < s.Length; i++)
            {
                // odd length
                int r = i;
                int l = i;
                while ( l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if((r-l+1) > ResLen)
                    {
                        Res = s.Substring(l,r-l+1);
                        ResLen = r - l + 1;
                    }
                    l -= 1;
                    r += 1;
                }
                r = i;
                l = i;
                i++;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if ((r - l + 1) > ResLen)
                    {
                        Res = s.Substring(l, r - l + 1);
                        ResLen = r - l + 1;
                    }
                    l -= 1;
                    r += 1;
                }
            }
            return Res;
        }    

        public void RunLongestPalindrome(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + LongestPalindrome(Example1));
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + LongestPalindrome(Example2));
        }


    }
}
