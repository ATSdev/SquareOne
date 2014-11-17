﻿namespace Sq1.Widgets.DataSourceEditor {
	partial class DataSourceEditorControl {
		private System.Windows.Forms.Panel panel_0;
		private System.Windows.Forms.UserControl userControl_0;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Panel pnlIntro;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.ListView lvStaticProviders;
		private System.Windows.Forms.ListView lvBrokerProviders;
		private System.Windows.Forms.ListView lvStreamingProviders;
		private System.Windows.Forms.ImageList imglStaticProviders;
		private System.Windows.Forms.ImageList imglStreamingProviders;
		private System.Windows.Forms.ImageList imglBrokerProviders;
		private System.Windows.Forms.TextBox txtDataSourceName;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lblStatic;
		private System.Windows.Forms.Label lblDataSourceName;
		private System.Windows.Forms.Label lblStreaming;
		private System.Windows.Forms.Label lblExecution;
		private System.Windows.Forms.Panel pnlStreamingEditor;
		private System.Windows.Forms.Panel pnlBrokerEditor;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private Sq1.Widgets.DataSourceEditor.MarketInfoEditor marketInfoEditor;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.GroupBox grpStreaming;
		private System.Windows.Forms.GroupBox grpExecution;
		private System.Windows.Forms.LinkLabel lnkStaticDetails;
		private System.Windows.Forms.Label lblSymbols;
		private System.Windows.Forms.TextBox txtSymbols;
		private System.Windows.Forms.NumericUpDown nmrInterval;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.ComboBox cmbScale;
		private System.Windows.Forms.Label lblScale;
		
		protected override void Dispose(bool disposing) {
			if (disposing && this.components != null) {
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pnlIntro = new System.Windows.Forms.Panel();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.lblStreaming = new System.Windows.Forms.Label();
			this.lvStreamingProviders = new System.Windows.Forms.ListView();
			this.imglStreamingProviders = new System.Windows.Forms.ImageList(this.components);
			this.grpStreaming = new System.Windows.Forms.GroupBox();
			this.pnlStreamingEditor = new System.Windows.Forms.Panel();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.lblExecution = new System.Windows.Forms.Label();
			this.lvBrokerProviders = new System.Windows.Forms.ListView();
			this.imglBrokerProviders = new System.Windows.Forms.ImageList(this.components);
			this.grpExecution = new System.Windows.Forms.GroupBox();
			this.pnlBrokerEditor = new System.Windows.Forms.Panel();
			this.marketInfoEditor = new Sq1.Widgets.DataSourceEditor.MarketInfoEditor();
			this.imglStaticProviders = new System.Windows.Forms.ImageList(this.components);
			this.lvStaticProviders = new System.Windows.Forms.ListView();
			this.txtDataSourceName = new System.Windows.Forms.TextBox();
			this.pnlContent = new System.Windows.Forms.Panel();
			this.lblStatic = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer6 = new System.Windows.Forms.SplitContainer();
			this.lblScale = new System.Windows.Forms.Label();
			this.nmrInterval = new System.Windows.Forms.NumericUpDown();
			this.txtSymbols = new System.Windows.Forms.TextBox();
			this.cmbScale = new System.Windows.Forms.ComboBox();
			this.lblSymbols = new System.Windows.Forms.Label();
			this.lblInterval = new System.Windows.Forms.Label();
			this.lnkStaticDetails = new System.Windows.Forms.LinkLabel();
			this.lblDataSourceName = new System.Windows.Forms.Label();
			this.pnlButtons.SuspendLayout();
			this.pnlIntro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.grpStreaming.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.grpExecution.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
			this.splitContainer6.Panel1.SuspendLayout();
			this.splitContainer6.Panel2.SuspendLayout();
			this.splitContainer6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlButtons
			// 
			this.pnlButtons.AutoSize = true;
			this.pnlButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlButtons.Controls.Add(this.btnCancel);
			this.pnlButtons.Controls.Add(this.btnPrevious);
			this.pnlButtons.Controls.Add(this.btnNext);
			this.pnlButtons.Controls.Add(this.btnSave);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlButtons.Location = new System.Drawing.Point(0, 394);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(669, 31);
			this.pnlButtons.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(311, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(74, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrevious.Enabled = false;
			this.btnPrevious.Location = new System.Drawing.Point(408, 3);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(74, 23);
			this.btnPrevious.TabIndex = 2;
			this.btnPrevious.Text = "<< Previous";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Visible = false;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Enabled = false;
			this.btnNext.Location = new System.Drawing.Point(488, 3);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(74, 23);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next >>";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Visible = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(588, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(74, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pnlIntro
			// 
			this.pnlIntro.Controls.Add(this.splitContainer3);
			this.pnlIntro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlIntro.Location = new System.Drawing.Point(0, 0);
			this.pnlIntro.Name = "pnlIntro";
			this.pnlIntro.Size = new System.Drawing.Size(510, 394);
			this.pnlIntro.TabIndex = 0;
			// 
			// splitContainer3
			// 
			this.splitContainer3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer3.Panel2.Controls.Add(this.marketInfoEditor);
			this.splitContainer3.Size = new System.Drawing.Size(510, 394);
			this.splitContainer3.SplitterDistance = 237;
			this.splitContainer3.TabIndex = 12;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
			this.splitContainer2.Size = new System.Drawing.Size(510, 237);
			this.splitContainer2.SplitterDistance = 245;
			this.splitContainer2.TabIndex = 11;
			// 
			// splitContainer4
			// 
			this.splitContainer4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer4.Panel1.Controls.Add(this.lblStreaming);
			this.splitContainer4.Panel1.Controls.Add(this.lvStreamingProviders);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer4.Panel2.Controls.Add(this.grpStreaming);
			this.splitContainer4.Size = new System.Drawing.Size(245, 237);
			this.splitContainer4.SplitterDistance = 124;
			this.splitContainer4.TabIndex = 7;
			// 
			// lblStreaming
			// 
			this.lblStreaming.AutoSize = true;
			this.lblStreaming.Location = new System.Drawing.Point(5, 0);
			this.lblStreaming.Name = "lblStreaming";
			this.lblStreaming.Size = new System.Drawing.Size(187, 13);
			this.lblStreaming.TabIndex = 5;
			this.lblStreaming.Text = "DataFeed (StreamingProvider-derived)";
			// 
			// lvStreamingProviders
			// 
			this.lvStreamingProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvStreamingProviders.HideSelection = false;
			this.lvStreamingProviders.Location = new System.Drawing.Point(5, 17);
			this.lvStreamingProviders.MultiSelect = false;
			this.lvStreamingProviders.Name = "lvStreamingProviders";
			this.lvStreamingProviders.Size = new System.Drawing.Size(237, 104);
			this.lvStreamingProviders.SmallImageList = this.imglStreamingProviders;
			this.lvStreamingProviders.TabIndex = 5;
			this.lvStreamingProviders.UseCompatibleStateImageBehavior = false;
			this.lvStreamingProviders.View = System.Windows.Forms.View.List;
			this.lvStreamingProviders.SelectedIndexChanged += new System.EventHandler(this.lvStreamingProviders_SelectedIndexChanged);
			// 
			// imglStreamingProviders
			// 
			this.imglStreamingProviders.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imglStreamingProviders.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStreamingProviders.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// grpStreaming
			// 
			this.grpStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpStreaming.Controls.Add(this.pnlStreamingEditor);
			this.grpStreaming.Location = new System.Drawing.Point(5, 3);
			this.grpStreaming.Name = "grpStreaming";
			this.grpStreaming.Size = new System.Drawing.Size(237, 106);
			this.grpStreaming.TabIndex = 8;
			this.grpStreaming.TabStop = false;
			this.grpStreaming.Text = "Streaming Settings";
			// 
			// pnlStreamingEditor
			// 
			this.pnlStreamingEditor.AutoScroll = true;
			this.pnlStreamingEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlStreamingEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlStreamingEditor.Location = new System.Drawing.Point(3, 16);
			this.pnlStreamingEditor.Name = "pnlStreamingEditor";
			this.pnlStreamingEditor.Size = new System.Drawing.Size(231, 87);
			this.pnlStreamingEditor.TabIndex = 7;
			// 
			// splitContainer5
			// 
			this.splitContainer5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.Location = new System.Drawing.Point(0, 0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer5.Panel1.Controls.Add(this.lblExecution);
			this.splitContainer5.Panel1.Controls.Add(this.lvBrokerProviders);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer5.Panel2.Controls.Add(this.grpExecution);
			this.splitContainer5.Size = new System.Drawing.Size(261, 237);
			this.splitContainer5.SplitterDistance = 124;
			this.splitContainer5.TabIndex = 11;
			// 
			// lblExecution
			// 
			this.lblExecution.AutoSize = true;
			this.lblExecution.Location = new System.Drawing.Point(3, 0);
			this.lblExecution.Name = "lblExecution";
			this.lblExecution.Size = new System.Drawing.Size(200, 13);
			this.lblExecution.TabIndex = 8;
			this.lblExecution.Text = "Order Execution (BrokerProvider-derived)";
			// 
			// lvBrokerProviders
			// 
			this.lvBrokerProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvBrokerProviders.HideSelection = false;
			this.lvBrokerProviders.Location = new System.Drawing.Point(3, 19);
			this.lvBrokerProviders.MultiSelect = false;
			this.lvBrokerProviders.Name = "lvBrokerProviders";
			this.lvBrokerProviders.Size = new System.Drawing.Size(252, 102);
			this.lvBrokerProviders.SmallImageList = this.imglBrokerProviders;
			this.lvBrokerProviders.TabIndex = 10;
			this.lvBrokerProviders.UseCompatibleStateImageBehavior = false;
			this.lvBrokerProviders.View = System.Windows.Forms.View.List;
			this.lvBrokerProviders.SelectedIndexChanged += new System.EventHandler(this.lvBrokerProviders_SelectedIndexChanged);
			// 
			// imglBrokerProviders
			// 
			this.imglBrokerProviders.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imglBrokerProviders.ImageSize = new System.Drawing.Size(16, 16);
			this.imglBrokerProviders.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// grpExecution
			// 
			this.grpExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpExecution.Controls.Add(this.pnlBrokerEditor);
			this.grpExecution.Location = new System.Drawing.Point(3, 3);
			this.grpExecution.Name = "grpExecution";
			this.grpExecution.Size = new System.Drawing.Size(255, 106);
			this.grpExecution.TabIndex = 10;
			this.grpExecution.TabStop = false;
			this.grpExecution.Text = "Broker Settings";
			// 
			// pnlBrokerEditor
			// 
			this.pnlBrokerEditor.AutoScroll = true;
			this.pnlBrokerEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlBrokerEditor.BackColor = System.Drawing.SystemColors.Control;
			this.pnlBrokerEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBrokerEditor.Location = new System.Drawing.Point(3, 16);
			this.pnlBrokerEditor.Name = "pnlBrokerEditor";
			this.pnlBrokerEditor.Size = new System.Drawing.Size(249, 87);
			this.pnlBrokerEditor.TabIndex = 9;
			// 
			// marketInfoEditor
			// 
			this.marketInfoEditor.AutoSize = true;
			this.marketInfoEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.marketInfoEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.marketInfoEditor.Location = new System.Drawing.Point(0, 0);
			this.marketInfoEditor.Name = "marketInfoEditor";
			this.marketInfoEditor.Size = new System.Drawing.Size(510, 153);
			this.marketInfoEditor.TabIndex = 0;
			// 
			// imglStaticProviders
			// 
			this.imglStaticProviders.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imglStaticProviders.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStaticProviders.TransparentColor = System.Drawing.Color.Fuchsia;
			// 
			// lvStaticProviders
			// 
			this.lvStaticProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvStaticProviders.HideSelection = false;
			this.lvStaticProviders.Location = new System.Drawing.Point(6, 16);
			this.lvStaticProviders.MultiSelect = false;
			this.lvStaticProviders.Name = "lvStaticProviders";
			this.lvStaticProviders.Size = new System.Drawing.Size(143, 119);
			this.lvStaticProviders.SmallImageList = this.imglStaticProviders;
			this.lvStaticProviders.TabIndex = 0;
			this.lvStaticProviders.UseCompatibleStateImageBehavior = false;
			this.lvStaticProviders.View = System.Windows.Forms.View.List;
			this.lvStaticProviders.SelectedIndexChanged += new System.EventHandler(this.lvStaticProviders_SelectedIndexChanged);
			this.lvStaticProviders.DoubleClick += new System.EventHandler(this.btnNext_Click);
			// 
			// txtDataSourceName
			// 
			this.txtDataSourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDataSourceName.Location = new System.Drawing.Point(6, 25);
			this.txtDataSourceName.Name = "txtDataSourceName";
			this.txtDataSourceName.Size = new System.Drawing.Size(143, 20);
			this.txtDataSourceName.TabIndex = 1;
			// 
			// pnlContent
			// 
			this.pnlContent.AutoScroll = true;
			this.pnlContent.AutoSize = true;
			this.pnlContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(0, 0);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(510, 394);
			this.pnlContent.TabIndex = 3;
			// 
			// lblStatic
			// 
			this.lblStatic.AutoSize = true;
			this.lblStatic.Location = new System.Drawing.Point(6, 0);
			this.lblStatic.Name = "lblStatic";
			this.lblStatic.Size = new System.Drawing.Size(76, 13);
			this.lblStatic.TabIndex = 3;
			this.lblStatic.Text = "Static Provider";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer6);
			this.splitContainer1.Panel1.Controls.Add(this.lnkStaticDetails);
			this.splitContainer1.Panel1.Controls.Add(this.lblDataSourceName);
			this.splitContainer1.Panel1.Controls.Add(this.txtDataSourceName);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel2.Controls.Add(this.pnlIntro);
			this.splitContainer1.Panel2.Controls.Add(this.pnlContent);
			this.splitContainer1.Size = new System.Drawing.Size(669, 394);
			this.splitContainer1.SplitterDistance = 155;
			this.splitContainer1.TabIndex = 4;
			// 
			// splitContainer6
			// 
			this.splitContainer6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer6.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitContainer6.Location = new System.Drawing.Point(0, 51);
			this.splitContainer6.Name = "splitContainer6";
			this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer6.Panel1
			// 
			this.splitContainer6.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer6.Panel1.Controls.Add(this.lblStatic);
			this.splitContainer6.Panel1.Controls.Add(this.lvStaticProviders);
			// 
			// splitContainer6.Panel2
			// 
			this.splitContainer6.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer6.Panel2.Controls.Add(this.lblScale);
			this.splitContainer6.Panel2.Controls.Add(this.nmrInterval);
			this.splitContainer6.Panel2.Controls.Add(this.txtSymbols);
			this.splitContainer6.Panel2.Controls.Add(this.cmbScale);
			this.splitContainer6.Panel2.Controls.Add(this.lblSymbols);
			this.splitContainer6.Panel2.Controls.Add(this.lblInterval);
			this.splitContainer6.Size = new System.Drawing.Size(158, 343);
			this.splitContainer6.SplitterDistance = 138;
			this.splitContainer6.TabIndex = 8;
			// 
			// lblScale
			// 
			this.lblScale.AutoSize = true;
			this.lblScale.Location = new System.Drawing.Point(6, 11);
			this.lblScale.Name = "lblScale";
			this.lblScale.Size = new System.Drawing.Size(51, 13);
			this.lblScale.TabIndex = 1;
			this.lblScale.Text = "Bar scale";
			// 
			// nmrInterval
			// 
			this.nmrInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmrInterval.Location = new System.Drawing.Point(72, 35);
			this.nmrInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.nmrInterval.Name = "nmrInterval";
			this.nmrInterval.Size = new System.Drawing.Size(77, 20);
			this.nmrInterval.TabIndex = 2;
			this.nmrInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nmrInterval.ValueChanged += new System.EventHandler(this.nmrInterval_ValueChanged);
			// 
			// txtSymbols
			// 
			this.txtSymbols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSymbols.Location = new System.Drawing.Point(6, 76);
			this.txtSymbols.Multiline = true;
			this.txtSymbols.Name = "txtSymbols";
			this.txtSymbols.Size = new System.Drawing.Size(143, 119);
			this.txtSymbols.TabIndex = 6;
			this.txtSymbols.Text = "RIZ2,RIH3";
			// 
			// cmbScale
			// 
			this.cmbScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbScale.FormattingEnabled = true;
			this.cmbScale.Items.AddRange(new object[] {
            "Unknown",
            "Tick",
            "Second",
            "Minute",
            "Daily",
            "Weekly",
            "Monthly",
            "Quarterly",
            "Yearly"});
			this.cmbScale.Location = new System.Drawing.Point(72, 8);
			this.cmbScale.Name = "cmbScale";
			this.cmbScale.Size = new System.Drawing.Size(77, 21);
			this.cmbScale.TabIndex = 1;
			this.cmbScale.SelectedIndexChanged += new System.EventHandler(this.cmbScale_SelectedIndexChanged);
			// 
			// lblSymbols
			// 
			this.lblSymbols.AutoSize = true;
			this.lblSymbols.Location = new System.Drawing.Point(6, 60);
			this.lblSymbols.Name = "lblSymbols";
			this.lblSymbols.Size = new System.Drawing.Size(46, 13);
			this.lblSymbols.TabIndex = 7;
			this.lblSymbols.Text = "Symbols";
			// 
			// lblInterval
			// 
			this.lblInterval.AutoSize = true;
			this.lblInterval.Location = new System.Drawing.Point(6, 37);
			this.lblInterval.Name = "lblInterval";
			this.lblInterval.Size = new System.Drawing.Size(60, 13);
			this.lblInterval.TabIndex = 2;
			this.lblInterval.Text = "Bar interval";
			// 
			// lnkStaticDetails
			// 
			this.lnkStaticDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkStaticDetails.AutoSize = true;
			this.lnkStaticDetails.Location = new System.Drawing.Point(200, 47);
			this.lnkStaticDetails.Name = "lnkStaticDetails";
			this.lnkStaticDetails.Size = new System.Drawing.Size(39, 13);
			this.lnkStaticDetails.TabIndex = 5;
			this.lnkStaticDetails.TabStop = true;
			this.lnkStaticDetails.Text = "Details";
			this.lnkStaticDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStaticDetails_LinkClicked);
			// 
			// lblDataSourceName
			// 
			this.lblDataSourceName.AutoSize = true;
			this.lblDataSourceName.Location = new System.Drawing.Point(6, 8);
			this.lblDataSourceName.Name = "lblDataSourceName";
			this.lblDataSourceName.Size = new System.Drawing.Size(98, 13);
			this.lblDataSourceName.TabIndex = 4;
			this.lblDataSourceName.Text = "Data Source Name";
			// 
			// DataSourceEditorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.pnlButtons);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "DataSourceEditorControl";
			this.Size = new System.Drawing.Size(669, 425);
			this.pnlButtons.ResumeLayout(false);
			this.pnlIntro.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel1.PerformLayout();
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			this.grpStreaming.ResumeLayout(false);
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel1.PerformLayout();
			this.splitContainer5.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			this.grpExecution.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer6.Panel1.ResumeLayout(false);
			this.splitContainer6.Panel1.PerformLayout();
			this.splitContainer6.Panel2.ResumeLayout(false);
			this.splitContainer6.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
			this.splitContainer6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmrInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.SplitContainer splitContainer6;
	}
}
