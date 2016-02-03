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
		public string output;
		public Form1()
		{
			InitializeComponent();
			output = "";

			eventAdd.Click += EventAdd_Click;
			eventDelete.Click += EventDelete_Click;
			eventEdit.Click += EventEdit_Click;
			eventSave.Click += EventSave_Click;
			eventImageLocal.Click += EventImageLocal_Click;
			eventImageWeb.Click += EventImageWeb_Click;
			tabControl1.SelectedIndexChanged += generatePreview;

			dateBox.Value = DateTime.Now;
		}

		private void generatePreview(object sender, EventArgs e)
		{
			output = Properties.Resources.head1
				+ dateBox.Value.ToLongDateString()
				+ Properties.Resources.pretext1
				+ openingBox.Text
				+ Properties.Resources.pretext2;
			foreach (ListViewItem i in eventList.Items)
			{
				output += Properties.Resources.event1
					+ i.Text
					+ Properties.Resources.event2
					+ i.SubItems[1].Text
					+ Properties.Resources.event3
					+ i.SubItems[2].Text
					+ Properties.Resources.event4;
			}
			output += Properties.Resources.closing1
				+ closingBox.Text
				+ Properties.Resources.closing2;
			webControl1.LoadHTML(output);

			MaximizeBox = tabControl1.SelectedTab == tabPage2;
		}

		private void EventImageWeb_Click(object sender, EventArgs e)
		{
			var f = new Form2();
			if (f.ShowDialog() == DialogResult.OK)
			{
				eventImage.Text = System.IO.Path.GetFileName(f.link);
				eventImage.Tag = f.link;
			}
			f.Dispose();
		}

		private void EventImageLocal_Click(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Multiselect = false;
			d.Title = "Select an Image";
			d.ShowDialog();
			eventImage.Text = System.IO.Path.GetFileName(d.FileName);
			eventImage.Tag = d.FileName;
		}

		private void EventSave_Click(object sender, EventArgs e)
		{
			ListViewItem l = new ListViewItem();
			l.Text = eventTitle.Text;
			if (!(eventImage.Tag == null || eventImage.Tag.ToString() == "")) { l.SubItems.Add(eventImage.Tag.ToString()); }
			l.SubItems.Add(eventText.Text);

			foreach (ListViewItem i in eventList.Items)
			{
				if (i.Text == l.Text) { i.Remove(); }
			}
			eventList.Items.Add(l);

			eventTitle.Text = "";
			eventImage.Text = "";
			eventImage.Tag = "";
			eventText.Text = "";

			eventEditor.Enabled = false;
		}

		private void EventEdit_Click(object sender, EventArgs e)
		{
			ListViewItem l = eventList.SelectedItems[0];
			eventAdd.PerformClick();
			eventTitle.Text = l.Text;
			eventImage.Text = System.IO.Path.GetFileName(l.SubItems[1].Text);
			eventImage.Tag = l.SubItems[1].Text;
			eventText.Text = l.SubItems[2].Text;
		}

		private void EventDelete_Click(object sender, EventArgs e)
		{
			eventList.SelectedItems[0].Remove();
		}

		private void EventAdd_Click(object sender, EventArgs e)
		{
			eventEditor.Enabled = true;
			eventTitle.Focus();
		}
	}
}
