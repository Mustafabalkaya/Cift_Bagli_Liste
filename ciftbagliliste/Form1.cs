using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciftbagliliste
{
	public partial class Form1 : Form
	{
		public class Ciftdugum
		{
			public string isim;
			public string soyisim;
			public int no;
			public Ciftdugum sonraki;
			public Ciftdugum onceki;
		}
		Ciftdugum ilk = null;
		Ciftdugum son = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)//sona ekleme
		{
			Ciftdugum yeni = new Ciftdugum();
			yeni.isim = textBox1.Text;
			yeni.no = Convert.ToInt32(textBox2.Text);
			yeni.soyisim = textBox3.Text;
			if (ilk == null)

			{
				ilk = yeni;
				son = ilk;
				ilk.onceki = null;
				son.sonraki = null;

			}
			else
			{
				son.sonraki = yeni;
				yeni.onceki = son;
				son = yeni;
				son.sonraki = null;

			}

		}
		private void listeyiYazdir(Ciftdugum ilk)
		{
			richTextBox1.Text = null;
			while (ilk != null)

			{
				richTextBox1.Text += ilk.isim + " : " + ilk.soyisim + " : " + ilk.no.ToString();
				richTextBox1.Text += "<==>";
				ilk = ilk.sonraki;

			}
			richTextBox1.Text += "null";
		}

		private void button2_Click(object sender, EventArgs e)//LİSTEYİ YAZDIR
		{
			listeyiYazdir(ilk);
		}

		private void button3_Click(object sender, EventArgs e)//silme işlemi
		{
			int no = Convert.ToInt32(textBox2.Text);
			Ciftdugum silinecek = new Ciftdugum();
			Ciftdugum onceki = new Ciftdugum();
			silinecek = ilk;
			if (ilk.no == no)
			{
				ilk = ilk.sonraki;
				ilk.onceki = null;

			}
			else if (son.no==no)
			{
				son = son.onceki;
				son.sonraki = null;
			}
			else
			{
				while (silinecek.no != no)
				{
					onceki = silinecek;
					silinecek = silinecek.sonraki;
				}
				silinecek.onceki.sonraki = silinecek.sonraki;
				silinecek.sonraki.onceki = silinecek.onceki;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Ciftdugum yeni = new Ciftdugum();
			yeni.isim = textBox1.Text;
			yeni.no = Convert.ToInt32(textBox2.Text);
			yeni.soyisim = textBox3.Text;
			Ciftdugum gecici = new Ciftdugum();
			gecici = ilk;
			if (ilk != null)

			{
				while (gecici.no < yeni.no)
				{

					if (gecici.sonraki.no > yeni.no)
					{
						break;
					}
					gecici = gecici.sonraki;
				}
				
				gecici.sonraki.onceki = yeni;
				yeni.sonraki = gecici.sonraki;
				gecici.sonraki = yeni;
				yeni.onceki = gecici;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Ciftdugum basaekle = new Ciftdugum();
			basaekle.isim = Convert.ToString(textBox1.Text);
			basaekle.soyisim = Convert.ToString(textBox3.Text);
			basaekle.no = Convert.ToInt16(textBox2.Text);
			ilk.onceki = basaekle;
			basaekle.sonraki = ilk;
			ilk = basaekle;
			ilk.onceki = null;


		}
	}
}
