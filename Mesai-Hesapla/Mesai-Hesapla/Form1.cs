using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Mesai_Hesapla
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

	




		private void button1_Click(object sender, EventArgs e)
		{

			string fileName = @"C:\Users\hasan\source\repos\Mesai-Hesapla\Mesai-Hesapla\bin\Debug\haftalık.txt";

			string writeText = "AD:" + "  " + textBox1.Text;
			

			FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
			fs.Close();
			File.AppendAllText(fileName, Environment.NewLine + writeText);

			MessageBox.Show("İşlem Başarılı");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string fileName = @"C:\Users\hasan\source\repos\Mesai-Hesapla\Mesai-Hesapla\bin\Debug\haftalık.txt";

			string writeText = "SOYAD:" + "  " + textBox2.Text;


			FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
			fs.Close();
			File.AppendAllText(fileName, Environment.NewLine + writeText);

			MessageBox.Show("İşlem Başarılı");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string fileName = @"C:\Users\hasan\source\repos\Mesai-Hesapla\Mesai-Hesapla\bin\Debug\haftalık.txt";

			
			string writeText3 = "Tarih:" + "  " + textBox3.Text;
			

			FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
			fs.Close();
			File.AppendAllText(fileName, Environment.NewLine + writeText3);

			MessageBox.Show("İşlem Başarılı");

		}

		private void button4_Click(object sender, EventArgs e)
		{
			string fileName = @"C:\Users\hasan\source\repos\Mesai-Hesapla\Mesai-Hesapla\bin\Debug\haftalık.txt";

			string writeText4 = "Saat:"+ "  " +textBox4.Text;

			FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
			fs.Close();
			File.AppendAllText(fileName, Environment.NewLine + writeText4);

			MessageBox.Show("İşlem Başarılı");
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			e.Handled = Char.IsWhiteSpace(e.KeyChar);
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			e.Handled = Char.IsWhiteSpace(e.KeyChar);
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = Char.IsWhiteSpace(e.KeyChar);
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = Char.IsWhiteSpace(e.KeyChar);
		}
	}
	}


