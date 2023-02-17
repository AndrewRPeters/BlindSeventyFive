using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class TwentyValidParentheses : SolutionForDisplay
    {

        public TwentyValidParentheses()
        {
            this.richTextBox1.Text = "Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid";
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "An input string is valid if:");
            this.richTextBox1.AppendText(Environment.NewLine + "Open brackets must be closed by the same type of brackets.");
            this.richTextBox1.AppendText(Environment.NewLine + "Open brackets must be closed in the correct order.");
            this.richTextBox1.AppendText(Environment.NewLine + "Every close bracket has a corresponding open bracket of the same type.");

            this.richTextBox2.Text = "First Example : s = '()'";
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : s = '()[]{}'");
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : s = '(]'");
            this.ValueChanged += RunIsValid;
        }

        public bool IsValid(string s)
        {
            char[] charArray = s.ToCharArray();
            Stack<Char> P = new Stack<char>();
            char[] closing = { ')', ']', '}' };
            char[] opening = { '(', '[', '{' };
            for (int i = 0; i < charArray.Length; i++)
            {
                if (opening.Contains(charArray[i]))
                    P.Push(charArray[i]);
                else if (closing.Contains(charArray[i]) && P.Count > 0 && P.Peek() == opening[Array.IndexOf(closing, charArray[i])])
                    P.Pop();
                else
                    return false;
            }
            if (P.Count > 0)
                return false;
            return true;
        }
        public void RunIsValid(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + IsValid("()").ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + IsValid("()[]{}").ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + IsValid("(]").ToString());
        }

    }
}
