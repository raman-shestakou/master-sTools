using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace master
{
    public partial class FormBetonSettings : Form
    {
        public FormBetonSettings()
        {
            InitializeComponent();
        }

        private void FormBetonSettings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concreteDataSet.BetonCollection". При необходимости она может быть перемещена или удалена.
          //  this.betonCollectionTableAdapter.Fill(this.concreteDataSet.BetonCollection);

        }
    }
}
