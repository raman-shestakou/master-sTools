using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace master
{
    public partial class MainForm : Form
    {
     
        public MainForm()
        {
            InitializeComponent();
        }

    

        public void btnAproks_Click(object sender, EventArgs e)
        {
            fLinterp linterp = new fLinterp();
            linterp.Show();
        }

        private void btnMassCalc_Click(object sender, EventArgs e)
        {
            PtoCalc ptoCalc = new PtoCalc();
            ptoCalc.Show();
        }

        private void btnBetonCalc_Click(object sender, EventArgs e)
        {
            FormBetonCalc FbetonCalc = new FormBetonCalc();
            FbetonCalc.Show();
        }
    }
}
