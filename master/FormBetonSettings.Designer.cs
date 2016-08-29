namespace master
{
    partial class FormBetonSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.betonCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concreteDataSet = new master.concreteDataSet();
            this.betonCollectionTableAdapter = new master.concreteDataSetTableAdapters.BetonCollectionTableAdapter();
            this.concreteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakstoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chalkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betonCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concreteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concreteDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.cementDataGridViewTextBoxColumn,
            this.sandDataGridViewTextBoxColumn,
            this.waterDataGridViewTextBoxColumn,
            this.breakstoneDataGridViewTextBoxColumn,
            this.chalkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.betonCollectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(781, 66);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 9;
            this.btnSaveData.Text = "Сохранить";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(781, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // betonCollectionBindingSource
            // 
            this.betonCollectionBindingSource.DataMember = "BetonCollection";
            this.betonCollectionBindingSource.DataSource = this.concreteDataSet;
            // 
            // concreteDataSet
            // 
            this.concreteDataSet.DataSetName = "concreteDataSet";
            this.concreteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betonCollectionTableAdapter
            // 
            this.betonCollectionTableAdapter.ClearBeforeFill = true;
            // 
            // concreteDataSetBindingSource
            // 
            this.concreteDataSetBindingSource.DataSource = this.concreteDataSet;
            this.concreteDataSetBindingSource.Position = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "mark";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // cementDataGridViewTextBoxColumn
            // 
            this.cementDataGridViewTextBoxColumn.DataPropertyName = "cement";
            this.cementDataGridViewTextBoxColumn.HeaderText = "cement";
            this.cementDataGridViewTextBoxColumn.Name = "cementDataGridViewTextBoxColumn";
            // 
            // sandDataGridViewTextBoxColumn
            // 
            this.sandDataGridViewTextBoxColumn.DataPropertyName = "sand";
            this.sandDataGridViewTextBoxColumn.HeaderText = "sand";
            this.sandDataGridViewTextBoxColumn.Name = "sandDataGridViewTextBoxColumn";
            // 
            // waterDataGridViewTextBoxColumn
            // 
            this.waterDataGridViewTextBoxColumn.DataPropertyName = "water";
            this.waterDataGridViewTextBoxColumn.HeaderText = "water";
            this.waterDataGridViewTextBoxColumn.Name = "waterDataGridViewTextBoxColumn";
            // 
            // breakstoneDataGridViewTextBoxColumn
            // 
            this.breakstoneDataGridViewTextBoxColumn.DataPropertyName = "breakstone";
            this.breakstoneDataGridViewTextBoxColumn.HeaderText = "breakstone";
            this.breakstoneDataGridViewTextBoxColumn.Name = "breakstoneDataGridViewTextBoxColumn";
            // 
            // chalkDataGridViewTextBoxColumn
            // 
            this.chalkDataGridViewTextBoxColumn.DataPropertyName = "chalk";
            this.chalkDataGridViewTextBoxColumn.HeaderText = "chalk";
            this.chalkDataGridViewTextBoxColumn.Name = "chalkDataGridViewTextBoxColumn";
            // 
            // FormBetonSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 343);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBetonSettings";
            this.Text = "FormBetonSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBetonSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormBetonSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betonCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concreteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concreteDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private concreteDataSet concreteDataSet;
        private System.Windows.Forms.BindingSource betonCollectionBindingSource;
        private concreteDataSetTableAdapters.BetonCollectionTableAdapter betonCollectionTableAdapter;
        private System.Windows.Forms.BindingSource concreteDataSetBindingSource;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakstoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chalkDataGridViewTextBoxColumn;
    }
}