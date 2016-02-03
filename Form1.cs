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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			eventAdd.Click += EventAdd_Click;

			dateBox.Value = DateTime.Now;
		}

		private void EventAdd_Click(object sender, EventArgs e)
		{
			eventEditor.Enabled = true;
		}
	}
}
