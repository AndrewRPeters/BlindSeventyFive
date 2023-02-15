using Blind75.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    class ElevenContainerWithMostWater : SolutionForDisplay
    {
        public ElevenContainerWithMostWater()
        {
            this.richTextBox1.Text = "You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).";
            this.richTextBox1.AppendText(Environment.NewLine + "Find two lines that together with the x-axis form a container, such that the container contains the most water.");
            this.richTextBox1.AppendText(Environment.NewLine + "Return the maximum amount of water a container can store.");
            this.ImageForDisplay.Image = global::Blind75.Properties.Resources.question_11;
            this.ImageForDisplay.Visible = true;
            this.richTextBox2.Text = "First Example :  height = " + string.Join(", ", Water1);
            this.richTextBox2.AppendText(Environment.NewLine + "Second Example : height = " + string.Join(", ", Water2));
            this.richTextBox2.AppendText(Environment.NewLine + "Third Example : height = " + string.Join(", ", Water3));
            this.ValueChanged += RunMaxArea;

        }

        int[] Water1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int[] Water2 = { 1, 1 };
        int[] Water3 = { 2, 2, 3, 5, 8, 4, 6, 8, 1 };


        public int MaxArea(int[] height)
        {
            int max = 0;
            int i = 0;
            int j = height.Length - 1;
            while (i != j)
            {
                if (height[i] <= height[j])
                {
                    max = GetMax((j - i) * height[i], max);
                    i++;
                }
                else
                {
                    max = GetMax((j - i) * height[j], max);
                    j--;
                }
            }
            return max;
        }

        public static int GetMax(int first, int second)
        {
            return first > second ? first : second;
        }


        public void RunMaxArea(object sender, EventArgs e)
        {
            this.richTextBox3.Text = ("Answeres: ");
            this.richTextBox3.AppendText(Environment.NewLine + "First Example : " + MaxArea(Water1).ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Second Example : " + MaxArea(Water2).ToString());
            this.richTextBox3.AppendText(Environment.NewLine + "Third Example : " + MaxArea(Water3).ToString());
        }
    }
}