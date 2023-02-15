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
    public partial class SolutionForDisplay : Form
    {
        #region private data
        private bool returnValue = false;
        #endregion

        #region

        public bool ReturnValue 
        {
            get { return returnValue; }
            set
            {
                returnValue = value;
                OnValueChanged(null); 
            } 
        }
        #endregion
        public SolutionForDisplay()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReturnValue = true;
        }

        public event EventHandler ValueChanged;

        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }


    }
}
