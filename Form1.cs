using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TempleTemplate
{
	public partial class Form1 : Form
	{
		// public string output;
		public Form1()
		{
			InitializeComponent();
			// output = "";

			eventAdd.Click += EventAdd_Click;
			eventDelete.Click += EventDelete_Click;
			eventEdit.Click += EventEdit_Click;
			eventSave.Click += EventSave_Click;
			eventImageLocal.Click += EventImageLocal_Click;
			eventImageWeb.Click += EventImageWeb_Click;
			tabControl1.SelectedIndexChanged += generatePreview;
			previewLink.LinkClicked += PreviewLink_LinkClicked;
			eventEditor.EnabledChanged += EventEditor_EnabledChanged;
			eventList.SelectedIndexChanged += EventList_SelectedIndexChanged;

			dateBox.Value = DateTime.Now;
		}

		private void EventList_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool b = eventList.SelectedItems.Count == 0;
			eventEdit.Enabled = !b;
			eventDelete.Enabled = !b;
		}

		private void EventEditor_EnabledChanged(object sender, EventArgs e)
		{
			if (!eventEditor.Enabled) { return; }
			eventAdd.Enabled = false;
			eventEdit.Enabled = false;
			eventDelete.Enabled = false;
		}

		private void PreviewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string temp = System.IO.Path.Combine(Application.StartupPath, "BToL-NL_temp.html");
			System.IO.File.WriteAllText(temp, generator());

			List<Action> browsers = new List<Action>();
			string[] browserStrings = { "chrome.exe", "firefox.exe", "opera.exe", "iexplore.exe", "explorer.exe" };
			foreach (string s in browserStrings)
			{
				browsers.Add(() => System.Diagnostics.Process.Start(s, temp));
			}
			foreach (Action a in browsers)
			{
				try
				{
					a();
					break;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}

		private void generatePreview(object sender, EventArgs e)
		{
			webControl1.LoadHTML(generator());

			if (tabControl1.SelectedTab == tabPage2)
			{
				MaximizeBox = true;
				FormBorderStyle = FormBorderStyle.Sizable;
			}
			else
			{
				MaximizeBox = false;
				FormBorderStyle = FormBorderStyle.FixedSingle;
				Size = new Size(800, 450);
				WindowState = FormWindowState.Normal;
			}
		}

		public string generator()
		{
			string nl = Properties.Resources.head1
				+ dateBox.Value.ToLongDateString()
				+ Properties.Resources.pretext1
				+ System.Text.RegularExpressions.Regex.Replace(openingBox.Text, @"\r\n?|\n", @"<br />" + Environment.NewLine)
				+ Properties.Resources.pretext2;
			foreach (ListViewItem i in eventList.Items)
			{
				nl += Properties.Resources.event1
					+ i.Text
					+ Properties.Resources.event2;
				if (!string.IsNullOrEmpty(i.SubItems[1].Text))
				{
					nl += i.SubItems[1].Text;
				}
				nl += Properties.Resources.event3
				+ System.Text.RegularExpressions.Regex.Replace(i.SubItems[2].Text, @"\r\n?|\n", @"<br />" + Environment.NewLine)
				+ Properties.Resources.event4;
			}
			nl += Properties.Resources.closing1
				+ System.Text.RegularExpressions.Regex.Replace(closingBox.Text, @"\r\n?|\n", @"<br />" + Environment.NewLine)
				+ Properties.Resources.closing2;

			return nl;
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
			else { l.SubItems.Add(""); }
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
			eventAdd.Enabled = true;
			//eventEdit.Enabled = true;
			//eventDelete.Enabled = true;

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
