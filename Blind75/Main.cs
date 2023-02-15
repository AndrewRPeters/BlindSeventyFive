using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blind75
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_Prob1_Click(object sender, EventArgs e)
        {
            var m = new OneTwoSum();
            m.Show();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            var m = new NinePalindromeNumber();
            m.Show();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            var m = new ElevenContainerWithMostWater();
            m.Show();

        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            var m = new ThirteenRomanToInteger();
            m.Show();
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            var m = new FourteenLongestCommonPrefix();
            m.Show();
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            var m = new TwentyValidParentheses();
            m.Show();
        }
    }
}
