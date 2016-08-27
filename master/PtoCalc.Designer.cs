namespace master
{
    partial class PtoCalc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.подсказкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUpDownPropan = new System.Windows.Forms.NumericUpDown();
            this.nUpDownMAF = new System.Windows.Forms.NumericUpDown();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblMAF = new System.Windows.Forms.Label();
            this.lblAcetelen = new System.Windows.Forms.Label();
            this.nUpDownAcetelen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPropan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMAF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAcetelen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подсказкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // подсказкаToolStripMenuItem
            // 
            this.подсказкаToolStripMenuItem.Name = "подсказкаToolStripMenuItem";
            this.подсказкаToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.подсказкаToolStripMenuItem.Text = "Подсказка";
            this.подсказкаToolStripMenuItem.Click += new System.EventHandler(this.подсказкаToolStripMenuItem_Click);
            // 
            // nUpDownPropan
            // 
            this.nUpDownPropan.DecimalPlaces = 3;
            this.nUpDownPropan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDownPropan.Location = new System.Drawing.Point(30, 91);
            this.nUpDownPropan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUpDownPropan.Name = "nUpDownPropan";
            this.nUpDownPropan.Size = new System.Drawing.Size(120, 31);
            this.nUpDownPropan.TabIndex = 1;
            this.nUpDownPropan.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nUpDownPropan.ValueChanged += new System.EventHandler(this.nUpDownPropan_ValueChanged);
            // 
            // nUpDownMAF
            // 
            this.nUpDownMAF.DecimalPlaces = 3;
            this.nUpDownMAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDownMAF.Location = new System.Drawing.Point(187, 91);
            this.nUpDownMAF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUpDownMAF.Name = "nUpDownMAF";
            this.nUpDownMAF.Size = new System.Drawing.Size(120, 31);
            this.nUpDownMAF.TabIndex = 2;
            this.nUpDownMAF.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nUpDownMAF.ValueChanged += new System.EventHandler(this.nUpDownMAF_ValueChanged);
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProp.Location = new System.Drawing.Point(26, 64);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(134, 24);
            this.lblProp.TabIndex = 3;
            this.lblProp.Text = "Пропан-бутан";
            // 
            // lblMAF
            // 
            this.lblMAF.AutoSize = true;
            this.lblMAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMAF.Location = new System.Drawing.Point(220, 64);
            this.lblMAF.Name = "lblMAF";
            this.lblMAF.Size = new System.Drawing.Size(55, 24);
            this.lblMAF.TabIndex = 4;
            this.lblMAF.Text = "МАФ";
            // 
            // lblAcetelen
            // 
            this.lblAcetelen.AutoSize = true;
            this.lblAcetelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAcetelen.Location = new System.Drawing.Point(363, 64);
            this.lblAcetelen.Name = "lblAcetelen";
            this.lblAcetelen.Size = new System.Drawing.Size(98, 24);
            this.lblAcetelen.TabIndex = 6;
            this.lblAcetelen.Text = "Ацетелен";
            // 
            // nUpDownAcetelen
            // 
            this.nUpDownAcetelen.DecimalPlaces = 3;
            this.nUpDownAcetelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDownAcetelen.Location = new System.Drawing.Point(354, 91);
            this.nUpDownAcetelen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUpDownAcetelen.Name = "nUpDownAcetelen";
            this.nUpDownAcetelen.Size = new System.Drawing.Size(120, 31);
            this.nUpDownAcetelen.TabIndex = 5;
            this.nUpDownAcetelen.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nUpDownAcetelen.ValueChanged += new System.EventHandler(this.nUpDownAcetelen_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 62);
            this.label1.TabIndex = 7;
            this.label1.Text = "1 [кг] Пропан-бутан = 0,613 [кг] МАФ\r\n1 [м3] Ацетилен= 1,06 [кг] МАФ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(59, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "КГ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(219, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "КГ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(381, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "М3\r\n";
            // 
            // PtoCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAcetelen);
            this.Controls.Add(this.nUpDownAcetelen);
            this.Controls.Add(this.lblMAF);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.nUpDownMAF);
            this.Controls.Add(this.nUpDownPropan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(559, 339);
            this.MinimumSize = new System.Drawing.Size(559, 339);
            this.Name = "PtoCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор горючих газов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPropan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMAF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAcetelen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подсказкаToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nUpDownPropan;
        private System.Windows.Forms.NumericUpDown nUpDownMAF;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.Label lblMAF;
        private System.Windows.Forms.Label lblAcetelen;
        private System.Windows.Forms.NumericUpDown nUpDownAcetelen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}