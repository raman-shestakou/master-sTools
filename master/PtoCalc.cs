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
        double acetilValue; // значение ацетелена

        public PtoCalc()
        {
            InitializeComponent();
        }


        private void nUpDownPropan_ValueChanged(object sender, EventArgs e)
        {
            returnValue();
        }

        private void nUpDownMAF_ValueChanged(object sender, EventArgs e)
        {
            returnValue();
        }

        // получить значения 
        public void getValue()
        {
            mafValue = Convert.ToDouble(nUpDownMAF.Value);
            propButValue = Convert.ToDouble(nUpDownPropan.Value);
            acetilValue = Convert.ToDouble(nUpDownAcetelen.Value);
        }
        //печать значений
        public void printValue()
        {
            nUpDownPropan.Value = Convert.ToDecimal(propButValue);
            nUpDownAcetelen.Value = Convert.ToDecimal(acetilValue);
            nUpDownMAF.Value = Convert.ToDecimal(mafValue);
        }


        // в зависимости от смены нумерика
        public void returnValue()
        {
            getValue();
            // MAF
            if (nUpDownMAF.Focused == true)
            {
                propButValue = mafValue * 1.63;
                acetilValue = mafValue * 0.943;
            }
            //Propan
            if (nUpDownPropan.Focused == true)
            {
                mafValue = propButValue * 0.613;
                acetilValue = mafValue * 0.943;
            }
            // Acetilen
            if (nUpDownAcetelen.Focused == true)
            {
                mafValue = acetilValue * 1.06;
                propButValue = mafValue * 1.63;
            }
            printValue();
        }

        private void подсказкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все работает по щелчку.", "подсказка");
        }

        private void nUpDownAcetelen_ValueChanged(object sender, EventArgs e)
        {
            returnValue();
        }
    }

}
