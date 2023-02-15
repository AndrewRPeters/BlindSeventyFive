using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class FourteenLongestCommonPrefix : SolutionForDisplay
    {
        
        public FourteenLongestCommonPrefix()
        {
            this.richTextBox1.Text = "Write a function to find the longest common prefix string amongst an array of strings.";
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "If there is no common prefix, return an empty string ");
            this.richTextBox2.Text = "First Example : [" + string.Join(", ", EXOne) + "]   Target : 9";
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : [" + string.Join(", ", EXTwo) + "]  Target: 6");
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : [" + string.Join(", ", EXThree) + "]  Target: 6");
            this.ValueChanged += RunTwoSum;
        }
        
        string[] EXOne = { "flower", "flow", "flight" };
        string[] EXTwo = { "dog", "racecar", "car" };
        string[] EXThree = { "ground", "growl", "grow" };

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs[0].Length == 0) return "";
            string Return = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                Char Pref = strs[0].ToCharArray()[i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j].Length == i || strs[j].ToCharArray()[i] != Pref)
                        return Return;
                }
                Return += Pref;
            }
            return Return;
        }

        public void RunTwoSum(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + LongestCommonPrefix(EXOne));
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + LongestCommonPrefix(EXTwo));
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + LongestCommonPrefix(EXThree));
        }

    }
}
