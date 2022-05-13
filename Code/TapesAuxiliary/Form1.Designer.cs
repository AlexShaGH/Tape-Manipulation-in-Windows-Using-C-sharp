namespace TapesAuxiliary
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonGetParameters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.labelTapeWriteProtect2 = new System.Windows.Forms.Label();
            this.labelTapePartitionCount2 = new System.Windows.Forms.Label();
            this.labelTapeBlockSize2 = new System.Windows.Forms.Label();
            this.labelTapeRemaining2 = new System.Windows.Forms.Label();
            this.labelTapeCapacity2 = new System.Windows.Forms.Label();
            this.labelTapeWriteProtect1 = new System.Windows.Forms.Label();
            this.labelTapePartitionCount1 = new System.Windows.Forms.Label();
            this.labelTapeBlockSize1 = new System.Windows.Forms.Label();
            this.labelTapeRemaining1 = new System.Windows.Forms.Label();
            this.labelTapeCapacity1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelDriveNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelVariableBlockCapable2 = new System.Windows.Forms.Label();
            this.labelCompressionCapable2 = new System.Windows.Forms.Label();
            this.labelVariableBlockCapable1 = new System.Windows.Forms.Label();
            this.labelCompressionCapable1 = new System.Windows.Forms.Label();
            this.labelEOT2 = new System.Windows.Forms.Label();
            this.labelFeaturesHigh2 = new System.Windows.Forms.Label();
            this.labelFeaturesLow2 = new System.Windows.Forms.Label();
            this.labelDrivePartitionCount2 = new System.Windows.Forms.Label();
            this.labelMinimumBlockSize2 = new System.Windows.Forms.Label();
            this.labelMaximumBlockSize2 = new System.Windows.Forms.Label();
            this.labelDefaultBlockSize2 = new System.Windows.Forms.Label();
            this.labelReportSetMarks2 = new System.Windows.Forms.Label();
            this.labelDataPadding2 = new System.Windows.Forms.Label();
            this.labelDriveCompression2 = new System.Windows.Forms.Label();
            this.labelDriveECC2 = new System.Windows.Forms.Label();
            this.labelEOT1 = new System.Windows.Forms.Label();
            this.labelFeaturesHigh1 = new System.Windows.Forms.Label();
            this.labelFeaturesLow1 = new System.Windows.Forms.Label();
            this.labelDrivePartitionCount1 = new System.Windows.Forms.Label();
            this.labelMinimumBlockSize1 = new System.Windows.Forms.Label();
            this.labelMaximumBlockSize1 = new System.Windows.Forms.Label();
            this.labelDefaultBlockSize1 = new System.Windows.Forms.Label();
            this.labelReportSetMarks1 = new System.Windows.Forms.Label();
            this.labelDataPadding1 = new System.Windows.Forms.Label();
            this.labelDriveCompression1 = new System.Windows.Forms.Label();
            this.labelDriveECC1 = new System.Windows.Forms.Label();
            this.buttonSetToFalse = new System.Windows.Forms.Button();
            this.buttonSetToTrue = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Erase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonGetParameters
            // 
            this.buttonGetParameters.Location = new System.Drawing.Point(431, 150);
            this.buttonGetParameters.Name = "buttonGetParameters";
            this.buttonGetParameters.Size = new System.Drawing.Size(91, 23);
            this.buttonGetParameters.TabIndex = 3;
            this.buttonGetParameters.Text = "Get Parameters";
            this.buttonGetParameters.UseVisualStyleBackColor = true;
            this.buttonGetParameters.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.labelTapeWriteProtect2);
            this.groupbox1.Controls.Add(this.labelTapePartitionCount2);
            this.groupbox1.Controls.Add(this.labelTapeBlockSize2);
            this.groupbox1.Controls.Add(this.labelTapeRemaining2);
            this.groupbox1.Controls.Add(this.labelTapeCapacity2);
            this.groupbox1.Controls.Add(this.labelTapeWriteProtect1);
            this.groupbox1.Controls.Add(this.labelTapePartitionCount1);
            this.groupbox1.Controls.Add(this.labelTapeBlockSize1);
            this.groupbox1.Controls.Add(this.labelTapeRemaining1);
            this.groupbox1.Controls.Add(this.labelTapeCapacity1);
            this.groupbox1.Location = new System.Drawing.Point(291, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(231, 111);
            this.groupbox1.TabIndex = 5;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = " Media Parameters:";
            // 
            // labelTapeWriteProtect2
            // 
            this.labelTapeWriteProtect2.AutoSize = true;
            this.labelTapeWriteProtect2.Location = new System.Drawing.Point(88, 88);
            this.labelTapeWriteProtect2.Name = "labelTapeWriteProtect2";
            this.labelTapeWriteProtect2.Size = new System.Drawing.Size(0, 13);
            this.labelTapeWriteProtect2.TabIndex = 9;
            // 
            // labelTapePartitionCount2
            // 
            this.labelTapePartitionCount2.AutoSize = true;
            this.labelTapePartitionCount2.Location = new System.Drawing.Point(88, 71);
            this.labelTapePartitionCount2.Name = "labelTapePartitionCount2";
            this.labelTapePartitionCount2.Size = new System.Drawing.Size(0, 13);
            this.labelTapePartitionCount2.TabIndex = 8;
            // 
            // labelTapeBlockSize2
            // 
            this.labelTapeBlockSize2.AutoSize = true;
            this.labelTapeBlockSize2.Location = new System.Drawing.Point(88, 54);
            this.labelTapeBlockSize2.Name = "labelTapeBlockSize2";
            this.labelTapeBlockSize2.Size = new System.Drawing.Size(0, 13);
            this.labelTapeBlockSize2.TabIndex = 7;
            // 
            // labelTapeRemaining2
            // 
            this.labelTapeRemaining2.AutoSize = true;
            this.labelTapeRemaining2.Location = new System.Drawing.Point(88, 37);
            this.labelTapeRemaining2.Name = "labelTapeRemaining2";
            this.labelTapeRemaining2.Size = new System.Drawing.Size(0, 13);
            this.labelTapeRemaining2.TabIndex = 6;
            // 
            // labelTapeCapacity2
            // 
            this.labelTapeCapacity2.AutoSize = true;
            this.labelTapeCapacity2.Location = new System.Drawing.Point(88, 20);
            this.labelTapeCapacity2.Name = "labelTapeCapacity2";
            this.labelTapeCapacity2.Size = new System.Drawing.Size(0, 13);
            this.labelTapeCapacity2.TabIndex = 5;
            // 
            // labelTapeWriteProtect1
            // 
            this.labelTapeWriteProtect1.AutoSize = true;
            this.labelTapeWriteProtect1.Location = new System.Drawing.Point(7, 88);
            this.labelTapeWriteProtect1.Name = "labelTapeWriteProtect1";
            this.labelTapeWriteProtect1.Size = new System.Drawing.Size(72, 13);
            this.labelTapeWriteProtect1.TabIndex = 4;
            this.labelTapeWriteProtect1.Text = "Write Protect:";
            // 
            // labelTapePartitionCount1
            // 
            this.labelTapePartitionCount1.AutoSize = true;
            this.labelTapePartitionCount1.Location = new System.Drawing.Point(7, 71);
            this.labelTapePartitionCount1.Name = "labelTapePartitionCount1";
            this.labelTapePartitionCount1.Size = new System.Drawing.Size(79, 13);
            this.labelTapePartitionCount1.TabIndex = 3;
            this.labelTapePartitionCount1.Text = "Partition Count:";
            // 
            // labelTapeBlockSize1
            // 
            this.labelTapeBlockSize1.AutoSize = true;
            this.labelTapeBlockSize1.Location = new System.Drawing.Point(7, 54);
            this.labelTapeBlockSize1.Name = "labelTapeBlockSize1";
            this.labelTapeBlockSize1.Size = new System.Drawing.Size(60, 13);
            this.labelTapeBlockSize1.TabIndex = 2;
            this.labelTapeBlockSize1.Text = "Block Size:";
            // 
            // labelTapeRemaining1
            // 
            this.labelTapeRemaining1.AutoSize = true;
            this.labelTapeRemaining1.Location = new System.Drawing.Point(7, 37);
            this.labelTapeRemaining1.Name = "labelTapeRemaining1";
            this.labelTapeRemaining1.Size = new System.Drawing.Size(60, 13);
            this.labelTapeRemaining1.TabIndex = 1;
            this.labelTapeRemaining1.Text = "Remaining:";
            // 
            // labelTapeCapacity1
            // 
            this.labelTapeCapacity1.AutoSize = true;
            this.labelTapeCapacity1.Location = new System.Drawing.Point(7, 20);
            this.labelTapeCapacity1.Name = "labelTapeCapacity1";
            this.labelTapeCapacity1.Size = new System.Drawing.Size(51, 13);
            this.labelTapeCapacity1.TabIndex = 0;
            this.labelTapeCapacity1.Text = "Capacity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(336, 153);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // labelDriveNumber
            // 
            this.labelDriveNumber.AutoSize = true;
            this.labelDriveNumber.Location = new System.Drawing.Point(288, 160);
            this.labelDriveNumber.Name = "labelDriveNumber";
            this.labelDriveNumber.Size = new System.Drawing.Size(35, 13);
            this.labelDriveNumber.TabIndex = 7;
            this.labelDriveNumber.Text = "Drive:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelVariableBlockCapable2);
            this.groupBox2.Controls.Add(this.labelCompressionCapable2);
            this.groupBox2.Controls.Add(this.labelVariableBlockCapable1);
            this.groupBox2.Controls.Add(this.labelCompressionCapable1);
            this.groupBox2.Controls.Add(this.labelEOT2);
            this.groupBox2.Controls.Add(this.labelFeaturesHigh2);
            this.groupBox2.Controls.Add(this.labelFeaturesLow2);
            this.groupBox2.Controls.Add(this.labelDrivePartitionCount2);
            this.groupBox2.Controls.Add(this.labelMinimumBlockSize2);
            this.groupBox2.Controls.Add(this.labelMaximumBlockSize2);
            this.groupBox2.Controls.Add(this.labelDefaultBlockSize2);
            this.groupBox2.Controls.Add(this.labelReportSetMarks2);
            this.groupBox2.Controls.Add(this.labelDataPadding2);
            this.groupBox2.Controls.Add(this.labelDriveCompression2);
            this.groupBox2.Controls.Add(this.labelDriveECC2);
            this.groupBox2.Controls.Add(this.labelEOT1);
            this.groupBox2.Controls.Add(this.labelFeaturesHigh1);
            this.groupBox2.Controls.Add(this.labelFeaturesLow1);
            this.groupBox2.Controls.Add(this.labelDrivePartitionCount1);
            this.groupBox2.Controls.Add(this.labelMinimumBlockSize1);
            this.groupBox2.Controls.Add(this.labelMaximumBlockSize1);
            this.groupBox2.Controls.Add(this.labelDefaultBlockSize1);
            this.groupBox2.Controls.Add(this.labelReportSetMarks1);
            this.groupBox2.Controls.Add(this.labelDataPadding1);
            this.groupBox2.Controls.Add(this.labelDriveCompression1);
            this.groupBox2.Controls.Add(this.labelDriveECC1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 222);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drive Parameters:";
            // 
            // labelVariableBlockCapable2
            // 
            this.labelVariableBlockCapable2.AutoSize = true;
            this.labelVariableBlockCapable2.Location = new System.Drawing.Point(140, 200);
            this.labelVariableBlockCapable2.Name = "labelVariableBlockCapable2";
            this.labelVariableBlockCapable2.Size = new System.Drawing.Size(10, 13);
            this.labelVariableBlockCapable2.TabIndex = 25;
            this.labelVariableBlockCapable2.Text = " ";
            // 
            // labelCompressionCapable2
            // 
            this.labelCompressionCapable2.AutoSize = true;
            this.labelCompressionCapable2.Location = new System.Drawing.Point(140, 185);
            this.labelCompressionCapable2.Name = "labelCompressionCapable2";
            this.labelCompressionCapable2.Size = new System.Drawing.Size(10, 13);
            this.labelCompressionCapable2.TabIndex = 24;
            this.labelCompressionCapable2.Text = " ";
            // 
            // labelVariableBlockCapable1
            // 
            this.labelVariableBlockCapable1.AutoSize = true;
            this.labelVariableBlockCapable1.Location = new System.Drawing.Point(6, 200);
            this.labelVariableBlockCapable1.Name = "labelVariableBlockCapable1";
            this.labelVariableBlockCapable1.Size = new System.Drawing.Size(120, 13);
            this.labelVariableBlockCapable1.TabIndex = 23;
            this.labelVariableBlockCapable1.Text = "Variable Block Capable:";
            // 
            // labelCompressionCapable1
            // 
            this.labelCompressionCapable1.AutoSize = true;
            this.labelCompressionCapable1.Location = new System.Drawing.Point(6, 185);
            this.labelCompressionCapable1.Name = "labelCompressionCapable1";
            this.labelCompressionCapable1.Size = new System.Drawing.Size(112, 13);
            this.labelCompressionCapable1.TabIndex = 22;
            this.labelCompressionCapable1.Text = "Compression Capable:";
            // 
            // labelEOT2
            // 
            this.labelEOT2.AutoSize = true;
            this.labelEOT2.Location = new System.Drawing.Point(134, 178);
            this.labelEOT2.Name = "labelEOT2";
            this.labelEOT2.Size = new System.Drawing.Size(10, 13);
            this.labelEOT2.TabIndex = 21;
            this.labelEOT2.Text = " ";
            // 
            // labelFeaturesHigh2
            // 
            this.labelFeaturesHigh2.AutoSize = true;
            this.labelFeaturesHigh2.Location = new System.Drawing.Point(134, 164);
            this.labelFeaturesHigh2.Name = "labelFeaturesHigh2";
            this.labelFeaturesHigh2.Size = new System.Drawing.Size(10, 13);
            this.labelFeaturesHigh2.TabIndex = 20;
            this.labelFeaturesHigh2.Text = " ";
            // 
            // labelFeaturesLow2
            // 
            this.labelFeaturesLow2.AutoSize = true;
            this.labelFeaturesLow2.Location = new System.Drawing.Point(134, 148);
            this.labelFeaturesLow2.Name = "labelFeaturesLow2";
            this.labelFeaturesLow2.Size = new System.Drawing.Size(10, 13);
            this.labelFeaturesLow2.TabIndex = 19;
            this.labelFeaturesLow2.Text = " ";
            // 
            // labelDrivePartitionCount2
            // 
            this.labelDrivePartitionCount2.AutoSize = true;
            this.labelDrivePartitionCount2.Location = new System.Drawing.Point(134, 132);
            this.labelDrivePartitionCount2.Name = "labelDrivePartitionCount2";
            this.labelDrivePartitionCount2.Size = new System.Drawing.Size(10, 13);
            this.labelDrivePartitionCount2.TabIndex = 18;
            this.labelDrivePartitionCount2.Text = " ";
            // 
            // labelMinimumBlockSize2
            // 
            this.labelMinimumBlockSize2.AutoSize = true;
            this.labelMinimumBlockSize2.Location = new System.Drawing.Point(134, 116);
            this.labelMinimumBlockSize2.Name = "labelMinimumBlockSize2";
            this.labelMinimumBlockSize2.Size = new System.Drawing.Size(10, 13);
            this.labelMinimumBlockSize2.TabIndex = 17;
            this.labelMinimumBlockSize2.Text = " ";
            // 
            // labelMaximumBlockSize2
            // 
            this.labelMaximumBlockSize2.AutoSize = true;
            this.labelMaximumBlockSize2.Location = new System.Drawing.Point(134, 100);
            this.labelMaximumBlockSize2.Name = "labelMaximumBlockSize2";
            this.labelMaximumBlockSize2.Size = new System.Drawing.Size(10, 13);
            this.labelMaximumBlockSize2.TabIndex = 16;
            this.labelMaximumBlockSize2.Text = " ";
            // 
            // labelDefaultBlockSize2
            // 
            this.labelDefaultBlockSize2.AutoSize = true;
            this.labelDefaultBlockSize2.Location = new System.Drawing.Point(134, 84);
            this.labelDefaultBlockSize2.Name = "labelDefaultBlockSize2";
            this.labelDefaultBlockSize2.Size = new System.Drawing.Size(10, 13);
            this.labelDefaultBlockSize2.TabIndex = 15;
            this.labelDefaultBlockSize2.Text = " ";
            // 
            // labelReportSetMarks2
            // 
            this.labelReportSetMarks2.AutoSize = true;
            this.labelReportSetMarks2.Location = new System.Drawing.Point(134, 68);
            this.labelReportSetMarks2.Name = "labelReportSetMarks2";
            this.labelReportSetMarks2.Size = new System.Drawing.Size(10, 13);
            this.labelReportSetMarks2.TabIndex = 14;
            this.labelReportSetMarks2.Text = " ";
            // 
            // labelDataPadding2
            // 
            this.labelDataPadding2.AutoSize = true;
            this.labelDataPadding2.Location = new System.Drawing.Point(134, 52);
            this.labelDataPadding2.Name = "labelDataPadding2";
            this.labelDataPadding2.Size = new System.Drawing.Size(10, 13);
            this.labelDataPadding2.TabIndex = 13;
            this.labelDataPadding2.Text = " ";
            // 
            // labelDriveCompression2
            // 
            this.labelDriveCompression2.AutoSize = true;
            this.labelDriveCompression2.Location = new System.Drawing.Point(134, 36);
            this.labelDriveCompression2.Name = "labelDriveCompression2";
            this.labelDriveCompression2.Size = new System.Drawing.Size(10, 13);
            this.labelDriveCompression2.TabIndex = 12;
            this.labelDriveCompression2.Text = " ";
            // 
            // labelDriveECC2
            // 
            this.labelDriveECC2.AutoSize = true;
            this.labelDriveECC2.BackColor = System.Drawing.SystemColors.Control;
            this.labelDriveECC2.Location = new System.Drawing.Point(134, 20);
            this.labelDriveECC2.Name = "labelDriveECC2";
            this.labelDriveECC2.Size = new System.Drawing.Size(10, 13);
            this.labelDriveECC2.TabIndex = 11;
            this.labelDriveECC2.Text = " ";
            // 
            // labelEOT1
            // 
            this.labelEOT1.AutoSize = true;
            this.labelEOT1.Location = new System.Drawing.Point(6, 170);
            this.labelEOT1.Name = "labelEOT1";
            this.labelEOT1.Size = new System.Drawing.Size(103, 13);
            this.labelEOT1.TabIndex = 10;
            this.labelEOT1.Text = "EOT Warning Zone:";
            // 
            // labelFeaturesHigh1
            // 
            this.labelFeaturesHigh1.AutoSize = true;
            this.labelFeaturesHigh1.Location = new System.Drawing.Point(6, 155);
            this.labelFeaturesHigh1.Name = "labelFeaturesHigh1";
            this.labelFeaturesHigh1.Size = new System.Drawing.Size(76, 13);
            this.labelFeaturesHigh1.TabIndex = 9;
            this.labelFeaturesHigh1.Text = "Features High:";
            // 
            // labelFeaturesLow1
            // 
            this.labelFeaturesLow1.AutoSize = true;
            this.labelFeaturesLow1.Location = new System.Drawing.Point(6, 140);
            this.labelFeaturesLow1.Name = "labelFeaturesLow1";
            this.labelFeaturesLow1.Size = new System.Drawing.Size(74, 13);
            this.labelFeaturesLow1.TabIndex = 8;
            this.labelFeaturesLow1.Text = "Features Low:";
            // 
            // labelDrivePartitionCount1
            // 
            this.labelDrivePartitionCount1.AutoSize = true;
            this.labelDrivePartitionCount1.Location = new System.Drawing.Point(6, 125);
            this.labelDrivePartitionCount1.Name = "labelDrivePartitionCount1";
            this.labelDrivePartitionCount1.Size = new System.Drawing.Size(79, 13);
            this.labelDrivePartitionCount1.TabIndex = 7;
            this.labelDrivePartitionCount1.Text = "Partition Count:";
            // 
            // labelMinimumBlockSize1
            // 
            this.labelMinimumBlockSize1.AutoSize = true;
            this.labelMinimumBlockSize1.Location = new System.Drawing.Point(6, 110);
            this.labelMinimumBlockSize1.Name = "labelMinimumBlockSize1";
            this.labelMinimumBlockSize1.Size = new System.Drawing.Size(104, 13);
            this.labelMinimumBlockSize1.TabIndex = 6;
            this.labelMinimumBlockSize1.Text = "Minimum Block Size:";
            // 
            // labelMaximumBlockSize1
            // 
            this.labelMaximumBlockSize1.AutoSize = true;
            this.labelMaximumBlockSize1.Location = new System.Drawing.Point(6, 95);
            this.labelMaximumBlockSize1.Name = "labelMaximumBlockSize1";
            this.labelMaximumBlockSize1.Size = new System.Drawing.Size(107, 13);
            this.labelMaximumBlockSize1.TabIndex = 5;
            this.labelMaximumBlockSize1.Text = "Maximum Block Size:";
            // 
            // labelDefaultBlockSize1
            // 
            this.labelDefaultBlockSize1.AutoSize = true;
            this.labelDefaultBlockSize1.Location = new System.Drawing.Point(6, 80);
            this.labelDefaultBlockSize1.Name = "labelDefaultBlockSize1";
            this.labelDefaultBlockSize1.Size = new System.Drawing.Size(97, 13);
            this.labelDefaultBlockSize1.TabIndex = 4;
            this.labelDefaultBlockSize1.Text = "Default Block Size:";
            // 
            // labelReportSetMarks1
            // 
            this.labelReportSetMarks1.AutoSize = true;
            this.labelReportSetMarks1.Location = new System.Drawing.Point(6, 65);
            this.labelReportSetMarks1.Name = "labelReportSetMarks1";
            this.labelReportSetMarks1.Size = new System.Drawing.Size(93, 13);
            this.labelReportSetMarks1.TabIndex = 3;
            this.labelReportSetMarks1.Text = "Report Set Marks:";
            // 
            // labelDataPadding1
            // 
            this.labelDataPadding1.AutoSize = true;
            this.labelDataPadding1.Location = new System.Drawing.Point(6, 50);
            this.labelDataPadding1.Name = "labelDataPadding1";
            this.labelDataPadding1.Size = new System.Drawing.Size(75, 13);
            this.labelDataPadding1.TabIndex = 2;
            this.labelDataPadding1.Text = "Data Padding:";
            // 
            // labelDriveCompression1
            // 
            this.labelDriveCompression1.AutoSize = true;
            this.labelDriveCompression1.Location = new System.Drawing.Point(6, 35);
            this.labelDriveCompression1.Name = "labelDriveCompression1";
            this.labelDriveCompression1.Size = new System.Drawing.Size(70, 13);
            this.labelDriveCompression1.TabIndex = 1;
            this.labelDriveCompression1.Text = "Compression:";
            // 
            // labelDriveECC1
            // 
            this.labelDriveECC1.AutoSize = true;
            this.labelDriveECC1.Location = new System.Drawing.Point(6, 20);
            this.labelDriveECC1.Name = "labelDriveECC1";
            this.labelDriveECC1.Size = new System.Drawing.Size(31, 13);
            this.labelDriveECC1.TabIndex = 0;
            this.labelDriveECC1.Text = "ECC:";
            // 
            // buttonSetToFalse
            // 
            this.buttonSetToFalse.Location = new System.Drawing.Point(431, 182);
            this.buttonSetToFalse.Name = "buttonSetToFalse";
            this.buttonSetToFalse.Size = new System.Drawing.Size(91, 23);
            this.buttonSetToFalse.TabIndex = 9;
            this.buttonSetToFalse.Text = "Set To False";
            this.buttonSetToFalse.UseVisualStyleBackColor = true;
            this.buttonSetToFalse.Click += new System.EventHandler(this.buttonSetToFalse_Click);
            // 
            // buttonSetToTrue
            // 
            this.buttonSetToTrue.Location = new System.Drawing.Point(431, 211);
            this.buttonSetToTrue.Name = "buttonSetToTrue";
            this.buttonSetToTrue.Size = new System.Drawing.Size(91, 23);
            this.buttonSetToTrue.TabIndex = 10;
            this.buttonSetToTrue.Text = "Set To True";
            this.buttonSetToTrue.UseVisualStyleBackColor = true;
            this.buttonSetToTrue.Click += new System.EventHandler(this.buttonSetToTrue_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(609, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "TestMap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 247);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSetToTrue);
            this.Controls.Add(this.buttonSetToFalse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelDriveNumber);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGetParameters);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonGetParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label labelTapeCapacity1;
        private System.Windows.Forms.Label labelTapeWriteProtect2;
        private System.Windows.Forms.Label labelTapePartitionCount2;
        private System.Windows.Forms.Label labelTapeBlockSize2;
        private System.Windows.Forms.Label labelTapeRemaining2;
        private System.Windows.Forms.Label labelTapeCapacity2;
        private System.Windows.Forms.Label labelTapeWriteProtect1;
        private System.Windows.Forms.Label labelTapePartitionCount1;
        private System.Windows.Forms.Label labelTapeBlockSize1;
        private System.Windows.Forms.Label labelTapeRemaining1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelDriveNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEOT1;
        private System.Windows.Forms.Label labelFeaturesHigh1;
        private System.Windows.Forms.Label labelFeaturesLow1;
        private System.Windows.Forms.Label labelDrivePartitionCount1;
        private System.Windows.Forms.Label labelMinimumBlockSize1;
        private System.Windows.Forms.Label labelMaximumBlockSize1;
        private System.Windows.Forms.Label labelDefaultBlockSize1;
        private System.Windows.Forms.Label labelReportSetMarks1;
        private System.Windows.Forms.Label labelDataPadding1;
        private System.Windows.Forms.Label labelDriveCompression1;
        private System.Windows.Forms.Label labelDriveECC1;
        private System.Windows.Forms.Label labelEOT2;
        private System.Windows.Forms.Label labelFeaturesHigh2;
        private System.Windows.Forms.Label labelFeaturesLow2;
        private System.Windows.Forms.Label labelDrivePartitionCount2;
        private System.Windows.Forms.Label labelMinimumBlockSize2;
        private System.Windows.Forms.Label labelMaximumBlockSize2;
        private System.Windows.Forms.Label labelDefaultBlockSize2;
        private System.Windows.Forms.Label labelReportSetMarks2;
        private System.Windows.Forms.Label labelDataPadding2;
        private System.Windows.Forms.Label labelDriveCompression2;
        private System.Windows.Forms.Label labelDriveECC2;
        private System.Windows.Forms.Label labelCompressionCapable2;
        private System.Windows.Forms.Label labelVariableBlockCapable1;
        private System.Windows.Forms.Label labelCompressionCapable1;
        private System.Windows.Forms.Label labelVariableBlockCapable2;
        private System.Windows.Forms.Button buttonSetToFalse;
        private System.Windows.Forms.Button buttonSetToTrue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
    }
}

