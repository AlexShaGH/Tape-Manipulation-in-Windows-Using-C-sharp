namespace TapesAuxiliary
{
    partial class TapeParametersDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TapeParametersDlg));
            this.groupBoxDrive = new System.Windows.Forms.GroupBox();
            this.groupBoxTape = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxDrive = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxMediaPresent = new System.Windows.Forms.TextBox();
            this.textBoxCompressionCapable = new System.Windows.Forms.TextBox();
            this.textBoxCompressionEnabled = new System.Windows.Forms.TextBox();
            this.textBoxECC = new System.Windows.Forms.TextBox();
            this.textBoxDataPadding = new System.Windows.Forms.TextBox();
            this.textBoxSetmarkReporting = new System.Windows.Forms.TextBox();
            this.textBoxVariableBS = new System.Windows.Forms.TextBox();
            this.textBoxDefaultBlockSize = new System.Windows.Forms.TextBox();
            this.textBoxMaximumBS = new System.Windows.Forms.TextBox();
            this.textBoxMinimumBS = new System.Windows.Forms.TextBox();
            this.textBoxMaximumPartCount = new System.Windows.Forms.TextBox();
            this.textBoxEOTSize = new System.Windows.Forms.TextBox();
            this.textBoxWriteProtected = new System.Windows.Forms.TextBox();
            this.textBoxBlockSizeTape = new System.Windows.Forms.TextBox();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textBoxRemaining = new System.Windows.Forms.TextBox();
            this.textBoxPartitionCount = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxDrive.SuspendLayout();
            this.groupBoxTape.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDrive
            // 
            this.groupBoxDrive.Controls.Add(this.textBoxEOTSize);
            this.groupBoxDrive.Controls.Add(this.textBoxMaximumPartCount);
            this.groupBoxDrive.Controls.Add(this.textBoxMinimumBS);
            this.groupBoxDrive.Controls.Add(this.textBoxMaximumBS);
            this.groupBoxDrive.Controls.Add(this.textBoxDefaultBlockSize);
            this.groupBoxDrive.Controls.Add(this.textBoxVariableBS);
            this.groupBoxDrive.Controls.Add(this.textBoxSetmarkReporting);
            this.groupBoxDrive.Controls.Add(this.textBoxDataPadding);
            this.groupBoxDrive.Controls.Add(this.textBoxECC);
            this.groupBoxDrive.Controls.Add(this.textBoxCompressionEnabled);
            this.groupBoxDrive.Controls.Add(this.textBoxCompressionCapable);
            this.groupBoxDrive.Controls.Add(this.textBoxMediaPresent);
            this.groupBoxDrive.Controls.Add(this.textBoxStatus);
            this.groupBoxDrive.Controls.Add(this.textBoxDrive);
            this.groupBoxDrive.Controls.Add(this.label9);
            this.groupBoxDrive.Controls.Add(this.label10);
            this.groupBoxDrive.Controls.Add(this.label11);
            this.groupBoxDrive.Controls.Add(this.label12);
            this.groupBoxDrive.Controls.Add(this.label13);
            this.groupBoxDrive.Controls.Add(this.label14);
            this.groupBoxDrive.Controls.Add(this.label5);
            this.groupBoxDrive.Controls.Add(this.label6);
            this.groupBoxDrive.Controls.Add(this.label7);
            this.groupBoxDrive.Controls.Add(this.label8);
            this.groupBoxDrive.Controls.Add(this.label3);
            this.groupBoxDrive.Controls.Add(this.label4);
            this.groupBoxDrive.Controls.Add(this.label2);
            this.groupBoxDrive.Controls.Add(this.label1);
            this.groupBoxDrive.Location = new System.Drawing.Point(20, 20);
            this.groupBoxDrive.Name = "groupBoxDrive";
            this.groupBoxDrive.Size = new System.Drawing.Size(289, 377);
            this.groupBoxDrive.TabIndex = 0;
            this.groupBoxDrive.TabStop = false;
            this.groupBoxDrive.Text = "Drive parameters:";
            // 
            // groupBoxTape
            // 
            this.groupBoxTape.Controls.Add(this.textBoxPartitionCount);
            this.groupBoxTape.Controls.Add(this.textBoxRemaining);
            this.groupBoxTape.Controls.Add(this.textBoxCapacity);
            this.groupBoxTape.Controls.Add(this.textBoxBlockSizeTape);
            this.groupBoxTape.Controls.Add(this.textBoxWriteProtected);
            this.groupBoxTape.Controls.Add(this.label18);
            this.groupBoxTape.Controls.Add(this.label19);
            this.groupBoxTape.Controls.Add(this.label20);
            this.groupBoxTape.Controls.Add(this.label21);
            this.groupBoxTape.Controls.Add(this.label15);
            this.groupBoxTape.Location = new System.Drawing.Point(330, 20);
            this.groupBoxTape.Name = "groupBoxTape";
            this.groupBoxTape.Size = new System.Drawing.Size(240, 155);
            this.groupBoxTape.TabIndex = 1;
            this.groupBoxTape.TabStop = false;
            this.groupBoxTape.Text = "Tape parameters:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tape drive:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Media present:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Compression capable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Compression enabled:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Supporting ECC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data Padding enabled:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Setmark reporting enabled:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Variable block capable:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Default block size:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Maximum block size:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Minimum block size:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Maximum partition count:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "EOT Warning zone size:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Partition count:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Write protected:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Block size:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Capacity:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Remaining:";
            // 
            // textBoxDrive
            // 
            this.textBoxDrive.Location = new System.Drawing.Point(150, 17);
            this.textBoxDrive.Name = "textBoxDrive";
            this.textBoxDrive.ReadOnly = true;
            this.textBoxDrive.Size = new System.Drawing.Size(120, 20);
            this.textBoxDrive.TabIndex = 16;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(150, 42);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(120, 20);
            this.textBoxStatus.TabIndex = 17;
            // 
            // textBoxMediaPresent
            // 
            this.textBoxMediaPresent.Location = new System.Drawing.Point(150, 67);
            this.textBoxMediaPresent.Name = "textBoxMediaPresent";
            this.textBoxMediaPresent.ReadOnly = true;
            this.textBoxMediaPresent.Size = new System.Drawing.Size(120, 20);
            this.textBoxMediaPresent.TabIndex = 18;
            // 
            // textBoxCompressionCapable
            // 
            this.textBoxCompressionCapable.Location = new System.Drawing.Point(150, 92);
            this.textBoxCompressionCapable.Name = "textBoxCompressionCapable";
            this.textBoxCompressionCapable.ReadOnly = true;
            this.textBoxCompressionCapable.Size = new System.Drawing.Size(120, 20);
            this.textBoxCompressionCapable.TabIndex = 19;
            // 
            // textBoxCompressionEnabled
            // 
            this.textBoxCompressionEnabled.Location = new System.Drawing.Point(150, 117);
            this.textBoxCompressionEnabled.Name = "textBoxCompressionEnabled";
            this.textBoxCompressionEnabled.ReadOnly = true;
            this.textBoxCompressionEnabled.Size = new System.Drawing.Size(120, 20);
            this.textBoxCompressionEnabled.TabIndex = 20;
            // 
            // textBoxECC
            // 
            this.textBoxECC.Location = new System.Drawing.Point(150, 142);
            this.textBoxECC.Name = "textBoxECC";
            this.textBoxECC.ReadOnly = true;
            this.textBoxECC.Size = new System.Drawing.Size(120, 20);
            this.textBoxECC.TabIndex = 21;
            // 
            // textBoxDataPadding
            // 
            this.textBoxDataPadding.Location = new System.Drawing.Point(150, 167);
            this.textBoxDataPadding.Name = "textBoxDataPadding";
            this.textBoxDataPadding.ReadOnly = true;
            this.textBoxDataPadding.Size = new System.Drawing.Size(120, 20);
            this.textBoxDataPadding.TabIndex = 22;
            // 
            // textBoxSetmarkReporting
            // 
            this.textBoxSetmarkReporting.Location = new System.Drawing.Point(150, 192);
            this.textBoxSetmarkReporting.Name = "textBoxSetmarkReporting";
            this.textBoxSetmarkReporting.ReadOnly = true;
            this.textBoxSetmarkReporting.Size = new System.Drawing.Size(120, 20);
            this.textBoxSetmarkReporting.TabIndex = 23;
            // 
            // textBoxVariableBS
            // 
            this.textBoxVariableBS.Location = new System.Drawing.Point(150, 217);
            this.textBoxVariableBS.Name = "textBoxVariableBS";
            this.textBoxVariableBS.ReadOnly = true;
            this.textBoxVariableBS.Size = new System.Drawing.Size(120, 20);
            this.textBoxVariableBS.TabIndex = 24;
            // 
            // textBoxDefaultBlockSize
            // 
            this.textBoxDefaultBlockSize.Location = new System.Drawing.Point(150, 242);
            this.textBoxDefaultBlockSize.Name = "textBoxDefaultBlockSize";
            this.textBoxDefaultBlockSize.ReadOnly = true;
            this.textBoxDefaultBlockSize.Size = new System.Drawing.Size(120, 20);
            this.textBoxDefaultBlockSize.TabIndex = 25;
            // 
            // textBoxMaximumBS
            // 
            this.textBoxMaximumBS.Location = new System.Drawing.Point(150, 267);
            this.textBoxMaximumBS.Name = "textBoxMaximumBS";
            this.textBoxMaximumBS.ReadOnly = true;
            this.textBoxMaximumBS.Size = new System.Drawing.Size(120, 20);
            this.textBoxMaximumBS.TabIndex = 26;
            // 
            // textBoxMinimumBS
            // 
            this.textBoxMinimumBS.Location = new System.Drawing.Point(150, 292);
            this.textBoxMinimumBS.Name = "textBoxMinimumBS";
            this.textBoxMinimumBS.ReadOnly = true;
            this.textBoxMinimumBS.Size = new System.Drawing.Size(120, 20);
            this.textBoxMinimumBS.TabIndex = 27;
            // 
            // textBoxMaximumPartCount
            // 
            this.textBoxMaximumPartCount.Location = new System.Drawing.Point(150, 317);
            this.textBoxMaximumPartCount.Name = "textBoxMaximumPartCount";
            this.textBoxMaximumPartCount.ReadOnly = true;
            this.textBoxMaximumPartCount.Size = new System.Drawing.Size(120, 20);
            this.textBoxMaximumPartCount.TabIndex = 28;
            // 
            // textBoxEOTSize
            // 
            this.textBoxEOTSize.Location = new System.Drawing.Point(150, 342);
            this.textBoxEOTSize.Name = "textBoxEOTSize";
            this.textBoxEOTSize.ReadOnly = true;
            this.textBoxEOTSize.Size = new System.Drawing.Size(120, 20);
            this.textBoxEOTSize.TabIndex = 29;
            // 
            // textBoxWriteProtected
            // 
            this.textBoxWriteProtected.Location = new System.Drawing.Point(100, 17);
            this.textBoxWriteProtected.Name = "textBoxWriteProtected";
            this.textBoxWriteProtected.ReadOnly = true;
            this.textBoxWriteProtected.Size = new System.Drawing.Size(120, 20);
            this.textBoxWriteProtected.TabIndex = 31;
            // 
            // textBoxBlockSizeTape
            // 
            this.textBoxBlockSizeTape.Location = new System.Drawing.Point(100, 42);
            this.textBoxBlockSizeTape.Name = "textBoxBlockSizeTape";
            this.textBoxBlockSizeTape.ReadOnly = true;
            this.textBoxBlockSizeTape.Size = new System.Drawing.Size(120, 20);
            this.textBoxBlockSizeTape.TabIndex = 32;
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(100, 67);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.ReadOnly = true;
            this.textBoxCapacity.Size = new System.Drawing.Size(120, 20);
            this.textBoxCapacity.TabIndex = 33;
            // 
            // textBoxRemaining
            // 
            this.textBoxRemaining.Location = new System.Drawing.Point(100, 92);
            this.textBoxRemaining.Name = "textBoxRemaining";
            this.textBoxRemaining.ReadOnly = true;
            this.textBoxRemaining.Size = new System.Drawing.Size(120, 20);
            this.textBoxRemaining.TabIndex = 34;
            // 
            // textBoxPartitionCount
            // 
            this.textBoxPartitionCount.Location = new System.Drawing.Point(100, 117);
            this.textBoxPartitionCount.Name = "textBoxPartitionCount";
            this.textBoxPartitionCount.ReadOnly = true;
            this.textBoxPartitionCount.Size = new System.Drawing.Size(120, 20);
            this.textBoxPartitionCount.TabIndex = 35;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(419, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // TapeParametersDlg
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(594, 408);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxTape);
            this.Controls.Add(this.groupBoxDrive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TapeParametersDlg";
            this.Text = "Parameters";
            this.groupBoxDrive.ResumeLayout(false);
            this.groupBoxDrive.PerformLayout();
            this.groupBoxTape.ResumeLayout(false);
            this.groupBoxTape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDrive;
        private System.Windows.Forms.GroupBox groupBoxTape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxDrive;
        private System.Windows.Forms.TextBox textBoxEOTSize;
        private System.Windows.Forms.TextBox textBoxMaximumPartCount;
        private System.Windows.Forms.TextBox textBoxMinimumBS;
        private System.Windows.Forms.TextBox textBoxMaximumBS;
        private System.Windows.Forms.TextBox textBoxDefaultBlockSize;
        private System.Windows.Forms.TextBox textBoxVariableBS;
        private System.Windows.Forms.TextBox textBoxSetmarkReporting;
        private System.Windows.Forms.TextBox textBoxDataPadding;
        private System.Windows.Forms.TextBox textBoxECC;
        private System.Windows.Forms.TextBox textBoxCompressionEnabled;
        private System.Windows.Forms.TextBox textBoxCompressionCapable;
        private System.Windows.Forms.TextBox textBoxMediaPresent;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.TextBox textBoxBlockSizeTape;
        private System.Windows.Forms.TextBox textBoxWriteProtected;
        private System.Windows.Forms.TextBox textBoxPartitionCount;
        private System.Windows.Forms.TextBox textBoxRemaining;
        private System.Windows.Forms.Button btnClose;


    }
}