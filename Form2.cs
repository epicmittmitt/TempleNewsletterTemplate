using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempleTemplate
{
	public partial class Form2 : Form
	{
		public string link { get { return textBox1.Text; } }

		public Form2()
		{
			InitializeComponent();

			textBox1.TextChanged += TextBox1_TextChanged;
			button1.Click += Button1_Click;
			button2.Click += Button2_Click;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			pictureBox1.ImageLocation = textBox1.Text;
		}
	}
}
