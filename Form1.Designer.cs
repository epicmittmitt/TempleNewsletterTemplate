namespace TempleTemplate
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.previewLink = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.closingBox = new System.Windows.Forms.RichTextBox();
			this.eventEditor = new System.Windows.Forms.GroupBox();
			this.eventSave = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.eventText = new System.Windows.Forms.RichTextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.eventImage = new System.Windows.Forms.Label();
			this.eventImageLocal = new System.Windows.Forms.Button();
			this.eventImageWeb = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.eventTitle = new System.Windows.Forms.TextBox();
			this.eventList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.eventDelete = new System.Windows.Forms.Button();
			this.eventEdit = new System.Windows.Forms.Button();
			this.eventAdd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.styleBold = new System.Windows.Forms.CheckBox();
			this.styleStrike = new System.Windows.Forms.CheckBox();
			this.colorBG = new System.Windows.Forms.CheckBox();
			this.justifyLeft = new System.Windows.Forms.CheckBox();
			this.colorFG = new System.Windows.Forms.CheckBox();
			this.listNumbered = new System.Windows.Forms.CheckBox();
			this.styleUnderline = new System.Windows.Forms.CheckBox();
			this.listBullet = new System.Windows.Forms.CheckBox();
			this.styleItalic = new System.Windows.Forms.CheckBox();
			this.justifyRight = new System.Windows.Forms.CheckBox();
			this.justifyCenter = new System.Windows.Forms.CheckBox();
			this.openingBox = new System.Windows.Forms.RichTextBox();
			this.dateBox = new System.Windows.Forms.DateTimePicker();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.eventEditor.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(784, 411);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.previewLink);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.closingBox);
			this.tabPage1.Controls.Add(this.eventEditor);
			this.tabPage1.Controls.Add(this.eventList);
			this.tabPage1.Controls.Add(this.eventDelete);
			this.tabPage1.Controls.Add(this.eventEdit);
			this.tabPage1.Controls.Add(this.eventAdd);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.openingBox);
			this.tabPage1.Controls.Add(this.dateBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(776, 385);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Edit";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// previewLink
			// 
			this.previewLink.AutoSize = true;
			this.previewLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(50)))), ((int)(((byte)(4)))));
			this.previewLink.Location = new System.Drawing.Point(685, 9);
			this.previewLink.Name = "previewLink";
			this.previewLink.Size = new System.Drawing.Size(83, 13);
			this.previewLink.TabIndex = 13;
			this.previewLink.TabStop = true;
			this.previewLink.Text = "View In Browser";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(560, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Not Previewing Correctly?";
			// 
			// closingBox
			// 
			this.closingBox.Location = new System.Drawing.Point(95, 204);
			this.closingBox.Name = "closingBox";
			this.closingBox.Size = new System.Drawing.Size(141, 87);
			this.closingBox.TabIndex = 11;
			this.closingBox.Text = "";
			// 
			// eventEditor
			// 
			this.eventEditor.Controls.Add(this.eventSave);
			this.eventEditor.Controls.Add(this.label5);
			this.eventEditor.Controls.Add(this.eventText);
			this.eventEditor.Controls.Add(this.groupBox4);
			this.eventEditor.Controls.Add(this.groupBox3);
			this.eventEditor.Enabled = false;
			this.eventEditor.Location = new System.Drawing.Point(242, 88);
			this.eventEditor.Name = "eventEditor";
			this.eventEditor.Size = new System.Drawing.Size(526, 289);
			this.eventEditor.TabIndex = 10;
			this.eventEditor.TabStop = false;
			this.eventEditor.Text = "Selected Event";
			// 
			// eventSave
			// 
			this.eventSave.Location = new System.Drawing.Point(6, 258);
			this.eventSave.Name = "eventSave";
			this.eventSave.Size = new System.Drawing.Size(150, 25);
			this.eventSave.TabIndex = 7;
			this.eventSave.Text = "Save";
			this.eventSave.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(65, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 26);
			this.label5.TabIndex = 6;
			this.label5.Text = "Event Description\r\n(HTML-ready)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// eventText
			// 
			this.eventText.Location = new System.Drawing.Point(162, 19);
			this.eventText.Name = "eventText";
			this.eventText.Size = new System.Drawing.Size(358, 264);
			this.eventText.TabIndex = 5;
			this.eventText.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.eventImage);
			this.groupBox4.Controls.Add(this.eventImageLocal);
			this.groupBox4.Controls.Add(this.eventImageWeb);
			this.groupBox4.Location = new System.Drawing.Point(6, 66);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(150, 70);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Image";
			// 
			// eventImage
			// 
			this.eventImage.AutoEllipsis = true;
			this.eventImage.Location = new System.Drawing.Point(6, 16);
			this.eventImage.Name = "eventImage";
			this.eventImage.Size = new System.Drawing.Size(138, 20);
			this.eventImage.TabIndex = 0;
			this.eventImage.Text = "-";
			// 
			// eventImageLocal
			// 
			this.eventImageLocal.Location = new System.Drawing.Point(9, 39);
			this.eventImageLocal.Name = "eventImageLocal";
			this.eventImageLocal.Size = new System.Drawing.Size(62, 23);
			this.eventImageLocal.TabIndex = 2;
			this.eventImageLocal.Text = "Local ...";
			this.eventImageLocal.UseVisualStyleBackColor = true;
			// 
			// eventImageWeb
			// 
			this.eventImageWeb.Location = new System.Drawing.Point(82, 39);
			this.eventImageWeb.Name = "eventImageWeb";
			this.eventImageWeb.Size = new System.Drawing.Size(62, 23);
			this.eventImageWeb.TabIndex = 2;
			this.eventImageWeb.Text = "Web ...";
			this.eventImageWeb.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.eventTitle);
			this.groupBox3.Location = new System.Drawing.Point(6, 19);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(150, 41);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Title";
			// 
			// eventTitle
			// 
			this.eventTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eventTitle.Location = new System.Drawing.Point(3, 16);
			this.eventTitle.Name = "eventTitle";
			this.eventTitle.Size = new System.Drawing.Size(144, 20);
			this.eventTitle.TabIndex = 1;
			// 
			// eventList
			// 
			this.eventList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.eventList.FullRowSelect = true;
			this.eventList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.eventList.Location = new System.Drawing.Point(95, 88);
			this.eventList.MultiSelect = false;
			this.eventList.Name = "eventList";
			this.eventList.Size = new System.Drawing.Size(141, 81);
			this.eventList.TabIndex = 9;
			this.eventList.UseCompatibleStateImageBehavior = false;
			this.eventList.View = System.Windows.Forms.View.List;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Title";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Description";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Picture";
			// 
			// eventDelete
			// 
			this.eventDelete.Enabled = false;
			this.eventDelete.Location = new System.Drawing.Point(191, 175);
			this.eventDelete.Name = "eventDelete";
			this.eventDelete.Size = new System.Drawing.Size(45, 23);
			this.eventDelete.TabIndex = 8;
			this.eventDelete.Text = "Del";
			this.eventDelete.UseVisualStyleBackColor = true;
			// 
			// eventEdit
			// 
			this.eventEdit.Enabled = false;
			this.eventEdit.Location = new System.Drawing.Point(143, 175);
			this.eventEdit.Name = "eventEdit";
			this.eventEdit.Size = new System.Drawing.Size(45, 23);
			this.eventEdit.TabIndex = 8;
			this.eventEdit.Text = "Edit";
			this.eventEdit.UseVisualStyleBackColor = true;
			// 
			// eventAdd
			// 
			this.eventAdd.Location = new System.Drawing.Point(95, 175);
			this.eventAdd.Name = "eventAdd";
			this.eventAdd.Size = new System.Drawing.Size(45, 23);
			this.eventAdd.TabIndex = 8;
			this.eventAdd.Text = "Add";
			this.eventAdd.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Events";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 26);
			this.label4.TabIndex = 5;
			this.label4.Text = "Closing Words\r\n(HTML-ready)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 26);
			this.label2.TabIndex = 5;
			this.label2.Text = "Opening Words\r\n(HTML-ready)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Date";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.styleBold);
			this.groupBox1.Controls.Add(this.styleStrike);
			this.groupBox1.Controls.Add(this.colorBG);
			this.groupBox1.Controls.Add(this.justifyLeft);
			this.groupBox1.Controls.Add(this.colorFG);
			this.groupBox1.Controls.Add(this.listNumbered);
			this.groupBox1.Controls.Add(this.styleUnderline);
			this.groupBox1.Controls.Add(this.listBullet);
			this.groupBox1.Controls.Add(this.styleItalic);
			this.groupBox1.Controls.Add(this.justifyRight);
			this.groupBox1.Controls.Add(this.justifyCenter);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(78, 297);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(158, 80);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Formatting";
			this.groupBox1.Visible = false;
			// 
			// styleBold
			// 
			this.styleBold.Appearance = System.Windows.Forms.Appearance.Button;
			this.styleBold.Image = global::TempleTemplate.Properties.Resources.font_bold;
			this.styleBold.Location = new System.Drawing.Point(6, 49);
			this.styleBold.Name = "styleBold";
			this.styleBold.Size = new System.Drawing.Size(24, 24);
			this.styleBold.TabIndex = 2;
			this.styleBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.styleBold.UseVisualStyleBackColor = true;
			// 
			// styleStrike
			// 
			this.styleStrike.Appearance = System.Windows.Forms.Appearance.Button;
			this.styleStrike.Image = global::TempleTemplate.Properties.Resources.font_strike;
			this.styleStrike.Location = new System.Drawing.Point(75, 49);
			this.styleStrike.Name = "styleStrike";
			this.styleStrike.Size = new System.Drawing.Size(24, 24);
			this.styleStrike.TabIndex = 2;
			this.styleStrike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.styleStrike.UseVisualStyleBackColor = true;
			// 
			// colorBG
			// 
			this.colorBG.Appearance = System.Windows.Forms.Appearance.Button;
			this.colorBG.Image = global::TempleTemplate.Properties.Resources.font_bgcolor;
			this.colorBG.Location = new System.Drawing.Point(128, 49);
			this.colorBG.Name = "colorBG";
			this.colorBG.Size = new System.Drawing.Size(24, 24);
			this.colorBG.TabIndex = 2;
			this.colorBG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.colorBG.UseVisualStyleBackColor = true;
			// 
			// justifyLeft
			// 
			this.justifyLeft.Appearance = System.Windows.Forms.Appearance.Button;
			this.justifyLeft.Image = global::TempleTemplate.Properties.Resources.LeftJustify;
			this.justifyLeft.Location = new System.Drawing.Point(6, 19);
			this.justifyLeft.Name = "justifyLeft";
			this.justifyLeft.Size = new System.Drawing.Size(24, 24);
			this.justifyLeft.TabIndex = 2;
			this.justifyLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.justifyLeft.UseVisualStyleBackColor = true;
			// 
			// colorFG
			// 
			this.colorFG.Appearance = System.Windows.Forms.Appearance.Button;
			this.colorFG.Image = global::TempleTemplate.Properties.Resources.font_fgcolor;
			this.colorFG.Location = new System.Drawing.Point(105, 49);
			this.colorFG.Name = "colorFG";
			this.colorFG.Size = new System.Drawing.Size(24, 24);
			this.colorFG.TabIndex = 2;
			this.colorFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.colorFG.UseVisualStyleBackColor = true;
			// 
			// listNumbered
			// 
			this.listNumbered.Appearance = System.Windows.Forms.Appearance.Button;
			this.listNumbered.Image = global::TempleTemplate.Properties.Resources.paragraph_numbered;
			this.listNumbered.Location = new System.Drawing.Point(128, 19);
			this.listNumbered.Name = "listNumbered";
			this.listNumbered.Size = new System.Drawing.Size(24, 24);
			this.listNumbered.TabIndex = 2;
			this.listNumbered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.listNumbered.UseVisualStyleBackColor = true;
			// 
			// styleUnderline
			// 
			this.styleUnderline.Appearance = System.Windows.Forms.Appearance.Button;
			this.styleUnderline.Image = global::TempleTemplate.Properties.Resources.font_underline;
			this.styleUnderline.Location = new System.Drawing.Point(52, 49);
			this.styleUnderline.Name = "styleUnderline";
			this.styleUnderline.Size = new System.Drawing.Size(24, 24);
			this.styleUnderline.TabIndex = 2;
			this.styleUnderline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.styleUnderline.UseVisualStyleBackColor = true;
			// 
			// listBullet
			// 
			this.listBullet.Appearance = System.Windows.Forms.Appearance.Button;
			this.listBullet.Image = global::TempleTemplate.Properties.Resources.paragraph_bullet;
			this.listBullet.Location = new System.Drawing.Point(105, 19);
			this.listBullet.Name = "listBullet";
			this.listBullet.Size = new System.Drawing.Size(24, 24);
			this.listBullet.TabIndex = 2;
			this.listBullet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.listBullet.UseVisualStyleBackColor = true;
			// 
			// styleItalic
			// 
			this.styleItalic.Appearance = System.Windows.Forms.Appearance.Button;
			this.styleItalic.Image = global::TempleTemplate.Properties.Resources.font_italic;
			this.styleItalic.Location = new System.Drawing.Point(29, 49);
			this.styleItalic.Name = "styleItalic";
			this.styleItalic.Size = new System.Drawing.Size(24, 24);
			this.styleItalic.TabIndex = 2;
			this.styleItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.styleItalic.UseVisualStyleBackColor = true;
			// 
			// justifyRight
			// 
			this.justifyRight.Appearance = System.Windows.Forms.Appearance.Button;
			this.justifyRight.Image = global::TempleTemplate.Properties.Resources.RightJustify;
			this.justifyRight.Location = new System.Drawing.Point(52, 19);
			this.justifyRight.Name = "justifyRight";
			this.justifyRight.Size = new System.Drawing.Size(24, 24);
			this.justifyRight.TabIndex = 2;
			this.justifyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.justifyRight.UseVisualStyleBackColor = true;
			// 
			// justifyCenter
			// 
			this.justifyCenter.Appearance = System.Windows.Forms.Appearance.Button;
			this.justifyCenter.Image = global::TempleTemplate.Properties.Resources.CenterJustify;
			this.justifyCenter.Location = new System.Drawing.Point(29, 19);
			this.justifyCenter.Name = "justifyCenter";
			this.justifyCenter.Size = new System.Drawing.Size(24, 24);
			this.justifyCenter.TabIndex = 2;
			this.justifyCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.justifyCenter.UseVisualStyleBackColor = true;
			// 
			// openingBox
			// 
			this.openingBox.Location = new System.Drawing.Point(95, 32);
			this.openingBox.Name = "openingBox";
			this.openingBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.openingBox.Size = new System.Drawing.Size(673, 50);
			this.openingBox.TabIndex = 1;
			this.openingBox.Text = "";
			// 
			// dateBox
			// 
			this.dateBox.Location = new System.Drawing.Point(95, 6);
			this.dateBox.Name = "dateBox";
			this.dateBox.Size = new System.Drawing.Size(200, 20);
			this.dateBox.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.webControl1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(776, 385);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Preview";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// webControl1
			// 
			this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webControl1.Location = new System.Drawing.Point(3, 3);
			this.webControl1.NavigationInfo = Awesomium.Core.NavigationInfo.None;
			this.webControl1.Size = new System.Drawing.Size(770, 379);
			this.webControl1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Temple Newsletter Generator";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.eventEditor.ResumeLayout(false);
			this.eventEditor.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DateTimePicker dateBox;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.RichTextBox openingBox;
		private System.Windows.Forms.CheckBox justifyRight;
		private System.Windows.Forms.CheckBox justifyCenter;
		private System.Windows.Forms.CheckBox justifyLeft;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox listNumbered;
		private System.Windows.Forms.CheckBox listBullet;
		private System.Windows.Forms.CheckBox styleBold;
		private System.Windows.Forms.CheckBox styleStrike;
		private System.Windows.Forms.CheckBox colorBG;
		private System.Windows.Forms.CheckBox colorFG;
		private System.Windows.Forms.CheckBox styleUnderline;
		private System.Windows.Forms.CheckBox styleItalic;
		private System.Windows.Forms.GroupBox eventEditor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox eventText;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label eventImage;
		private System.Windows.Forms.Button eventImageLocal;
		private System.Windows.Forms.Button eventImageWeb;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox eventTitle;
		private System.Windows.Forms.ListView eventList;
		private System.Windows.Forms.Button eventDelete;
		private System.Windows.Forms.Button eventEdit;
		private System.Windows.Forms.Button eventAdd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button eventSave;
		private System.Windows.Forms.RichTextBox closingBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private Awesomium.Windows.Forms.WebControl webControl1;
		private System.Windows.Forms.LinkLabel previewLink;
		private System.Windows.Forms.Label label6;
	}
}

