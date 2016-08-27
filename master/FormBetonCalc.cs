using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace master
{
    public partial class FormBetonCalc : Form
    {
        FormBetonSettings FBetSettings = new FormBetonSettings();
        public FormBetonCalc()
        {
            InitializeComponent();
        }

        private void btnBetonSetings_Click(object sender, EventArgs e)
        {
            FBetSettings.ShowDialog();
        }
    }
}
