using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace master
{
    public partial class PtoCalc : Form
    {
        double mafValue;// значения мафа
        double propButValue; // значение пропан бутана 

        public PtoCalc()
        {
            InitializeComponent();
        }


        private void nUpDownPropan_ValueChanged(object sender, EventArgs e)
        {
            if (nUpDownPropan.Focused==true)
            {
                getValue();
                mafValue = propButValue * 0.613;
                nUpDownMAF.Value = Convert.ToDecimal(mafValue);
            }


        }

        private void nUpDownMAF_ValueChanged(object sender, EventArgs e)
        {
            if (nUpDownMAF.Focused==true)
            {
                getValue();
                propButValue = mafValue * 1.63;
                nUpDownPropan.Value = Convert.ToDecimal(propButValue);

            }
        }

        // получить значения 
        public void getValue()
        {
            mafValue = Convert.ToDouble(nUpDownMAF.Value);
            propButValue = Convert.ToDouble(nUpDownPropan.Value);
            

        }

        private void подсказкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все работает по щелчку.\n Единица измерения килограммы.", "подсказка");
        }
    }

}
