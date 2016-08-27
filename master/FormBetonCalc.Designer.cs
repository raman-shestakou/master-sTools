namespace master
{
    partial class FormBetonCalc
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
            this.btnBetonSetings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBetonSetings
            // 
            this.btnBetonSetings.Location = new System.Drawing.Point(419, 12);
            this.btnBetonSetings.Name = "btnBetonSetings";
            this.btnBetonSetings.Size = new System.Drawing.Size(75, 23);
            this.btnBetonSetings.TabIndex = 0;
            this.btnBetonSetings.Text = "settings";
            this.btnBetonSetings.UseVisualStyleBackColor = true;
            this.btnBetonSetings.Click += new System.EventHandler(this.btnBetonSetings_Click);
            // 
            // FormBetonCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 348);
            this.Controls.Add(this.btnBetonSetings);
            this.Name = "FormBetonCalc";
            this.Text = "Калькулятор бетона";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBetonSetings;
    }
}