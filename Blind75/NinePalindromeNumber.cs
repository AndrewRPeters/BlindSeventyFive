using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class NinePalindromeNumber : SolutionForDisplay
    {
        public NinePalindromeNumber()
        {
            this.richTextBox1.Text = "Given an integer x, return true if x is a palindrome, and false otherwise.";
            this.richTextBox2.Text = "First Example :  x = 121";
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : x = -121");
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example :  x = 10");
            this.ValueChanged += RunIsPalindrome;
        }

        public bool IsPalindrome(int x)
        {
            char[] Palin = x.ToString().ToCharArray();
            for (int i = 0; i <= Palin.Length / 2; i++)
            {
                if (Palin[i] != Palin[Palin.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public void RunIsPalindrome(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + IsPalindrome(121).ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + IsPalindrome(-121).ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + IsPalindrome(10).ToString());

        }
    }
}