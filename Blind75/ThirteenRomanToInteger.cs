using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class ThirteenRomanToInteger : SolutionForDisplay
    {

        public ThirteenRomanToInteger()
        {
            this.richTextBox1.Text = "Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.";
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.");
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:");
            this.richTextBox1.AppendText(Environment.NewLine);
            this.richTextBox1.AppendText(Environment.NewLine + "I can be placed before V (5) and X (10) to make 4 and 9. ");
            this.richTextBox1.AppendText(Environment.NewLine + "X can be placed before L (50) and C (100) to make 40 and 90. ");
            this.richTextBox1.AppendText(Environment.NewLine + "C can be placed before D (500) and M (1000) to make 400 and 900.");
            this.richTextBox2.Text = "First Example : s = 'III''";
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : s = 'LVIII'");
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : s = 'MCMXCIV'");
            this.ValueChanged += RunMaxArea;

        }

        public int RomanToInt(string s)
        {
            int number = 0;
            char[] roman = s.ToCharArray();
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
                {
                    number -= RomanMap[roman[i]];
                }
                else
                {
                    number += RomanMap[roman[i]];
                }
            }
            return number;
        }

        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

        public void RunMaxArea(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + RomanToInt("III").ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + RomanToInt("LVIII").ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + RomanToInt("MCMXCIV").ToString());
        }

    }
}
