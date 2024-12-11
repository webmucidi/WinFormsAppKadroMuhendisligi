namespace WinFormsAppKadroMuhendisligi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxGenisKadro = new ComboBox();
            listBoxMacKadrosu = new ListBox();
            buttonKadroyaEkle = new Button();
            buttonKadrodanCikar = new Button();
            buttonKadroyuTemizle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(182, 33);
            label1.Name = "label1";
            label1.Size = new Size(462, 54);
            label1.TabIndex = 0;
            label1.Text = "FENERBAHÇE 2024-2025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 154);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Geniş kadro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 154);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 1;
            label3.Text = "Maç kadrosu";
            // 
            // comboBoxGenisKadro
            // 
            comboBoxGenisKadro.FormattingEnabled = true;
            comboBoxGenisKadro.Location = new Point(58, 194);
            comboBoxGenisKadro.Name = "comboBoxGenisKadro";
            comboBoxGenisKadro.Size = new Size(151, 28);
            comboBoxGenisKadro.TabIndex = 2;
            // 
            // listBoxMacKadrosu
            // 
            listBoxMacKadrosu.FormattingEnabled = true;
            listBoxMacKadrosu.Location = new Point(491, 194);
            listBoxMacKadrosu.Name = "listBoxMacKadrosu";
            listBoxMacKadrosu.Size = new Size(275, 184);
            listBoxMacKadrosu.TabIndex = 3;
            // 
            // buttonKadroyaEkle
            // 
            buttonKadroyaEkle.Location = new Point(282, 212);
            buttonKadroyaEkle.Name = "buttonKadroyaEkle";
            buttonKadroyaEkle.Size = new Size(159, 32);
            buttonKadroyaEkle.TabIndex = 4;
            buttonKadroyaEkle.Text = "Maç Kadrosuna Ekle";
            buttonKadroyaEkle.UseVisualStyleBackColor = true;
            buttonKadroyaEkle.Click += buttonKadroyaEkle_Click;
            // 
            // buttonKadrodanCikar
            // 
            buttonKadrodanCikar.Location = new Point(282, 269);
            buttonKadrodanCikar.Name = "buttonKadrodanCikar";
            buttonKadrodanCikar.Size = new Size(159, 32);
            buttonKadrodanCikar.TabIndex = 4;
            buttonKadrodanCikar.Text = "Kadrodan Çıkar";
            buttonKadrodanCikar.UseVisualStyleBackColor = true;
            buttonKadrodanCikar.Click += buttonKadrodanCikar_Click;
            // 
            // buttonKadroyuTemizle
            // 
            buttonKadroyuTemizle.Location = new Point(282, 329);
            buttonKadroyuTemizle.Name = "buttonKadroyuTemizle";
            buttonKadroyuTemizle.Size = new Size(159, 32);
            buttonKadroyuTemizle.TabIndex = 4;
            buttonKadroyuTemizle.Text = "Kadroyu Temizle";
            buttonKadroyuTemizle.UseVisualStyleBackColor = true;
            buttonKadroyuTemizle.Click += buttonKadroyuTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKadroyuTemizle);
            Controls.Add(buttonKadrodanCikar);
            Controls.Add(buttonKadroyaEkle);
            Controls.Add(listBoxMacKadrosu);
            Controls.Add(comboBoxGenisKadro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxGenisKadro;
        private ListBox listBoxMacKadrosu;
        private Button buttonKadroyaEkle;
        private Button buttonKadrodanCikar;
        private Button buttonKadroyuTemizle;
    }
}
