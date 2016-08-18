namespace master
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAproks = new System.Windows.Forms.Button();
            this.btnMassCalc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abautToolStripMenuItem,
            this.оАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abautToolStripMenuItem
            // 
            this.abautToolStripMenuItem.Name = "abautToolStripMenuItem";
            this.abautToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.abautToolStripMenuItem.Text = "О программе";
            // 
            // оАвтореToolStripMenuItem
            // 
            this.оАвтореToolStripMenuItem.Name = "оАвтореToolStripMenuItem";
            this.оАвтореToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.оАвтореToolStripMenuItem.Text = "О авторе";
            // 
            // btnAproks
            // 
            this.btnAproks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAproks.Location = new System.Drawing.Point(12, 27);
            this.btnAproks.Name = "btnAproks";
            this.btnAproks.Size = new System.Drawing.Size(180, 48);
            this.btnAproks.TabIndex = 2;
            this.btnAproks.Text = "Подгоночка";
            this.btnAproks.UseVisualStyleBackColor = true;
            this.btnAproks.Click += new System.EventHandler(this.btnAproks_Click);
            // 
            // btnMassCalc
            // 
            this.btnMassCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMassCalc.Location = new System.Drawing.Point(12, 97);
            this.btnMassCalc.Name = "btnMassCalc";
            this.btnMassCalc.Size = new System.Drawing.Size(180, 48);
            this.btnMassCalc.TabIndex = 3;
            this.btnMassCalc.Text = "Калькулятор Газов";
            this.btnMassCalc.UseVisualStyleBackColor = true;
            this.btnMassCalc.Click += new System.EventHandler(this.btnMassCalc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::master.Properties.Resources.coolmass1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 597);
            this.Controls.Add(this.btnMassCalc);
            this.Controls.Add(this.btnAproks);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(461, 636);
            this.MinimumSize = new System.Drawing.Size(461, 636);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master\'s tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оАвтореToolStripMenuItem;
        private System.Windows.Forms.Button btnAproks;
        private System.Windows.Forms.Button btnMassCalc;
    }
}

