namespace BankaHesabi
{
    partial class addregister
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtxttc = new System.Windows.Forms.MaskedTextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.mtxtphone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmbbnk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C Kimlik No : ";
            // 
            // mtxttc
            // 
            this.mtxttc.Location = new System.Drawing.Point(146, 18);
            this.mtxttc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtxttc.Mask = "00000000000";
            this.mtxttc.Name = "mtxttc";
            this.mtxttc.Size = new System.Drawing.Size(164, 26);
            this.mtxttc.TabIndex = 1;
            this.mtxttc.ValidatingType = typeof(int);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(146, 61);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(164, 26);
            this.txtname.TabIndex = 2;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(185, 271);
            this.btnregister.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(125, 32);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "Kayıt Ol";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon : ";
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(146, 111);
            this.txtsname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(164, 26);
            this.txtsname.TabIndex = 6;
            // 
            // mtxtphone
            // 
            this.mtxtphone.Location = new System.Drawing.Point(146, 154);
            this.mtxtphone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtxtphone.Mask = "(999) 000-0000";
            this.mtxtphone.Name = "mtxtphone";
            this.mtxtphone.Size = new System.Drawing.Size(164, 26);
            this.mtxtphone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sifre : ";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(146, 196);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(164, 26);
            this.txtpassword.TabIndex = 11;
            // 
            // cmbbnk
            // 
            this.cmbbnk.FormattingEnabled = true;
            this.cmbbnk.Location = new System.Drawing.Point(146, 229);
            this.cmbbnk.Name = "cmbbnk";
            this.cmbbnk.Size = new System.Drawing.Size(164, 26);
            this.cmbbnk.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Banka :";
            // 
            // addregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(320, 313);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbbnk);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtphone);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.mtxttc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "addregister";
            this.Text = "YENİ HESAP OLUŞTUR";
            this.Load += new System.EventHandler(this.addregister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxttc;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.MaskedTextBox mtxtphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cmbbnk;
        private System.Windows.Forms.Label label7;
    }
}