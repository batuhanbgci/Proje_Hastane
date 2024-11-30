namespace Proje_Hastane
{
    partial class FrmUyeKayit
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
            label3 = new Label();
            TxtSoyad = new TextBox();
            MskTC = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            TxtAd = new TextBox();
            label5 = new Label();
            TxtSifre = new TextBox();
            MskTelefon = new MaskedTextBox();
            CmbCinsiyet = new ComboBox();
            label6 = new Label();
            BtnKayitYap = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(186, 94);
            label3.Name = "label3";
            label3.Size = new Size(94, 35);
            label3.TabIndex = 11;
            label3.Text = "Soyad:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(307, 104);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(146, 36);
            TxtSoyad.TabIndex = 10;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(307, 160);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(146, 36);
            MskTC.TabIndex = 9;
            MskTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(104, 147);
            label2.Name = "label2";
            label2.Size = new Size(176, 35);
            label2.TabIndex = 8;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(225, 47);
            label1.Name = "label1";
            label1.Size = new Size(55, 35);
            label1.TabIndex = 13;
            label1.Text = "Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(51, 210);
            label4.Name = "label4";
            label4.Size = new Size(229, 35);
            label4.TabIndex = 15;
            label4.Text = "Telefon Numarası:";
            label4.Click += label4_Click;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(307, 48);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(146, 36);
            TxtAd.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(204, 267);
            label5.Name = "label5";
            label5.Size = new Size(76, 35);
            label5.TabIndex = 17;
            label5.Text = "Şİfre:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(301, 266);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(152, 36);
            TxtSifre.TabIndex = 16;
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(301, 211);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(152, 36);
            MskTelefon.TabIndex = 18;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CmbCinsiyet.Location = new Point(301, 310);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(152, 36);
            CmbCinsiyet.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(164, 311);
            label6.Name = "label6";
            label6.Size = new Size(116, 35);
            label6.TabIndex = 20;
            label6.Text = "Cinsiyet:";
            // 
            // BtnKayitYap
            // 
            BtnKayitYap.BackColor = SystemColors.AppWorkspace;
            BtnKayitYap.Location = new Point(307, 352);
            BtnKayitYap.Name = "BtnKayitYap";
            BtnKayitYap.Size = new Size(138, 53);
            BtnKayitYap.TabIndex = 21;
            BtnKayitYap.Text = "Kayıt Yap";
            BtnKayitYap.UseVisualStyleBackColor = false;
            // 
            // FrmUyeKayit
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(489, 417);
            Controls.Add(BtnKayitYap);
            Controls.Add(label6);
            Controls.Add(CmbCinsiyet);
            Controls.Add(MskTelefon);
            Controls.Add(label5);
            Controls.Add(TxtSifre);
            Controls.Add(label4);
            Controls.Add(TxtAd);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(TxtSoyad);
            Controls.Add(MskTC);
            Controls.Add(label2);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmUyeKayit";
            Text = "FrmHastaKayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox TxtSoyad;
        private MaskedTextBox MskTC;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox TxtAd;
        private Label label5;
        private TextBox TxtSifre;
        private MaskedTextBox MskTelefon;
        private ComboBox CmbCinsiyet;
        private Label label6;
        private Button BtnKayitYap;
    }
}