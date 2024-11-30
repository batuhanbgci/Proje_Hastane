namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            label1 = new Label();
            label2 = new Label();
            MskTC = new MaskedTextBox();
            TxtSifre = new TextBox();
            LnkUyeOl = new LinkLabel();
            BtnGirisYap = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 55);
            label1.Name = "label1";
            label1.Size = new Size(314, 38);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(119, 137);
            label2.Name = "label2";
            label2.Size = new Size(176, 35);
            label2.TabIndex = 1;
            label2.Text = "TC Kimlik No:";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(316, 136);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(146, 36);
            MskTC.TabIndex = 3;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(316, 180);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(146, 36);
            TxtSifre.TabIndex = 4;
            // 
            // LnkUyeOl
            // 
            LnkUyeOl.AutoSize = true;
            LnkUyeOl.Location = new Point(485, 180);
            LnkUyeOl.Name = "LnkUyeOl";
            LnkUyeOl.Size = new Size(75, 28);
            LnkUyeOl.TabIndex = 5;
            LnkUyeOl.TabStop = true;
            LnkUyeOl.Text = "Üye Ol";
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(339, 231);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(114, 49);
            BtnGirisYap.TabIndex = 6;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(219, 181);
            label3.Name = "label3";
            label3.Size = new Size(76, 35);
            label3.TabIndex = 7;
            label3.Text = "Şİfre:";
            // 
            // FrmHastaGiris
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(666, 320);
            Controls.Add(label3);
            Controls.Add(BtnGirisYap);
            Controls.Add(LnkUyeOl);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmHastaGiris";
            Text = "FrmHastaGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox MskTC;
        private TextBox TxtSifre;
        private LinkLabel LnkUyeOl;
        private Button BtnGirisYap;
        private Label label3;
    }
}