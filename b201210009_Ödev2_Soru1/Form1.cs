/*****************************************************************************************************************
 **                                                 SAKARYA ÜNİVERSİTESİ
 **                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
 **                                            BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 **                                           NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                                                 2020-2021 BAHAR DÖNEMİ
 **
 **
 **
 **
 **
 **                 ÖDEV NUMARASI..........: 2 (Soru 1)
 **                 ÖĞRENCİ ADI............: MEHMET AKİF KAYA
 **                 ÖĞRENCİ NUMARASI.......: b201210009
 **                 DERSİN ALINDIĞI GRUP...: 1C
 **
 **
 ******************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b201210009_Ödev2_Soru1
{ 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  İşlemi yapacak butona basıldığında hangi metodun çalıştırılacağını belirleyen değişken tanımlaması
        int islemNo;

        //  Kullanıcıdan metin almadan da işlem yapabilmek için örnek metin tanımlaması
        string ornekMetin = "C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";

        //  Metot butonuna basıldığında bi önceki butona basıldıysa eğer oradaki nesnelerin konumunu, içindeki metni ve rengini sıfırlayan metot 
        public void FormuSifirla()
        {
            //  group box'ın altında ve üstünde bulunan açıklama metnini temsil ediyor
            aciklamaYazisi.Visible = false;
            aciklamaYazisi2.Visible = false;

            groupBox1.Visible = false;

            //boxMetin lere ait açıklama metnini temsil ediyor.
            boxMetin1.Visible = false;
            boxMetin2.Visible = false;
            boxMetin3.Visible = false;

            //  Kullanıcıdan değer almak için boxMetin ler 
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

            //  Metotları çalıştırıp sonuç gösterecek buton
            IslemButonu.Visible = false;

            sonuc.Visible = false;

            // Örnek metin üzerinde işlem yapabilmek için textBoxları default tanımladım.
            textBox1.Text = "";     textBox2.Text = "";     textBox3.Text = "";
            
            //  Butona basıldığında bütün butonların rengini sıfırlayan kodlar 
            ElemanSayisiButon.BackColor = Color.FromArgb(56, 60, 74);       BirlestirButon.BackColor = Color.FromArgb(56, 60, 74);
            ArayaGir.BackColor = Color.FromArgb(56, 60, 74);                DegerAl.BackColor = Color.FromArgb(56, 60, 74);
            DiziyeAyır.BackColor = Color.FromArgb(56, 60, 74);              CharDonustur.BackColor = Color.FromArgb(56, 60, 74);
            DegerIndis.BackColor = Color.FromArgb(56, 60, 74);              SıralaAz.BackColor = Color.FromArgb(56, 60, 74);
            SıralaZa.BackColor = Color.FromArgb(56, 60, 74);                TersCevir.BackColor = Color.FromArgb(56, 60, 74);

        }

        //  Form çalıştığında çalışan fonksiyon
        private void Form1_Load(object sender, EventArgs e)
        {
            //  Form yüklendiğinde boş bir group box görünmesi için group box içnideki nesneler sıfırlanır.
            FormuSifirla();
        }

        //  Soldaki sekmelerden hangi buton seçilirse ona ait fonksiyon çalışır ve ona ait nesnelerin konumunu, boyutunu ve metinlerini ayarlar.
        private void ElemanSayisiButon_Click(object sender, EventArgs e)
        {
            //  islemNo ataması
            islemNo = 1;

            //  Nesne temizleyici fonksiyon çalışır.
            FormuSifirla();

            //  Butonun seçili görünmesi için renk kodu
            ElemanSayisiButon.BackColor = Color.FromArgb(67, 72, 88);

            //  Group Box gösterilir.
            groupBox1.Visible = true;
            groupBox1.Text = "ELEMAN SAYISI";

            //  İşleme ait bilgiler verilir.
            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Location = new Point(30,35);
            aciklamaYazisi.Text = "Girilen metindeki karakter sayısını bulur.\n\n" +
                "Aşağıdaki kutucuğa bir metin yazın ve HESAPLA tuşuna basın.";

            //  İşleme ait textBox lar, bilgi metinleri , buton ve sonuc metninin gösterilmesi; konum ve boyutunun ayarlanması
            boxMetin1.Visible = true;       boxMetin1.Location = new Point(30, 120);        boxMetin1.Text = "Metin : ";
            textBox1.Visible = true;        textBox1.Location = new Point(30, 142);         textBox1.Size = new Size(195, 20);
            IslemButonu.Visible = true;     IslemButonu.Location = new Point(83, 177);      IslemButonu.Text = "HESAPLA";
            sonuc.Visible = true;           sonuc.Location = new Point(30, 217);            sonuc.Text = "Karakter Sayısı : 0";

            //  Örnek metin kullanımı için bilgiler verilir.
            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakarak örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";
        }

        //  Her buton için yapılan işlemler aynıdır. Gösterilecek textBox sayısı ve metinler değişir.

        private void birlestirButon_Click(object sender, EventArgs e)
        {
            islemNo = 2;
            FormuSifirla();
            BirlestirButon.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "BİRLEŞTİR";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Location = new Point(30, 35);
            aciklamaYazisi.Text = "Verilen 2 string değeri birleştirir.\n\n" +
                "Aşağıdaki 2 kutucuğa metinleri yazın ve BİRLEŞTİR tuşuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30,120);
            boxMetin1.Text = "Metin 1 : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30,140);
            textBox1.Size = new Size(180,20);

            boxMetin2.Visible = true;
            boxMetin2.Location = new Point(30, 176);
            boxMetin2.Text = "Metin 2 : ";

            textBox2.Visible = true;
            textBox2.Location = new Point(30, 196);
            textBox2.Size = new Size(180, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(78,232);
            IslemButonu.Size = new Size(83, 20);
            IslemButonu.Text = "BİRLEŞTİR";

            sonuc.Visible = true;
            sonuc.Location = new Point(30,273);
            sonuc.Text = "Yeni Metin : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin 1 kutucuğunu boş bırakıp metin 2 değerini girerek örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";

        }

        private void ArayaGir_Click(object sender, EventArgs e)
        {
            islemNo = 3;
            FormuSifirla();
            ArayaGir.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "ARAYA GİR";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Location = new Point(30, 35);
            aciklamaYazisi.Text = "Bir metne verilen indisten itibaren verilen string değerini ekler.\n\n" +
                "Metne eklenecek ifadeyi ve indis değerini yazın, EKLE butonuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30, 120);
            boxMetin1.Text = "Metin : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30, 140);
            textBox1.Size = new Size(217, 20);

            boxMetin2.Visible = true;
            boxMetin2.Location = new Point(30, 176);
            boxMetin2.Text = "Eklenecek İfade : ";

            textBox2.Visible = true;
            textBox2.Location = new Point(30, 196);
            textBox2.Size = new Size(166, 20);

            boxMetin3.Visible = true;
            boxMetin3.Location = new Point(209,176);
            boxMetin3.Text = "İndis : ";

            textBox3.Visible = true;
            textBox3.Location = new Point(209, 196);
            textBox3.Size = new Size(38, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(78, 232);
            IslemButonu.Size = new Size(83, 20);
            IslemButonu.Text = "EKLE";

            sonuc.Visible = true;
            sonuc.Location = new Point(30, 273);
            sonuc.Text = "Yeni Metin : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakıp ifadeyi ve indis değerini girerek örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";

        }

        private void DegerAl_Click(object sender, EventArgs e)
        {
            islemNo = 4;
            FormuSifirla();
            DegerAl.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "DEĞER AL";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Text = "Metni belirtilen indisten başlayarak belirtilen sayı kadar gösterir.\n\n" +
                "Metni yazdıktan sonra almak istediğiniz kısmın indis değerlerini yazın ve GÖSTER butonuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30, 120);
            boxMetin1.Text = "Metin : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30, 140);
            textBox1.Size = new Size(217, 20);

            boxMetin2.Visible = true;
            boxMetin2.Location = new Point(30, 176);
            boxMetin2.Text = "İndis 1 : ";

            textBox2.Visible = true;
            textBox2.Location = new Point(30, 196);
            textBox2.Size = new Size(45, 20);

            boxMetin3.Visible = true;
            boxMetin3.Location = new Point(110, 176);
            boxMetin3.Text = "İndis 2 : ";

            textBox3.Visible = true;
            textBox3.Location = new Point(110, 196);
            textBox3.Size = new Size(45, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(180, 196);
            IslemButonu.Size = new Size(83, 20);
            IslemButonu.Text = "GÖSTER";

            sonuc.Visible = true;
            sonuc.Location = new Point(30, 242);
            sonuc.Text = "Metin : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakıp indis değerlerini girerek örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";
        }

        private void DiziyeAyır_Click(object sender, EventArgs e)
        {
            islemNo = 5;
            FormuSifirla();
            DiziyeAyır.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "DİZİYE AYIR";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Text = "Metni belirtilen karaktere göre diziye ayırır.\n\n" +
                "Metni yazdıktan sonra karakteri girin ve AYIR butonuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30, 120);
            boxMetin1.Text = "Metin : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30, 141);
            textBox1.Size = new Size(217, 20);

            boxMetin2.Visible = true;
            boxMetin2.Location = new Point(30, 173);
            boxMetin2.Text = "Karakter : ";

            textBox2.Visible = true;
            textBox2.Location = new Point(30, 193);
            textBox2.Size = new Size(39, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(120, 193);
            IslemButonu.Size = new Size(83, 20);
            IslemButonu.Text = "AYIR";

            sonuc.Visible = true;
            sonuc.Location = new Point(30, 235);
            sonuc.Text = "Dizi : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakıp karakteri girerek örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";


        }

        private void CharDonustur_Click(object sender, EventArgs e)
        {
            islemNo = 6;
            FormuSifirla();
            CharDonustur.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "CHAR DİZİYE DÖNÜŞTÜR";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Text = "Metni char dizisine dönüştürür.\n\n" +
                "Metni yazdıktan sonra DÖNÜŞTÜR butonuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30, 120);
            boxMetin1.Text = "Metin : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30, 141);
            textBox1.Size = new Size(217, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(83, 177);
            IslemButonu.Size = new Size(93,20);
            IslemButonu.Text = "DÖNÜŞTÜR";

            sonuc.Visible = true;
            sonuc.Location = new Point(30, 217);
            sonuc.Text = "Dizi : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakarak örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";

        }

        private void DegerIndis_Click(object sender, EventArgs e)
        {
            islemNo = 7;
            FormuSifirla();
            DegerIndis.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "DEĞER İNDİS";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Text = "Metinde aranan ifadenin indisini döndürür.\n\n" +
                "Metni yazıp bulunmasını istediğiniz ifadeyi girin ve BUL tuşuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30, 120);
            boxMetin1.Text = "Metin : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30, 140);
            textBox1.Size = new Size(180, 20);

            boxMetin2.Visible = true;
            boxMetin2.Location = new Point(30, 176);
            boxMetin2.Text = "Bulunacak İfade : ";

            textBox2.Visible = true;
            textBox2.Location = new Point(30, 196);
            textBox2.Size = new Size(180, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(78, 232);
            IslemButonu.Size = new Size(83, 20);
            IslemButonu.Text = "BUL";

            sonuc.Visible = true;
            sonuc.Location = new Point(30, 273);
            sonuc.Text = "İndis : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakıp ifadeyi girerek örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";
        }

        private void SıralaAz_Click(object sender, EventArgs e)
        {
            islemNo = 8;
            FormuSifirla();
            SıralaAz.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "A-Z SIRALA";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Location = new Point(30, 35);
            aciklamaYazisi.Text = "Metnin karakterlerini 'A' dan 'Z' ye sıralar.\n\n" +
                "Aşağıdaki kutucuğa bir metin yazın ve SIRALA tuşuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30, 120);
            boxMetin1.Text = "Metin : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30, 142);
            textBox1.Size = new Size(195, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(83, 177);
            IslemButonu.Text = "SIRALA";

            sonuc.Visible = true;
            sonuc.Location = new Point(30, 217);
            sonuc.Text = "[ A --> Z ] : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakarak örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";



        }

        private void SıralaZa_Click(object sender, EventArgs e)
        {
            islemNo = 9;
            FormuSifirla();
            SıralaZa.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "Z-A SIRALA";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Location = new Point(30, 35);
            aciklamaYazisi.Text = "Metnin karakterlerini 'Z' dan 'A' ya sıralar.\n\n" +
                "Aşağıdaki kutucuğa bir metin yazın ve SIRALA tuşuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30, 120);
            boxMetin1.Text = "Metin : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30, 142);
            textBox1.Size = new Size(195, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(83, 177);
            IslemButonu.Text = "SIRALA";

            sonuc.Visible = true;
            sonuc.Location = new Point(30, 217);
            sonuc.Text = "[ Z --> A ] : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakarak örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";
        }

        private void TersCevir_Click(object sender, EventArgs e)
        {
            islemNo = 10;
            FormuSifirla();
            TersCevir.BackColor = Color.FromArgb(67, 72, 88);

            groupBox1.Visible = true;
            groupBox1.Text = "TERS ÇEVİR";

            aciklamaYazisi.Visible = true;
            aciklamaYazisi.Location = new Point(30, 35);
            aciklamaYazisi.Text = "Metni ters çevirir.\n\n" +
                "Aşağıdaki kutucuğa bir metin yazın ve TERS ÇEVİR tuşuna basın.";

            boxMetin1.Visible = true;
            boxMetin1.Location = new Point(30, 120);
            boxMetin1.Text = "Metin : ";

            textBox1.Visible = true;
            textBox1.Location = new Point(30, 142);
            textBox1.Size = new Size(195, 20);

            IslemButonu.Visible = true;
            IslemButonu.Location = new Point(83, 177);
            IslemButonu.Text = "TERS ÇEVİR";

            sonuc.Visible = true;
            sonuc.Location = new Point(30, 217);
            sonuc.Text = "Metin : --";

            aciklamaYazisi2.Visible = true;
            aciklamaYazisi2.Location = new Point(30, 375);
            aciklamaYazisi2.Text = "(Metin kutucuğunu boş bırakarak örnek metin üzerinde işlem yapabilirsiniz.)\n\n" +
                "Örnek Metin : C# programlama dilinde String değişkeni metinsel türleri ifade eden bir data tipidir.";
        }


        //  Gerekli bilgiler textBox lara yazıldıktan sonra butona basıldığında çalışacak fonksiyon
        private void IslemButonu_Click(object sender, EventArgs e)
        {
            //  Metotların çalışması için nesne oluşturulması
            BenimString BenimNesne = new BenimString(); 

            //  Atanan islemNo'ya göre if bloklarından 1 tanesi çalışır

            if (islemNo == 1)
            {
                //  Eğer textBox'a metin girilmediyse örnek metnin ilgili fonksiyona gönderilmesi için if else blokları

                if(textBox1.Text == "")
                    //  Metodun parametresine göre textBox'dan alınan metinler metodlara gönderilir.
                    sonuc.Text = "Karakter Sayısı : " + Convert.ToString(BenimNesne.ElemanSayisi(ornekMetin));

                else
                    sonuc.Text = "Karakter Sayısı : " + Convert.ToString(BenimNesne.ElemanSayisi(textBox1.Text));
            }

            //  Aynı işlemler tüm if blokları için devam ediyor.

            if (islemNo == 2)
            {
                if (textBox1.Text == "")
                    sonuc.Text = "Yeni Metin : " + BenimNesne.Birlestir(ornekMetin, textBox2.Text);

                else
                    sonuc.Text = "Yeni Metin : " + BenimNesne.Birlestir(textBox1.Text, textBox2.Text);
            }

            if (islemNo == 3)
            {
                if (textBox1.Text == "")
                    sonuc.Text = "Yeni Metin : " + BenimNesne.ArayaGir(ornekMetin, textBox2.Text, Convert.ToInt32(textBox3.Text));
                else
                    sonuc.Text = "Yeni Metin : " + BenimNesne.ArayaGir(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            }

            if (islemNo == 4)
            {
                if (textBox1.Text == "")
                    sonuc.Text = "Metin : " + BenimNesne.DegerAl(ornekMetin, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                else
                    sonuc.Text = "Metin : " + BenimNesne.DegerAl(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            }

            if (islemNo == 5)
            {
                string[] geciciDizi;
                if (textBox1.Text == "")
                    geciciDizi= BenimNesne.DiziyeAyir(ornekMetin, Convert.ToChar(textBox2.Text));

                else 
                    geciciDizi= BenimNesne.DiziyeAyir(textBox1.Text, Convert.ToChar(textBox2.Text));

                sonuc.Text = "Dizi : ";
                for (int i = 0; i < geciciDizi.Length; i++)
                    sonuc.Text = sonuc.Text +  geciciDizi[i] + "\n        "  ;
            }

            if (islemNo == 6)
            {
                char[] geciciDizi2;

                if (textBox1.Text == "")
                    geciciDizi2 = BenimNesne.CharDonustur(ornekMetin);

                else
                    geciciDizi2 = BenimNesne.CharDonustur(textBox1.Text);

                sonuc.Text = "Dizi : ";
                for (int i = 0; i < geciciDizi2.Length; i++)
                    sonuc.Text = sonuc.Text + geciciDizi2[i] ;
            }

            if (islemNo == 7)
            {
                int[] İndisDizisi = new int[10];

                if (textBox1.Text == "")
                    İndisDizisi= BenimNesne.DegerIndis(ornekMetin, textBox2.Text);

                else
                    İndisDizisi = BenimNesne.DegerIndis(textBox1.Text, textBox2.Text);

                sonuc.Text = "İndis : ";
                for (int i = 0; i < İndisDizisi.Length; i++) 
                {
                    if(!(İndisDizisi[i]==0))
                    sonuc.Text = sonuc.Text + İndisDizisi[i] + " ";

                }
                   

            }

            if (islemNo == 8)
            {
                if (textBox1.Text == "")
                    sonuc.Text = "[ A --> Z ] : " + BenimNesne.SıralaAz(ornekMetin);

                else
                    sonuc.Text = "[ A --> Z ] : " + BenimNesne.SıralaAz(textBox1.Text);
            }

            if (islemNo == 9)
            {
                if (textBox1.Text == "")
                    sonuc.Text = "[ Z --> A ] : " + BenimNesne.SıralaZa(ornekMetin);

                else 
                    sonuc.Text = "[ Z --> A ] : " + BenimNesne.SıralaZa(textBox1.Text);
            }

            if (islemNo == 10)
            {
                if (textBox1.Text == "")
                    sonuc.Text = "Metin : " + BenimNesne.TersCevir(ornekMetin);

                else
                    sonuc.Text = "Metin : " + BenimNesne.TersCevir(textBox1.Text);
            }
        }
    }

    //  İşlemleri yapan metotların bulunduğu sınıf
    public class BenimString
    {
        //Metotlar
        public int ElemanSayisi(string metin)
        {
            //  Metnin sonuna null karakteri ekledim.
            metin += "\0";

            // null karakterini arayan for döngüsü
            for (int i = 0; ; i++)
            {
                if (metin[i] == '\0')
                    return i;
            }
        }

        public string Birlestir(string metin1, string metin2)
        {
            //  Boş metin tanımlaması
            string toplamMetin = "";

            //  İlk metnin karakterlerinin tek tek toplam metine eklenmesi
            for (int i = 0; i < ElemanSayisi(metin1); i++)
                toplamMetin += Convert.ToString(metin1[i]);

            //  İkinci metnin karakterlerinin tek tek toplam metine eklenmesi
            for (int j = 0; j < ElemanSayisi(metin2); j++)
                toplamMetin += Convert.ToString(metin2[j]);

            return toplamMetin;

        }

        public string ArayaGir(string metin, string ekleMetin, int indis)
        {
            //  İstenen indisten önceki metin değer al fonksiyonuyla parca1 e aktarılır.
            string parca1 = DegerAl(metin, 1, indis - 1);

            //  İstenen indisten sonraki metin değer al fonksiyonuyla parca2 e aktarılır.
            string parca2 = DegerAl(metin, indis, metin.Length);

            //  parca1, eklenmek istenen metin ve metnin geri kalanı birleştirilir. 
            return Birlestir(parca1, ekleMetin) + Birlestir("", parca2);
        }

        public string DegerAl(string metin, int indis1, int indis2)
        {
            //  Alınacak ifadenin aktarılması için boş string.
            string yeniMetin = "";

            //for döngüsü indislerin farkı kadar döner ve ilk indisten başlayıp tek tek karakterleri yeni metine ekler.
            for (int i = 0; i < indis2 - indis1 + 1; i++)
                yeniMetin += Convert.ToString(metin[indis1 - 1 + i]);

            return yeniMetin;

        }

        public string[] DiziyeAyir(string metin, char karakter)
        {
            // Metnin hangi indisten başlanıp diziye ayıracağını belirlemek için ilkİndis değişkeni
            int ilkİndis = 0;
            // String dizisinin sıra değişkeni 
            int sayac = 0;
            // ifadelerin aktarılacağı string dizisi
            string[] sDizi = new string[20];

            // Karakteri metinde bulmak için for döngüsü
            for (int i = 0; i < ElemanSayisi(metin); i++)
            {
                // Eğer karakteri bulursa bloğun içine girer
                if (metin[i] == karakter)
                {
                    // Karaktere kadar olan kısım diziye aktarılır.
                    sDizi[sayac] = DegerAl(metin, ilkİndis + 1, i);
                    // Bir sonraki metin için sayac arttırılır.
                    sayac++;
                    // 2 karakter arası metni almak için ilk indis önceki karakterin 1 fazlası yapılır.
                    ilkİndis = i + 1;
                }

                //  Metnin içinde bulunan son karakterden metnin sonuna kadarki ifadeyi almak için for döngüsü metnin sonuna geldiğinde çalışır.
                //  Metnin son kısmı diziye aktarılır.
                if (i == ElemanSayisi(metin) - 1)
                    sDizi[sayac] = DegerAl(metin, ilkİndis + 1, ElemanSayisi(metin));
            }

            return sDizi;

        }

        public char[] CharDonustur(string metin)
        {
            // Metnin eleman sayısı kadar char dizisi oluşturulur.
            char[] charDizi = new char[ElemanSayisi(metin)];

            //  Metnin her karakteri sırasıyla diziye aktarılır.
            for (int i = 0; i < ElemanSayisi(metin); i++)
                charDizi[i] = metin[i];

            return charDizi;
        }

        public int[] DegerIndis(string metin, string bulMetin)
        {
            //  İstenilen metnin ndislerini tutan dizi
            int[] indisDizi = new int[20];

            //  İstenilen metin ile kontrol yapılabilmesi için string değişkeni
            string parca;
            int sayac = 0;

            //  Metni tarayabileceği son karaktere kadar tarayan for döngüsü
            for (int i = 0; i <= ElemanSayisi(metin) - ElemanSayisi(bulMetin); i++)
            {
                //  0. indisten başlayarak her indisten, istenilen metnin uzunluğu kadar ifade stringe aktarılır. 
                parca = DegerAl(metin, i + 1, i + ElemanSayisi(bulMetin));

                //  Eğer ifade aranılan metin ise blok çalışır.
                if (parca == bulMetin)
                {
                    // İndis değeri diziye aktarılır.
                    indisDizi[sayac] = i + 1;
                    sayac++;
                }
            }

            return indisDizi;
        }

        public string SıralaAz(string metin)
        {
            //  Metnin tüm karakterleri küçültülür.
            metin = metin.ToLower();

            //  Alfabeyi tutacak char dizisi
            char[] karakterDizi = new char[26];
            int sayac = 0;

            //  Alfabeyi diziye aktaran for döngüsü
            for (char i = 'a'; i <= 'z'; i++)
            {
                karakterDizi[sayac] = i;
                sayac++;
            }
            
            //  Karakterlerin metinde kaç kere geçtiğini tutan int dizisi
            int[] krktrDegerDizi = new int[26];

            //  Metnin her karakterini tek tek kontrol eden for döngüsü
            for (int i = 0; i < ElemanSayisi(metin); i++)
            {
                //  Alfabenin her karakterini kontrol eden for döngüsü
                for (int j = 0; j < karakterDizi.Length; j++)
                {
                    // Karakterin alfabedeki sırası bulunduğunda onu temsil eden int dizisindeki değeri 1 arttırılır.
                    if (metin[i] == karakterDizi[j])
                        krktrDegerDizi[j]++;
                }
            }

            //  A dan z ye sıralanmış dizinin tanımlaması
            string sonuc = "";

            //  Alfabedeki karakter kadar dönen for döngüsü
            for (int i = 0; i < karakterDizi.Length; i++)
            {
                //  Harfin sayısı kadar dönen for döngüsü
                for (int j = 0; j < krktrDegerDizi[i]; j++)
                {
                    // Harf, sayısı kadar stringe eklenir.
                    sonuc += karakterDizi[i];
                }
            }

            return sonuc;


        }

        public string SıralaZa(string metin)
        {
            //  Metin a'dan z'ye sıralanır.
            metin = SıralaAz(metin);
            //  Ters çevrilir.
            metin = TersCevir(metin);

            return metin;
        }

        public string TersCevir(string metin)
        {
            // Metnin aktarılacağı boş string
            string sonuc = "";

            // Metnin sonundan başına doğru karakteri stringe ekleyen for döngüsü 
            for (int i = ElemanSayisi(metin) - 1; i >= 0; i--)
                sonuc += metin[i];

            return sonuc;
        }

    }
}
