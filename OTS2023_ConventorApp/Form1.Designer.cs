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
            this.rbLength = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustomMoney = new System.Windows.Forms.Label();
            this.rbCustomMoney = new System.Windows.Forms.RadioButton();
            this.lblMoney = new System.Windows.Forms.Label();
            this.rbTime = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.rbMoney = new System.Windows.Forms.RadioButton();
            this.rbMass = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
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
            this.tbPocetni.Location = new System.Drawing.Point(106, 135);
            this.tbPocetni.Name = "tbPocetni";
            this.tbPocetni.Size = new System.Drawing.Size(100, 20);
            this.tbPocetni.TabIndex = 1;
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(106, 166);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.ReadOnly = true;
            this.tbRezultat.Size = new System.Drawing.Size(100, 20);
            this.tbRezultat.TabIndex = 2;
            // 
            // lblPocetni
            // 
            this.lblPocetni.AutoSize = true;
            this.lblPocetni.Location = new System.Drawing.Point(16, 138);
            this.lblPocetni.Name = "lblPocetni";
            this.lblPocetni.Size = new System.Drawing.Size(88, 13);
            this.lblPocetni.TabIndex = 3;
            this.lblPocetni.Text = "Unesite podatak:";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(54, 169);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(49, 13);
            this.lblRezultat.TabIndex = 4;
            this.lblRezultat.Text = "Rezultat:";
            // 
            // rbLength
            // 
            this.rbLength.AutoSize = true;
            this.rbLength.Location = new System.Drawing.Point(23, 51);
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
            this.label3.Location = new System.Drawing.Point(43, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Length";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMass);
            this.groupBox1.Controls.Add(this.lblCustomMoney);
            this.groupBox1.Controls.Add(this.rbCustomMoney);
            this.groupBox1.Controls.Add(this.lblMoney);
            this.groupBox1.Controls.Add(this.rbTime);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.rbMoney);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbLength);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter type";
            // 
            // lblCustomMoney
            // 
            this.lblCustomMoney.AutoSize = true;
            this.lblCustomMoney.Location = new System.Drawing.Point(89, 73);
            this.lblCustomMoney.Name = "lblCustomMoney";
            this.lblCustomMoney.Size = new System.Drawing.Size(77, 13);
            this.lblCustomMoney.TabIndex = 11;
            this.lblCustomMoney.Text = "Custom Money";
            // 
            // rbCustomMoney
            // 
            this.rbCustomMoney.AutoSize = true;
            this.rbCustomMoney.Location = new System.Drawing.Point(69, 72);
            this.rbCustomMoney.Name = "rbCustomMoney";
            this.rbCustomMoney.Size = new System.Drawing.Size(14, 13);
            this.rbCustomMoney.TabIndex = 13;
            this.rbCustomMoney.TabStop = true;
            this.rbCustomMoney.UseVisualStyleBackColor = true;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(147, 21);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(39, 13);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "Money";
            // 
            // rbTime
            // 
            this.rbTime.AutoSize = true;
            this.rbTime.Location = new System.Drawing.Point(127, 51);
            this.rbTime.Name = "rbTime";
            this.rbTime.Size = new System.Drawing.Size(14, 13);
            this.rbTime.TabIndex = 12;
            this.rbTime.TabStop = true;
            this.rbTime.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(147, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time";
            // 
            // rbMoney
            // 
            this.rbMoney.AutoSize = true;
            this.rbMoney.Location = new System.Drawing.Point(127, 21);
            this.rbMoney.Name = "rbMoney";
            this.rbMoney.Size = new System.Drawing.Size(14, 13);
            this.rbMoney.TabIndex = 9;
            this.rbMoney.TabStop = true;
            this.rbMoney.UseVisualStyleBackColor = true;
            // 
            // rbMass
            // 
            this.rbMass.AutoSize = true;
            this.rbMass.Location = new System.Drawing.Point(23, 21);
            this.rbMass.Name = "rbMass";
            this.rbMass.Size = new System.Drawing.Size(14, 13);
            this.rbMass.TabIndex = 10;
            this.rbMass.TabStop = true;
            this.rbMass.UseVisualStyleBackColor = true;
            this.rbMass.CheckedChanged += new System.EventHandler(this.rbMass_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblPocetni);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tbPocetni);
            this.Controls.Add(this.btnKonvertuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKonvertuj;
        private System.Windows.Forms.TextBox tbPocetni;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Label lblPocetni;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.RadioButton rbLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.RadioButton rbMoney;
        private System.Windows.Forms.RadioButton rbCustomMoney;
        private System.Windows.Forms.RadioButton rbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCustomMoney;
        private System.Windows.Forms.RadioButton rbMass;
    }
}

