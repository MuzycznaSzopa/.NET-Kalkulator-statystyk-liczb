namespace Zadanie
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtLiczba = new System.Windows.Forms.TextBox();
            this.lstLiczby = new System.Windows.Forms.ListBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblSrednia = new System.Windows.Forms.Label();
            this.lblIlosc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(122, 60);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtLiczba
            // 
            this.txtLiczba.Location = new System.Drawing.Point(122, 18);
            this.txtLiczba.Name = "txtLiczba";
            this.txtLiczba.Size = new System.Drawing.Size(120, 20);
            this.txtLiczba.TabIndex = 1;
            this.txtLiczba.TextChanged += new System.EventHandler(this.txtLiczba_TextChanged);
            // 
            // lstLiczby
            // 
            this.lstLiczby.FormattingEnabled = true;
            this.lstLiczby.Location = new System.Drawing.Point(122, 108);
            this.lstLiczby.Name = "lstLiczby";
            this.lstLiczby.Size = new System.Drawing.Size(120, 95);
            this.lstLiczby.TabIndex = 2;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(288, 60);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 3;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(285, 108);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(30, 13);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Max:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(285, 130);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(27, 13);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(285, 153);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(37, 13);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "Suma:";
            // 
            // lblSrednia
            // 
            this.lblSrednia.AutoSize = true;
            this.lblSrednia.Location = new System.Drawing.Point(285, 177);
            this.lblSrednia.Name = "lblSrednia";
            this.lblSrednia.Size = new System.Drawing.Size(46, 13);
            this.lblSrednia.TabIndex = 7;
            this.lblSrednia.Text = "Średnia:";
            // 
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.Location = new System.Drawing.Point(285, 190);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(0, 13);
            this.lblIlosc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wprowadź liczbę:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista dodanych liczb:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIlosc);
            this.Controls.Add(this.lblSrednia);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.lstLiczby);
            this.Controls.Add(this.txtLiczba);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtLiczba;
        private System.Windows.Forms.ListBox lstLiczby;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblSrednia;
        private System.Windows.Forms.Label lblIlosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

