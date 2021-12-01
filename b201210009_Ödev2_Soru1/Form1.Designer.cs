
namespace b201210009_Ödev2_Soru1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.DegerIndis = new System.Windows.Forms.Button();
            this.TersCevir = new System.Windows.Forms.Button();
            this.ElemanSayisiButon = new System.Windows.Forms.Button();
            this.BirlestirButon = new System.Windows.Forms.Button();
            this.DiziyeAyır = new System.Windows.Forms.Button();
            this.SıralaAz = new System.Windows.Forms.Button();
            this.ArayaGir = new System.Windows.Forms.Button();
            this.CharDonustur = new System.Windows.Forms.Button();
            this.SıralaZa = new System.Windows.Forms.Button();
            this.DegerAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aciklamaYazisi2 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Label();
            this.IslemButonu = new System.Windows.Forms.Button();
            this.boxMetin2 = new System.Windows.Forms.Label();
            this.boxMetin3 = new System.Windows.Forms.Label();
            this.boxMetin1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aciklamaYazisi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.DegerIndis);
            this.panel1.Controls.Add(this.TersCevir);
            this.panel1.Controls.Add(this.ElemanSayisiButon);
            this.panel1.Controls.Add(this.BirlestirButon);
            this.panel1.Controls.Add(this.DiziyeAyır);
            this.panel1.Controls.Add(this.SıralaAz);
            this.panel1.Controls.Add(this.ArayaGir);
            this.panel1.Controls.Add(this.CharDonustur);
            this.panel1.Controls.Add(this.SıralaZa);
            this.panel1.Controls.Add(this.DegerAl);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 485);
            this.panel1.TabIndex = 0;
            // 
            // DegerIndis
            // 
            this.DegerIndis.FlatAppearance.BorderSize = 0;
            this.DegerIndis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DegerIndis.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.DegerIndis.ForeColor = System.Drawing.SystemColors.Control;
            this.DegerIndis.Location = new System.Drawing.Point(0, 291);
            this.DegerIndis.Margin = new System.Windows.Forms.Padding(0);
            this.DegerIndis.Name = "DegerIndis";
            this.DegerIndis.Size = new System.Drawing.Size(233, 48);
            this.DegerIndis.TabIndex = 6;
            this.DegerIndis.Text = "Değer İndis";
            this.DegerIndis.UseVisualStyleBackColor = false;
            this.DegerIndis.Click += new System.EventHandler(this.DegerIndis_Click);
            // 
            // TersCevir
            // 
            this.TersCevir.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.TersCevir.FlatAppearance.BorderSize = 0;
            this.TersCevir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TersCevir.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.TersCevir.ForeColor = System.Drawing.SystemColors.Control;
            this.TersCevir.Location = new System.Drawing.Point(0, 436);
            this.TersCevir.Margin = new System.Windows.Forms.Padding(0);
            this.TersCevir.Name = "TersCevir";
            this.TersCevir.Size = new System.Drawing.Size(233, 48);
            this.TersCevir.TabIndex = 9;
            this.TersCevir.Text = "Ters Çevir";
            this.TersCevir.UseVisualStyleBackColor = false;
            this.TersCevir.Click += new System.EventHandler(this.TersCevir_Click);
            // 
            // ElemanSayisiButon
            // 
            this.ElemanSayisiButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.ElemanSayisiButon.FlatAppearance.BorderSize = 0;
            this.ElemanSayisiButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ElemanSayisiButon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElemanSayisiButon.ForeColor = System.Drawing.SystemColors.Control;
            this.ElemanSayisiButon.Location = new System.Drawing.Point(1, 4);
            this.ElemanSayisiButon.Margin = new System.Windows.Forms.Padding(0);
            this.ElemanSayisiButon.Name = "ElemanSayisiButon";
            this.ElemanSayisiButon.Size = new System.Drawing.Size(232, 48);
            this.ElemanSayisiButon.TabIndex = 0;
            this.ElemanSayisiButon.Text = "Eleman Sayısı";
            this.ElemanSayisiButon.UseVisualStyleBackColor = false;
            this.ElemanSayisiButon.Click += new System.EventHandler(this.ElemanSayisiButon_Click);
            // 
            // BirlestirButon
            // 
            this.BirlestirButon.FlatAppearance.BorderSize = 0;
            this.BirlestirButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirlestirButon.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.BirlestirButon.ForeColor = System.Drawing.SystemColors.Control;
            this.BirlestirButon.Location = new System.Drawing.Point(0, 48);
            this.BirlestirButon.Margin = new System.Windows.Forms.Padding(0);
            this.BirlestirButon.Name = "BirlestirButon";
            this.BirlestirButon.Size = new System.Drawing.Size(232, 48);
            this.BirlestirButon.TabIndex = 1;
            this.BirlestirButon.Text = "Birleştir";
            this.BirlestirButon.UseVisualStyleBackColor = false;
            this.BirlestirButon.Click += new System.EventHandler(this.birlestirButon_Click);
            // 
            // DiziyeAyır
            // 
            this.DiziyeAyır.FlatAppearance.BorderSize = 0;
            this.DiziyeAyır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiziyeAyır.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.DiziyeAyır.ForeColor = System.Drawing.SystemColors.Control;
            this.DiziyeAyır.Location = new System.Drawing.Point(0, 194);
            this.DiziyeAyır.Margin = new System.Windows.Forms.Padding(0);
            this.DiziyeAyır.Name = "DiziyeAyır";
            this.DiziyeAyır.Size = new System.Drawing.Size(233, 48);
            this.DiziyeAyır.TabIndex = 4;
            this.DiziyeAyır.Text = "Diziye Ayır";
            this.DiziyeAyır.UseVisualStyleBackColor = false;
            this.DiziyeAyır.Click += new System.EventHandler(this.DiziyeAyır_Click);
            // 
            // SıralaAz
            // 
            this.SıralaAz.FlatAppearance.BorderSize = 0;
            this.SıralaAz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SıralaAz.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.SıralaAz.ForeColor = System.Drawing.SystemColors.Control;
            this.SıralaAz.Location = new System.Drawing.Point(0, 339);
            this.SıralaAz.Margin = new System.Windows.Forms.Padding(0);
            this.SıralaAz.Name = "SıralaAz";
            this.SıralaAz.Size = new System.Drawing.Size(233, 48);
            this.SıralaAz.TabIndex = 7;
            this.SıralaAz.Text = "Sırala (A-Z)";
            this.SıralaAz.UseVisualStyleBackColor = false;
            this.SıralaAz.Click += new System.EventHandler(this.SıralaAz_Click);
            // 
            // ArayaGir
            // 
            this.ArayaGir.FlatAppearance.BorderSize = 0;
            this.ArayaGir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArayaGir.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.ArayaGir.ForeColor = System.Drawing.SystemColors.Control;
            this.ArayaGir.Location = new System.Drawing.Point(0, 97);
            this.ArayaGir.Margin = new System.Windows.Forms.Padding(0);
            this.ArayaGir.Name = "ArayaGir";
            this.ArayaGir.Size = new System.Drawing.Size(233, 48);
            this.ArayaGir.TabIndex = 2;
            this.ArayaGir.Text = "Araya Gir";
            this.ArayaGir.UseVisualStyleBackColor = false;
            this.ArayaGir.Click += new System.EventHandler(this.ArayaGir_Click);
            // 
            // CharDonustur
            // 
            this.CharDonustur.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.CharDonustur.FlatAppearance.BorderSize = 0;
            this.CharDonustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharDonustur.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.CharDonustur.ForeColor = System.Drawing.SystemColors.Control;
            this.CharDonustur.Location = new System.Drawing.Point(0, 242);
            this.CharDonustur.Margin = new System.Windows.Forms.Padding(0);
            this.CharDonustur.Name = "CharDonustur";
            this.CharDonustur.Size = new System.Drawing.Size(233, 48);
            this.CharDonustur.TabIndex = 5;
            this.CharDonustur.Text = "Char Diziye Dönüştür";
            this.CharDonustur.UseVisualStyleBackColor = false;
            this.CharDonustur.Click += new System.EventHandler(this.CharDonustur_Click);
            // 
            // SıralaZa
            // 
            this.SıralaZa.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.SıralaZa.FlatAppearance.BorderSize = 0;
            this.SıralaZa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SıralaZa.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.SıralaZa.ForeColor = System.Drawing.SystemColors.Control;
            this.SıralaZa.Location = new System.Drawing.Point(0, 388);
            this.SıralaZa.Margin = new System.Windows.Forms.Padding(0);
            this.SıralaZa.Name = "SıralaZa";
            this.SıralaZa.Size = new System.Drawing.Size(233, 48);
            this.SıralaZa.TabIndex = 8;
            this.SıralaZa.Text = "Sırala (Z-A)";
            this.SıralaZa.UseVisualStyleBackColor = false;
            this.SıralaZa.Click += new System.EventHandler(this.SıralaZa_Click);
            // 
            // DegerAl
            // 
            this.DegerAl.FlatAppearance.BorderSize = 0;
            this.DegerAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DegerAl.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.DegerAl.ForeColor = System.Drawing.SystemColors.Control;
            this.DegerAl.Location = new System.Drawing.Point(0, 145);
            this.DegerAl.Margin = new System.Windows.Forms.Padding(0);
            this.DegerAl.Name = "DegerAl";
            this.DegerAl.Size = new System.Drawing.Size(233, 48);
            this.DegerAl.TabIndex = 3;
            this.DegerAl.Text = "Değer Al";
            this.DegerAl.UseVisualStyleBackColor = false;
            this.DegerAl.Click += new System.EventHandler(this.DegerAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "STRİNG İŞLEMLERİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 41);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(98)))));
            this.groupBox1.Controls.Add(this.aciklamaYazisi2);
            this.groupBox1.Controls.Add(this.sonuc);
            this.groupBox1.Controls.Add(this.IslemButonu);
            this.groupBox1.Controls.Add(this.boxMetin2);
            this.groupBox1.Controls.Add(this.boxMetin3);
            this.groupBox1.Controls.Add(this.boxMetin1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.aciklamaYazisi);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(234, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(840, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // aciklamaYazisi2
            // 
            this.aciklamaYazisi2.AutoEllipsis = true;
            this.aciklamaYazisi2.AutoSize = true;
            this.aciklamaYazisi2.Location = new System.Drawing.Point(35, 402);
            this.aciklamaYazisi2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aciklamaYazisi2.Name = "aciklamaYazisi2";
            this.aciklamaYazisi2.Size = new System.Drawing.Size(64, 14);
            this.aciklamaYazisi2.TabIndex = 7;
            this.aciklamaYazisi2.Text = "aciklama2";
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(35, 209);
            this.sonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(40, 14);
            this.sonuc.TabIndex = 6;
            this.sonuc.Text = "Sonuc";
            // 
            // IslemButonu
            // 
            this.IslemButonu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IslemButonu.Location = new System.Drawing.Point(140, 155);
            this.IslemButonu.Margin = new System.Windows.Forms.Padding(2);
            this.IslemButonu.Name = "IslemButonu";
            this.IslemButonu.Size = new System.Drawing.Size(97, 22);
            this.IslemButonu.TabIndex = 4;
            this.IslemButonu.Text = "button1";
            this.IslemButonu.UseVisualStyleBackColor = true;
            this.IslemButonu.Click += new System.EventHandler(this.IslemButonu_Click);
            // 
            // boxMetin2
            // 
            this.boxMetin2.AutoSize = true;
            this.boxMetin2.Location = new System.Drawing.Point(35, 134);
            this.boxMetin2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boxMetin2.Name = "boxMetin2";
            this.boxMetin2.Size = new System.Drawing.Size(45, 14);
            this.boxMetin2.TabIndex = 4;
            this.boxMetin2.Text = "Metin2";
            // 
            // boxMetin3
            // 
            this.boxMetin3.AutoSize = true;
            this.boxMetin3.Location = new System.Drawing.Point(31, 246);
            this.boxMetin3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boxMetin3.Name = "boxMetin3";
            this.boxMetin3.Size = new System.Drawing.Size(45, 14);
            this.boxMetin3.TabIndex = 3;
            this.boxMetin3.Text = "Metin3";
            // 
            // boxMetin1
            // 
            this.boxMetin1.AutoSize = true;
            this.boxMetin1.Location = new System.Drawing.Point(35, 81);
            this.boxMetin1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boxMetin1.Name = "boxMetin1";
            this.boxMetin1.Size = new System.Drawing.Size(45, 14);
            this.boxMetin1.TabIndex = 3;
            this.boxMetin1.Text = "Metin1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 155);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 266);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 1;
            // 
            // aciklamaYazisi
            // 
            this.aciklamaYazisi.AutoSize = true;
            this.aciklamaYazisi.Location = new System.Drawing.Point(35, 38);
            this.aciklamaYazisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aciklamaYazisi.Name = "aciklamaYazisi";
            this.aciklamaYazisi.Size = new System.Drawing.Size(64, 14);
            this.aciklamaYazisi.TabIndex = 1;
            this.aciklamaYazisi.Text = "aciklama1";
            // 
            // Form1
            // 
            this.AcceptButton = this.IslemButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1077, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SıralaZa;
        private System.Windows.Forms.Button SıralaAz;
        private System.Windows.Forms.Button DegerAl;
        private System.Windows.Forms.Button CharDonustur;
        private System.Windows.Forms.Button ArayaGir;
        private System.Windows.Forms.Button DiziyeAyır;
        private System.Windows.Forms.Button BirlestirButon;
        private System.Windows.Forms.Button ElemanSayisiButon;
        private System.Windows.Forms.Button TersCevir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label aciklamaYazisi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label boxMetin2;
        private System.Windows.Forms.Label boxMetin3;
        private System.Windows.Forms.Label boxMetin1;
        private System.Windows.Forms.Button IslemButonu;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Button DegerIndis;
        private System.Windows.Forms.Label aciklamaYazisi2;
    }
}

