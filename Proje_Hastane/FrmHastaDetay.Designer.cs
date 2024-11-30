namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 35);
            label1.TabIndex = 14;
            label1.Text = "TC NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(126, 34);
            label2.Name = "label2";
            label2.Size = new Size(169, 35);
            label2.TabIndex = 14;
            label2.Text = "00000000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(5, 69);
            label3.Name = "label3";
            label3.Size = new Size(132, 35);
            label3.TabIndex = 14;
            label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(143, 69);
            label4.Name = "label4";
            label4.Size = new Size(119, 35);
            label4.TabIndex = 14;
            label4.Text = "Null Null";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(24, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 326);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(111, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 40);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 3;
            label5.Text = "Branş:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(111, 126);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(37, 252);
            button1.Name = "button1";
            button1.Size = new Size(184, 51);
            button1.TabIndex = 5;
            button1.Text = "Randevu Al";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 78);
            label6.Name = "label6";
            label6.Size = new Size(84, 28);
            label6.TabIndex = 5;
            label6.Text = "Doktor:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(111, 78);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 36);
            comboBox2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 129);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 6;
            label7.Text = "Şikayet:";
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(727, 552);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmHastaDetay";
            Text = "FrmHastaDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label5;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
    }
}