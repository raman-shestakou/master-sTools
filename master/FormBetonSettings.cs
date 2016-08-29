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
            this.betonCollectionTableAdapter.Fill(this.concreteDataSet.BetonCollection);
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            this.betonCollectionTableAdapter.Update(this.concreteDataSet.BetonCollection);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
        }

        private void FormBetonSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                  "Вы хотите сохранить последние изменения справочника?\n\n\n\nПри выборе варианта \"Нет\" изменения справочника будут недоступны. ",
                  "Внимание!",
                  MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Asterisk,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.ServiceNotification
                  );
            if (result == DialogResult.Yes)
                this.betonCollectionTableAdapter.Update(this.concreteDataSet.BetonCollection);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                
            }




        }
    }
}
