namespace OTS2023_ConventorApp
{
    partial class Form1
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
            this.btnKonvertuj = new System.Windows.Forms.Button();
            this.tbPocetni = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.lblPocetni = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.rbMass = new System.Windows.Forms.RadioButton();
            this.rbLength = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKonvertuj
            // 
            this.btnKonvertuj.Location = new System.Drawing.Point(61, 213);
            this.btnKonvertuj.Name = "btnKonvertuj";
            this.btnKonvertuj.Size = new System.Drawing.Size(75, 23);
            this.btnKonvertuj.TabIndex = 0;
            this.btnKonvertuj.Text = "Konvertuj";
            this.btnKonvertuj.UseVisualStyleBackColor = true;
            this.btnKonvertuj.Click += new System.EventHandler(this.btnKonvertuj_Click);
            // 
            // tbPocetni
            // 
            this.tbPocetni.Location = new System.Drawing.Point(106, 114);
            this.tbPocetni.Name = "tbPocetni";
            this.tbPocetni.Size = new System.Drawing.Size(100, 20);
            this.tbPocetni.TabIndex = 1;
            this.tbPocetni.TextChanged += new System.EventHandler(this.tbPocetni_TextChanged);
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(106, 166);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(100, 20);
            this.tbRezultat.TabIndex = 2;
            this.tbRezultat.TextChanged += new System.EventHandler(this.tbRezultat_TextChanged);
            // 
            // lblPocetni
            // 
            this.lblPocetni.AutoSize = true;
            this.lblPocetni.Location = new System.Drawing.Point(12, 117);
            this.lblPocetni.Name = "lblPocetni";
            this.lblPocetni.Size = new System.Drawing.Size(88, 13);
            this.lblPocetni.TabIndex = 3;
            this.lblPocetni.Text = "Unesite podatak:";
            this.lblPocetni.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(42, 169);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(46, 13);
            this.lblRezultat.TabIndex = 4;
            this.lblRezultat.Text = "Rezultat";
            this.lblRezultat.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbMass
            // 
            this.rbMass.AutoSize = true;
            this.rbMass.Location = new System.Drawing.Point(45, 41);
            this.rbMass.Name = "rbMass";
            this.rbMass.Size = new System.Drawing.Size(14, 13);
            this.rbMass.TabIndex = 5;
            this.rbMass.TabStop = true;
            this.rbMass.UseVisualStyleBackColor = true;
            this.rbMass.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbLength
            // 
            this.rbLength.AutoSize = true;
            this.rbLength.Location = new System.Drawing.Point(45, 64);
            this.rbLength.Name = "rbLength";
            this.rbLength.Size = new System.Drawing.Size(14, 13);
            this.rbLength.TabIndex = 6;
            this.rbLength.TabStop = true;
            this.rbLength.UseVisualStyleBackColor = true;
            this.rbLength.CheckedChanged += new System.EventHandler(this.rbLength_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Length";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbLength);
            this.Controls.Add(this.rbMass);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblPocetni);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tbPocetni);
            this.Controls.Add(this.btnKonvertuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKonvertuj;
        private System.Windows.Forms.TextBox tbPocetni;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Label lblPocetni;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.RadioButton rbMass;
        private System.Windows.Forms.RadioButton rbLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

