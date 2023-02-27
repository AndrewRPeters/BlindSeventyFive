using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class SixtySixPlusOne : SolutionForDisplay
    {

        public SixtySixPlusOne()
        {
            this.richTextBox1.Text = "You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.";
            this.richTextBox1.AppendText(Environment.NewLine + "The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.");

            this.richTextBox2.Text = "First Example : digits = [1,2,3]";
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : digits = [4,3,2,1]");
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : digits = [9]");
            this.ValueChanged += RunPlusOne;
        }

        int[] TestOne = { 1, 2, 3 };
        int[] TestTwo = { 4, 3, 2, 1 };
        int[] TestThree = { 9 };

        public int[] PlusOne(int[] digits)
        {
            Array.Reverse(digits); 
            int one = 1;
            int i = 0;

            while (one ==1 )
            {
                if (i < digits.Length)
                {
                    if (digits[i] == 9)
                        digits[i] = 0;
                    else
                    {
                        digits[i] += 1;
                        one = 0;
                    }
                }
                else
                {
                    Array.Resize(ref digits, digits.Length + 1);
                    digits[i] = 1;
                    one = 0;
                }
                i++;
            }
            Array.Reverse(digits);
            return digits;

        }

        public void RunPlusOne(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + string.Join(", ", PlusOne(TestOne)));
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + string.Join(", ", PlusOne(TestTwo)));
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + string.Join(", ", PlusOne(TestThree)));
        }

    }
}
