namespace OOP_ukol1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_SPZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nosnost = new System.Windows.Forms.TextBox();
            this.vytvorit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_naklad = new System.Windows.Forms.TextBox();
            this.nalozit = new System.Windows.Forms.Button();
            this.vylozit = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_SPZ
            // 
            this.textBox_SPZ.Location = new System.Drawing.Point(142, 12);
            this.textBox_SPZ.Name = "textBox_SPZ";
            this.textBox_SPZ.Size = new System.Drawing.Size(100, 20);
            this.textBox_SPZ.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadej SPZ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zadej max. nosnost:";
            // 
            // textBox_nosnost
            // 
            this.textBox_nosnost.Location = new System.Drawing.Point(142, 38);
            this.textBox_nosnost.Name = "textBox_nosnost";
            this.textBox_nosnost.Size = new System.Drawing.Size(100, 20);
            this.textBox_nosnost.TabIndex = 3;
            // 
            // vytvorit
            // 
            this.vytvorit.Location = new System.Drawing.Point(248, 36);
            this.vytvorit.Name = "vytvorit";
            this.vytvorit.Size = new System.Drawing.Size(82, 23);
            this.vytvorit.TabIndex = 5;
            this.vytvorit.Text = "Vytvořit auto";
            this.vytvorit.UseVisualStyleBackColor = true;
            this.vytvorit.Click += new System.EventHandler(this.vytvorit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zadej hmotnost nákladu:";
            // 
            // textBox_naklad
            // 
            this.textBox_naklad.Location = new System.Drawing.Point(142, 64);
            this.textBox_naklad.Name = "textBox_naklad";
            this.textBox_naklad.Size = new System.Drawing.Size(100, 20);
            this.textBox_naklad.TabIndex = 7;
            // 
            // nalozit
            // 
            this.nalozit.Location = new System.Drawing.Point(248, 62);
            this.nalozit.Name = "nalozit";
            this.nalozit.Size = new System.Drawing.Size(82, 23);
            this.nalozit.TabIndex = 8;
            this.nalozit.Text = "Naložit náklad";
            this.nalozit.UseVisualStyleBackColor = true;
            this.nalozit.Click += new System.EventHandler(this.nalozit_Click);
            // 
            // vylozit
            // 
            this.vylozit.Location = new System.Drawing.Point(336, 62);
            this.vylozit.Name = "vylozit";
            this.vylozit.Size = new System.Drawing.Size(82, 23);
            this.vylozit.TabIndex = 9;
            this.vylozit.Text = "Vyložit náklad";
            this.vylozit.UseVisualStyleBackColor = true;
            this.vylozit.Click += new System.EventHandler(this.vylozit_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(336, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(82, 47);
            this.info.TabIndex = 0;
            this.info.Text = "Zobrazit info o nákladním autě";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 96);
            this.Controls.Add(this.vylozit);
            this.Controls.Add(this.nalozit);
            this.Controls.Add(this.textBox_naklad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vytvorit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nosnost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SPZ);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nákladní auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_SPZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nosnost;
        private System.Windows.Forms.Button vytvorit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_naklad;
        private System.Windows.Forms.Button nalozit;
        private System.Windows.Forms.Button vylozit;
        private System.Windows.Forms.Button info;
    }
}

