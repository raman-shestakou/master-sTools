using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace master
{
    public partial class fLinterp : Form
    {
        HelpLinterp helpLin = new HelpLinterp();
        public fLinterp()
        {
            InitializeComponent();
        }

        private void fLinterp_Load(object sender, EventArgs e)
        {

        }
        //проверям значения чисел
        public void check()
        {
            if ((nUpX0.Value > nUpX1.Value) || (nUpX2.Value < nUpX1.Value) || (nUpX0.Value > nUpX2.Value))
            {
                Eror();
            }
            if ((nUpX0.Value < nUpX1.Value) && (nUpX1.Value < nUpX2.Value))
            {
                Work();
                //лень исправлять кодямбу поэтому тут так
                var y0 = nUpY0.Value;
                var y1 = nUpY1.Value;
                var y2 = nUpY2.Value;
                var x0 = nUpX0.Value;
                var x1 = nUpX1.Value;
                var x2 = nUpX2.Value;
                //сам расчёт         
                if (checkBoxY0.Checked) { nUpY0.Value = (y1 * (x0 - x2) + y2 * (x1 - x0)) / (x1 - x2); }
                if (checkBoxY1.Checked) { nUpY1.Value = y0 + (x1 - x0) / (x2 - x0) * (y2 - y0); }
                if (checkBoxY2.Checked) { nUpY2.Value = y0 + (y1 - y0) * (x2 - x0) / (x1 - x0); }

            }



        }
        //действия при ошибке
        public void Eror()
        {
            lblHelp.Visible = true;
            lblHelp.Text = "x1 не пренадлежит \r интервалу x0-x2";
            labelX0.ForeColor = Color.Red;
            labelX1.ForeColor = Color.Red;
            labelX2.ForeColor = Color.Red;
        }
        //действия когда всё чётко введено
        public void Work()
        {
            lblHelp.Visible = false;
            labelX0.ForeColor = Color.Green;
            labelX1.ForeColor = Color.Green;
            labelX2.ForeColor = Color.Green;

        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            check();
        }

        private void подсказкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpLin.ShowDialog();
        }

        private void checkBoxY0_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxY0.Checked)
            {
                case true:
                    checkBoxY1.Visible = false;
                    checkBoxY2.Visible = false;
                    break;
                default:
                    checkBoxY1.Visible = true;
                    checkBoxY2.Visible = true;
                    break;

            }
        }

        private void checkBoxY1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxY1.Checked)
            {
                case true:
                    
                    checkBoxY0.Visible = false;
                    checkBoxY2.Visible = false;
                    break;
                default:
                  
                    checkBoxY0.Visible = true;
                    checkBoxY2.Visible = true;
                    break;

            }
        }

        private void checkBoxY2_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxY2.Checked)
            {
                case true:
                    checkBoxY1.Visible = false;
                    checkBoxY0.Visible = false;
                    break;
                default:
                    checkBoxY1.Visible = true;
                    checkBoxY0.Visible = true;
                    break;

            }
        }
    }
}
