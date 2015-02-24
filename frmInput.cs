using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinEmailVerifier
{
    public partial class frmInput : Form
    {
        private frmMain mainForm = null; 
        public frmInput(Form callingForm)
        {
            mainForm = callingForm as frmMain;  
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainForm.LabelText = textBox1.Text;
            this.Dispose(); 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.mainForm.LabelText = textBox1.Text;
                this.Dispose(); 
            }
        }

        private void frmInput_Load(object sender, EventArgs e)
        {

        }

 
    }
}
