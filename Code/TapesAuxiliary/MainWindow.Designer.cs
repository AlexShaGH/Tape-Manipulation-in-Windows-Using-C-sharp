namespace TapesAuxiliary
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageTools = new System.Windows.Forms.TabPage();
            this.pictureBoxTools = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCountOrNumber = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBoxCountOrNumber = new System.Windows.Forms.TextBox();
            this.comboBoxTapeTools = new System.Windows.Forms.ComboBox();
            this.comboBoxMethodTools = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCommandTools = new System.Windows.Forms.ComboBox();
            this.btnExecuteTools = new System.Windows.Forms.Button();
            this.tabPageImage = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.comboBoxSelectedFolder = new System.Windows.Forms.ComboBox();
            this.lblDrive2 = new System.Windows.Forms.Label();
            this.lblDrive1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxTapeDrive2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTapeDrive1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.labelOperation = new System.Windows.Forms.Label();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LongTapeOperationBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTools)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPageImage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.AllowMerge = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 279);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(442, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(235, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "...";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripProgressBar1.Size = new System.Drawing.Size(110, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel2.Text = "...";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "tools.png");
            this.imageList.Images.SetKeyName(1, "drive.png");
            this.imageList.Images.SetKeyName(2, "reel.png");
            this.imageList.Images.SetKeyName(3, "tool.ico");
            this.imageList.Images.SetKeyName(4, "drive.ico");
            this.imageList.Images.SetKeyName(5, "reel.ico");
            this.imageList.Images.SetKeyName(6, "Media.png");
            this.imageList.Images.SetKeyName(7, "Stop.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabPageTools
            // 
            this.tabPageTools.Controls.Add(this.pictureBoxTools);
            this.tabPageTools.Controls.Add(this.groupBox2);
            this.tabPageTools.Controls.Add(this.btnExecuteTools);
            this.tabPageTools.Location = new System.Drawing.Point(4, 22);
            this.tabPageTools.Name = "tabPageTools";
            this.tabPageTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTools.Size = new System.Drawing.Size(434, 229);
            this.tabPageTools.TabIndex = 3;
            this.tabPageTools.Text = "Tools";
            this.tabPageTools.UseVisualStyleBackColor = true;
            // 
            // pictureBoxTools
            // 
            this.pictureBoxTools.ErrorImage = global::TapesAuxiliary.Resource.tools;
            this.pictureBoxTools.Image = global::TapesAuxiliary.Resource.tools;
            this.pictureBoxTools.InitialImage = global::TapesAuxiliary.Resource.tools;
            this.pictureBoxTools.Location = new System.Drawing.Point(300, 20);
            this.pictureBoxTools.Name = "pictureBoxTools";
            this.pictureBoxTools.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxTools.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTools.TabIndex = 19;
            this.pictureBoxTools.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCountOrNumber);
            this.groupBox2.Controls.Add(this.lblMethod);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.textBoxCountOrNumber);
            this.groupBox2.Controls.Add(this.comboBoxTapeTools);
            this.groupBox2.Controls.Add(this.comboBoxMethodTools);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxCommandTools);
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 200);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup operation:";
            // 
            // lblCountOrNumber
            // 
            this.lblCountOrNumber.AutoSize = true;
            this.lblCountOrNumber.Location = new System.Drawing.Point(10, 150);
            this.lblCountOrNumber.Name = "lblCountOrNumber";
            this.lblCountOrNumber.Size = new System.Drawing.Size(14, 13);
            this.lblCountOrNumber.TabIndex = 19;
            this.lblCountOrNumber.Text = "#";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(10, 110);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(46, 13);
            this.lblMethod.TabIndex = 18;
            this.lblMethod.Text = "Method:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TapesAuxiliary.Resource.drive1;
            this.pictureBox4.InitialImage = global::TapesAuxiliary.Resource.drive1;
            this.pictureBox4.Location = new System.Drawing.Point(10, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // textBoxCountOrNumber
            // 
            this.textBoxCountOrNumber.Location = new System.Drawing.Point(80, 150);
            this.textBoxCountOrNumber.Name = "textBoxCountOrNumber";
            this.textBoxCountOrNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxCountOrNumber.TabIndex = 17;
            this.textBoxCountOrNumber.Text = "Enter count:";
            // 
            // comboBoxTapeTools
            // 
            this.comboBoxTapeTools.FormattingEnabled = true;
            this.comboBoxTapeTools.Items.AddRange(new object[] {
            "TAPE0",
            "TAPE1",
            "TAPE2",
            "TAPE3",
            "TAPE4",
            "TAPE5",
            "TAPE6",
            "TAPE7",
            "TAPE8",
            "TAPE9"});
            this.comboBoxTapeTools.Location = new System.Drawing.Point(110, 30);
            this.comboBoxTapeTools.Name = "comboBoxTapeTools";
            this.comboBoxTapeTools.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTapeTools.TabIndex = 6;
            this.comboBoxTapeTools.Text = "Select Tape Drive:";
            // 
            // comboBoxMethodTools
            // 
            this.comboBoxMethodTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMethodTools.FormattingEnabled = true;
            this.comboBoxMethodTools.Items.AddRange(new object[] {
            "Seek to BOD",
            "Seek to EOD",
            "Seek to absolute block #",
            "Seek to logical block #",
            "Space # of blocks",
            "space # of filemarks"});
            this.comboBoxMethodTools.Location = new System.Drawing.Point(80, 110);
            this.comboBoxMethodTools.Name = "comboBoxMethodTools";
            this.comboBoxMethodTools.Size = new System.Drawing.Size(150, 21);
            this.comboBoxMethodTools.TabIndex = 16;
            this.comboBoxMethodTools.Text = "Select method:";
            this.comboBoxMethodTools.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethodTools_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Drive:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Command:";
            // 
            // comboBoxCommandTools
            // 
            this.comboBoxCommandTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCommandTools.FormattingEnabled = true;
            this.comboBoxCommandTools.Items.AddRange(new object[] {
            "Load",
            "Unload",
            "Rewind",
            "Erase",
            "Format",
            "Detect parameters",
            "Set parameters",
            "Write filemarks",
            "Seek or Space"});
            this.comboBoxCommandTools.Location = new System.Drawing.Point(110, 70);
            this.comboBoxCommandTools.Name = "comboBoxCommandTools";
            this.comboBoxCommandTools.Size = new System.Drawing.Size(120, 21);
            this.comboBoxCommandTools.TabIndex = 10;
            this.comboBoxCommandTools.Text = "Command:";
            this.comboBoxCommandTools.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommandTools_SelectedIndexChanged);
            // 
            // btnExecuteTools
            // 
            this.btnExecuteTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecuteTools.Location = new System.Drawing.Point(310, 150);
            this.btnExecuteTools.Name = "btnExecuteTools";
            this.btnExecuteTools.Size = new System.Drawing.Size(80, 40);
            this.btnExecuteTools.TabIndex = 15;
            this.btnExecuteTools.Text = "Execute";
            this.btnExecuteTools.UseVisualStyleBackColor = true;
            this.btnExecuteTools.Click += new System.EventHandler(this.btnExecuteTools_Click);
            // 
            // tabPageImage
            // 
            this.tabPageImage.Controls.Add(this.btnStop);
            this.tabPageImage.Controls.Add(this.btnStart);
            this.tabPageImage.Controls.Add(this.groupBox1);
            this.tabPageImage.Controls.Add(this.labelOperation);
            this.tabPageImage.Controls.Add(this.comboBoxOperation);
            this.tabPageImage.Location = new System.Drawing.Point(4, 22);
            this.tabPageImage.Name = "tabPageImage";
            this.tabPageImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImage.Size = new System.Drawing.Size(434, 229);
            this.tabPageImage.TabIndex = 0;
            this.tabPageImage.Text = "Image";
            this.tabPageImage.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.ImageIndex = 7;
            this.btnStop.ImageList = this.imageList;
            this.btnStop.Location = new System.Drawing.Point(320, 120);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 40);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.ImageIndex = 6;
            this.btnStart.ImageList = this.imageList;
            this.btnStart.Location = new System.Drawing.Point(320, 60);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 40);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lblFolder);
            this.groupBox1.Controls.Add(this.comboBoxSelectedFolder);
            this.groupBox1.Controls.Add(this.lblDrive2);
            this.groupBox1.Controls.Add(this.lblDrive1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.comboBoxTapeDrive2);
            this.groupBox1.Controls.Add(this.comboBoxTapeDrive1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 175);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participants:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TapesAuxiliary.Resource.Folder_blue;
            this.pictureBox3.InitialImage = global::TapesAuxiliary.Resource.Folder_blue;
            this.pictureBox3.Location = new System.Drawing.Point(10, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(45, 110);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(95, 13);
            this.lblFolder.TabIndex = 11;
            this.lblFolder.Text = "Destination Folder:";
            // 
            // comboBoxSelectedFolder
            // 
            this.comboBoxSelectedFolder.FormattingEnabled = true;
            this.comboBoxSelectedFolder.Location = new System.Drawing.Point(10, 140);
            this.comboBoxSelectedFolder.Name = "comboBoxSelectedFolder";
            this.comboBoxSelectedFolder.Size = new System.Drawing.Size(255, 21);
            this.comboBoxSelectedFolder.TabIndex = 10;
            // 
            // lblDrive2
            // 
            this.lblDrive2.AutoSize = true;
            this.lblDrive2.Location = new System.Drawing.Point(45, 70);
            this.lblDrive2.Name = "lblDrive2";
            this.lblDrive2.Size = new System.Drawing.Size(91, 13);
            this.lblDrive2.TabIndex = 9;
            this.lblDrive2.Text = "Destination Drive:";
            // 
            // lblDrive1
            // 
            this.lblDrive1.AutoSize = true;
            this.lblDrive1.Location = new System.Drawing.Point(45, 30);
            this.lblDrive1.Name = "lblDrive1";
            this.lblDrive1.Size = new System.Drawing.Size(72, 13);
            this.lblDrive1.TabIndex = 8;
            this.lblDrive1.Text = "Source Drive:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TapesAuxiliary.Resource.drive1;
            this.pictureBox2.InitialImage = global::TapesAuxiliary.Resource.drive1;
            this.pictureBox2.Location = new System.Drawing.Point(10, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // comboBoxTapeDrive2
            // 
            this.comboBoxTapeDrive2.FormattingEnabled = true;
            this.comboBoxTapeDrive2.Items.AddRange(new object[] {
            "TAPE0",
            "TAPE1",
            "TAPE2",
            "TAPE3",
            "TAPE4",
            "TAPE5",
            "TAPE6",
            "TAPE7",
            "TAPE8",
            "TAPE9"});
            this.comboBoxTapeDrive2.Location = new System.Drawing.Point(145, 70);
            this.comboBoxTapeDrive2.Name = "comboBoxTapeDrive2";
            this.comboBoxTapeDrive2.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTapeDrive2.TabIndex = 6;
            this.comboBoxTapeDrive2.Text = "Select Tape Drive:";
            // 
            // comboBoxTapeDrive1
            // 
            this.comboBoxTapeDrive1.FormattingEnabled = true;
            this.comboBoxTapeDrive1.Items.AddRange(new object[] {
            "TAPE0",
            "TAPE1",
            "TAPE2",
            "TAPE3",
            "TAPE4",
            "TAPE5",
            "TAPE6",
            "TAPE7",
            "TAPE8",
            "TAPE9"});
            this.comboBoxTapeDrive1.Location = new System.Drawing.Point(145, 30);
            this.comboBoxTapeDrive1.Name = "comboBoxTapeDrive1";
            this.comboBoxTapeDrive1.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTapeDrive1.TabIndex = 5;
            this.comboBoxTapeDrive1.Text = "Select Tape Drive:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TapesAuxiliary.Resource.drive1;
            this.pictureBox1.InitialImage = global::TapesAuxiliary.Resource.drive1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(145, 110);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(120, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperation.Location = new System.Drawing.Point(10, 10);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(56, 13);
            this.labelOperation.TabIndex = 3;
            this.labelOperation.Text = "Operation:";
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "Image",
            "Write",
            "Duplicate"});
            this.comboBoxOperation.Location = new System.Drawing.Point(80, 10);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOperation.TabIndex = 1;
            this.comboBoxOperation.Text = "Operation:";
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageImage);
            this.tabControl.Controls.Add(this.tabPageTools);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(442, 255);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            // 
            // LongTapeOperationBackgroundWorker
            // 
            this.LongTapeOperationBackgroundWorker.WorkerReportsProgress = true;
            this.LongTapeOperationBackgroundWorker.WorkerSupportsCancellation = true;
            this.LongTapeOperationBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LongTapeOperationBackgroundWorker_DoWork);
            this.LongTapeOperationBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LongTapeOperationBackgroundWorker_RunWorkerCompleted);
            this.LongTapeOperationBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.LongTapeOperationBackgroundWorker_ProgressChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = global::TapesAuxiliary.Properties.Settings.Default.m_SelectedPath;
            this.folderBrowserDialog.Tag = "Path";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 301);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Tape Exerciser";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTools)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPageImage.ResumeLayout(false);
            this.tabPageImage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TabPage tabPageTools;
        private System.Windows.Forms.TabPage tabPageImage;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.ComboBox comboBoxSelectedFolder;
        private System.Windows.Forms.Label lblDrive2;
        private System.Windows.Forms.Label lblDrive1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxTapeDrive2;
        private System.Windows.Forms.ComboBox comboBoxTapeDrive1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.TabControl tabControl;
        private System.ComponentModel.BackgroundWorker LongTapeOperationBackgroundWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox comboBoxTapeTools;
        private System.Windows.Forms.Button btnExecuteTools;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCommandTools;
        private System.Windows.Forms.TextBox textBoxCountOrNumber;
        private System.Windows.Forms.ComboBox comboBoxMethodTools;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCountOrNumber;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.PictureBox pictureBoxTools;

    }
}

