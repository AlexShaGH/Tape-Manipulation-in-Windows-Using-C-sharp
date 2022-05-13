using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TapesAuxiliary
{
    /// <summary>
    /// Main Application window
    /// </summary>
    public partial class MainWindow : Form
    {
        public string m_SelectedPath;// current folder

        /// <summary>
        /// structure to pass from Thread to update GUI
        /// </summary>
        struct reportProgressArguments 
        {
            public ulong bytes;// processed bytes
            public double speed;// estimated speed
            public ProgressBarStyle style;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="bytesProcessed"></param>
            /// <param name="CurrentSpeed"></param>
            /// <param name="currentStyle"></param>
            public reportProgressArguments(ulong bytesProcessed,double CurrentSpeed, ProgressBarStyle currentStyle)
            {
                bytes = bytesProcessed;
                speed = CurrentSpeed;
                style = currentStyle;

            }
        }
    
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // extra initialization - custom
            this.comboBoxOperation.SelectedIndex = 0;
            this.comboBoxSelectedFolder.Text =
                this.folderBrowserDialog.SelectedPath;
            this.btnStop.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// updates GUI upon Operation selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch (this.comboBoxOperation.SelectedIndex)
           {
           	case 0:// Image
                PrepareImageForm();
           		break;
           	case 1:// Write
                PrepareWriteForm();
           		break;
           	case 2:// Duplicate
                PrepareDuplicateForm();
           		break;
            default:
                RecoverDefaultForm();
           		break;
           }
            
        
        }

        /// <summary>
        /// Select folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
           if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
           {
               this.comboBoxSelectedFolder.Text = folderBrowserDialog.SelectedPath;
           }
        }

        /// <summary>
        /// Helper method
        /// </summary>
        public void PrepareImageForm()
        {
            pictureBox1.Show();
            lblDrive1.Show();
            comboBoxTapeDrive1.Show();

            pictureBox2.Hide();
            lblDrive2.Hide();
            comboBoxTapeDrive2.Hide();

            pictureBox3.Show();
            lblFolder.Text = "Destination Folder:";
            lblFolder.Show();
            btnSelectFolder.Show();
            comboBoxSelectedFolder.Show();

        }

        /// <summary>
        /// Helper method
        /// </summary>
        public void PrepareWriteForm()
        {
            pictureBox1.Hide();
            lblDrive1.Hide();
            comboBoxTapeDrive1.Hide();

            pictureBox2.Show();
            lblDrive2.Show();
            comboBoxTapeDrive2.Show();

            pictureBox3.Show();
            lblFolder.Text = "Source Folder:";
            lblFolder.Show();
            btnSelectFolder.Show();
            comboBoxSelectedFolder.Show();

        }

        /// <summary>
        /// Helper method
        /// </summary>
        public void PrepareDuplicateForm()
        {
            pictureBox1.Show();
            lblDrive1.Show();
            comboBoxTapeDrive1.Show();

            pictureBox2.Show();
            lblDrive2.Show();
            comboBoxTapeDrive2.Show();

            pictureBox3.Hide();
            lblFolder.Hide();
            btnSelectFolder.Hide();
            comboBoxSelectedFolder.Hide();

        }

        /// <summary>
        /// Helper method
        /// </summary>
        public void RecoverDefaultForm()
        {
            pictureBox1.Show();
            lblDrive1.Show();
            comboBoxTapeDrive1.Show();

            pictureBox2.Show();
            lblDrive2.Show();
            comboBoxTapeDrive2.Show();

            pictureBox3.Show();
            lblFolder.Text = "Image Folder:";
            lblFolder.Show();
            btnSelectFolder.Show();
            comboBoxSelectedFolder.Show();
        }

        /// <summary>
        /// Start selected operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            switch (this.comboBoxOperation.SelectedIndex)
            {
                case 0:// Image
                    DoImage();
                    break;
                case 1:// Write
                    DoWrite();
                    break;
                case 2:// Duplicate
                    DoDuplicate();
                    break;
                default:
                    RecoverDefaultForm();
                    break;
            }
        }

        /// <summary>
        /// Cancel long operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            LongTapeOperationBackgroundWorker.CancelAsync();
        }

        /// <summary>
        /// Invoke About Box dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox dlgAboutBox = new AboutBox();
            dlgAboutBox.ShowDialog();
        }

        /// <summary>
        /// Helper method - updates GUI
        /// </summary>
        private void ButtonsInProcess()
        {
            this.btnStop.Enabled = true;
            this.btnStart.Enabled = false;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        /// <summary>
        /// Helper method - updates GUI
        /// </summary>
        private void ButtonsProcessEnded()
        {
            this.btnStop.Enabled = false;
            this.btnStart.Enabled = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
        }

        /// <summary>
        /// Image tape
        /// </summary>
        public void DoImage()
        {
            ButtonsInProcess();

            uint returnCode = 0;


            //Check TapeDrive Selection:
            if (this.comboBoxTapeDrive1.SelectedIndex == -1)
            {
                MessageBox.Show("Select source device!","No source selected",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ButtonsProcessEnded();
                return;
            }

            //Construct and Open device
            TapeWinAPI sourceTape = new TapeWinAPI();

            toolStripStatusLabel1.Text = "Opening Device";
            if (!sourceTape.Open((uint)this.comboBoxTapeDrive1.SelectedIndex))
            {
                DisplayError("Can't open device", (uint)Marshal.GetLastWin32Error());
                ButtonsProcessEnded();
                return;
            }

            //Prepare device
            toolStripStatusLabel1.Text = "Loading Tape";
            if (!sourceTape.Load(ref returnCode))
            {
                DisplayError("Error on loading tape", returnCode);
                sourceTape.Close();
                ButtonsProcessEnded();
                return;
            }
            
            //Set tape position to 0
            toolStripStatusLabel1.Text = "Rewind";
            if (!sourceTape.Rewind(ref returnCode))
            {
                DisplayError("Error on rewinding tape", returnCode);
                ButtonsProcessEnded();
                return;
            }

            // set block size to 0 - variable size
            toolStripStatusLabel1.Text = "Set variable block size";
            if (sourceTape.IsVariableBlockCapable)
            {
                sourceTape.BlockSizeTape = 0;
            }
            else
            {
                MessageBox.Show("Unable to use variable block size", "Block Size Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ButtonsProcessEnded();
                return;
            }

            //Construct Image
            Image tapeImage = new Image(this.comboBoxSelectedFolder.Text);

            
            // prepare arguments for BackgroundWorker
            object[] arguments = new object[] { sourceTape, tapeImage };

            // span BackgroundWorker
            LongTapeOperationBackgroundWorker.RunWorkerAsync(arguments);

        }

        /// <summary>
        /// Helper method
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="returnCode"></param>
        private static void DisplayError(string caption, uint returnCode)
        {
            MessageBox.Show(String.Format("Error code: {0}\n", returnCode) + new Win32Exception((int)returnCode).Message, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Write to tape
        /// Not implemented yet
        /// </summary>
        public void DoWrite()
        {
            ButtonsInProcess();
            MessageBox.Show("Write functionality is not implemented yet");
            ButtonsProcessEnded();

        }

        /// <summary>
        /// Write from tape to tape
        /// Not implemented
        /// </summary>
        public void DoDuplicate()
        {
            ButtonsInProcess();
            MessageBox.Show("Duplicate functionality is not implemented yet");
            ButtonsProcessEnded();
        }

        /// <summary>
        /// Thread that runs Imaging operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LongTapeOperationBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //retrieve arguments - tape and image
            object[] arguments = (object[])e.Argument;
            TapeWinAPI sourceTape = (TapeWinAPI)arguments[0];
            Image tapeImage = (Image)arguments[1];

            //Create error.log file
            StreamWriter errorLog = new FileInfo(tapeImage.path + "\\error.log").CreateText();

            errorLog.AutoFlush = true;

            errorLog.WriteLine("Imaging started at : " + DateTime.Now.ToString());

            // for updating GUI...
            reportProgressArguments progressArguments = new reportProgressArguments(0,0,0);
            string returnStatus = "finished";

            uint returnCode = 0;
            uint bytesReturned = 0;
            uint blockSizeTrailing = 0;

            ulong globalBytesRead = 0;
            ulong prevGlobalBytesRead = 0; // helper for calculating speed

            uint globalPBA = 0;
            uint currentPBAOffset = 0;// inside current tape file

            double speed = 0;

            long ticks1 = 0;
            long ticks2 = 0;
            long updateGUIinterval = 10000000; // arrange it on 1 Sec boundary - set value to 10000000

            bool IsNeedNewImageFile = true;

            //Allocate memory
            byte[] Buffer1 = new byte[sourceTape.BlockSizeDrive];
            byte[] Buffer2 = new byte[sourceTape.BlockSizeDrive];

            byte[] dataBuffer = Buffer1;// pointer for switching between buffers...

            bool IsContinueImaging = true;

            //Image
            // *************************************************************
            while (IsContinueImaging)
            {
                // Cancel?
                if(LongTapeOperationBackgroundWorker.CancellationPending) 
                {
                    e.Cancel = true;
                    returnStatus = "canceled";
                    break;
                }

                if (!sourceTape.Read(ref dataBuffer, (uint)dataBuffer.Length, ref bytesReturned, ref returnCode))
                {//something went wrong, let's parse the return code

                    switch (returnCode)
                    {
                        case 0234:  //more data is available

                            //update error log and status
                            returnStatus = "aborted due to SCSI Controller problem";

                            IsContinueImaging = false;
                            break;
                        case 1106:  //incorrect block size

                            //update error log and status
                            returnStatus = "aborted due to invalid block size";

                            IsContinueImaging = false;
                            break;
                        case 1101:  //reached file mark

                            blockSizeTrailing = 0;
                            currentPBAOffset++;
                            globalPBA++;

                            //update error log and status
                            LongTapeOperationBackgroundWorker.ReportProgress(5, "File mark detected");
                            errorLog.WriteLine("PBA " + globalPBA.ToString() + ": File mark detected");

                            //update Image
                            tapeImage.ProcessFileMark(1);

                            IsNeedNewImageFile = true;

                            break;
                        case 1104:  //EOD reached

                            //update error log and status
                            errorLog.WriteLine("PBA " + globalPBA.ToString() + ": EOD detected");

                            IsContinueImaging = false;
                            break;
                        case 1100:  //EOT reached

                            //update error log and status
                            errorLog.WriteLine("PBA " + globalPBA.ToString() + ": EOT detected");

                            IsContinueImaging = false;
                            break;
                        default:    //any other errors

                            //update error log and status
                            returnStatus = "aborted with error code: " + returnCode.ToString();

                            IsContinueImaging = false;
                            break;
                    }
                }
                else
                {//perfectly OK read

                    //Create new destination file?
                    if (IsNeedNewImageFile)
                    {
                        tapeImage.CreateNewTF();
                        IsNeedNewImageFile = false;
                        currentPBAOffset = 0;
                    }

                    if (blockSizeTrailing != bytesReturned)
                    {
                        tapeImage.UpdateBSInfo(currentPBAOffset, (int)bytesReturned);
                        blockSizeTrailing = bytesReturned;
                    }
                }

                // 
                if (bytesReturned > 0)
                {
                    // increment global bytes read and PBAs
                    globalBytesRead = globalBytesRead + bytesReturned;
                    currentPBAOffset++;
                    globalPBA++;

                    //save data
                    tapeImage.WriteToCurrentTF(dataBuffer, (int)bytesReturned);
                }

                //current tick
                ticks2 = DateTime.Now.Ticks;

                //time to update status bar?
                if (((ticks2 - ticks1) > updateGUIinterval) && CanRaiseEvents)
                {
                    //calculate speed
                    speed = ((globalBytesRead - prevGlobalBytesRead) * 10000000 )/ (ulong)((ticks2 - ticks1) * 1024);

                    // update GUI
                    progressArguments.bytes = globalBytesRead;
                    progressArguments.speed = speed;
                    LongTapeOperationBackgroundWorker.ReportProgress(2, progressArguments);

                    //reset temp values
                    ticks1 = ticks2;
                    prevGlobalBytesRead = globalBytesRead;
                }

                //switch buffers...
                if (dataBuffer == Buffer1)
                {
                    dataBuffer = Buffer2;
                }
                else
                {
                    dataBuffer = Buffer1;
                }

            }
            //**************************************************************

            //Finalize image
            tapeImage.FinalyzeImage();
            tapeImage = null;

            //Deallocate memory
            Buffer1 = null;
            Buffer2 = null;
            dataBuffer = null;

            //Rewind tape
            LongTapeOperationBackgroundWorker.ReportProgress(5, "Rewinding");
            sourceTape.Rewind(ref returnCode);

            //Close Device
            sourceTape.Close();
            sourceTape = null;

            // update status
            LongTapeOperationBackgroundWorker.ReportProgress(5, returnStatus);

            //Flush and close error.log
            errorLog.WriteLine("Imaging " + returnStatus + " at: " + DateTime.Now.ToString());
            errorLog.Close();
        }

        /// <summary>
        /// Thread complete event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LongTapeOperationBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            ButtonsProcessEnded();

        }

        /// <summary>
        /// Thread reports progress to main window through this method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LongTapeOperationBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is reportProgressArguments)
            {
                reportProgressArguments arguments = (reportProgressArguments)e.UserState;

                switch (e.ProgressPercentage)
                {
                    case 0://toolStripStatusLabel1 with bytes
                        toolStripStatusLabel1.Text = "Imaging: " + arguments.bytes.ToString() + " Bytes read";
                        break;
                    case 1://toolStripStatusLabel2 with speed
                        toolStripStatusLabel2.Text = arguments.speed.ToString() + " KB/Sec";
                        break;
                    case 2://toolStripStatusLabel1 and toolStripStatusLabel2 with bytes and speed
                        toolStripStatusLabel1.Text = "Imaging: " + arguments.bytes.ToString() + " Bytes read";
                        toolStripStatusLabel2.Text = arguments.speed.ToString() + " KB/Sec";
                        break;
                    case 3://toolStripProgressBar1 with style
                        toolStripProgressBar1.Style = arguments.style;
                        break;
                    case 4://all components with bytes, speed and style
                        toolStripStatusLabel1.Text = "Imaging: " + arguments.bytes.ToString() + " Bytes read";
                        toolStripStatusLabel2.Text = arguments.speed.ToString() + " KB/Sec";
                        toolStripProgressBar1.Style = arguments.style;
                        break;
                }
            }
            else
            {
                switch (e.ProgressPercentage)
                {
                    case 5://toolStripStatusLabel1 with custom string
                        toolStripStatusLabel1.Text = (string)e.UserState;
                        break;
                    case 6://toolStripStatusLabel2 with custom string
                        toolStripStatusLabel2.Text = (string)e.UserState;
                        break;
                }
            }
        }

        /// <summary>
        /// Updates GUI upon command selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCommandTools_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxCommandTools.SelectedIndex)
            {
                case 8://Seek or Space
                    lblMethod.Show();
                    comboBoxMethodTools.Show();
                    //lblCountOrNumber.Show();
                    //textBoxCountOrNumber.Show();
                    break;
                case 7://Write filemarks
                    lblCountOrNumber.Show();
                    textBoxCountOrNumber.Show();
                    break;
                default:// all other commands
                    lblMethod.Hide();
                    comboBoxMethodTools.Hide();
                    lblCountOrNumber.Hide();
                    textBoxCountOrNumber.Hide();
                    break;
            }
        }

        /// <summary>
        /// Updates GUI upon method selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMethodTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMethodTools.SelectedIndex)
            {
                case 0://Seek to BOD
                    lblCountOrNumber.Hide();
                    textBoxCountOrNumber.Hide();
                    break;
                case 1://Seek to EOD
                    lblCountOrNumber.Hide();
                    textBoxCountOrNumber.Hide();
                    break;
                default:// all other methods
                    lblCountOrNumber.Show();
                    textBoxCountOrNumber.Show();
                    break;
            }


        }

        /// <summary>
        /// Processes selected command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecuteTools_Click(object sender, EventArgs e)
        {

            btnExecuteTools.Enabled = false;

            uint returnCode = 0;

            long countOrNumberFromDialog = 0;

            //Check TapeDrive Selection:
            if (this.comboBoxTapeTools.SelectedIndex == -1)
            {
                MessageBox.Show("Select tape drive!", "No devices selected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnExecuteTools.Enabled = true;
                return;
            }

            //Construct and Open device
            TapeWinAPI tape = new TapeWinAPI();

            toolStripStatusLabel1.Text = "Opening Device";
            if (!tape.Open((uint)this.comboBoxTapeTools.SelectedIndex))
            {
                DisplayError("Can't open device", (uint)Marshal.GetLastWin32Error());
                btnExecuteTools.Enabled = true;
                return;
            }

            switch (this.comboBoxCommandTools.SelectedIndex)
            {
                case 0:// Load
                    toolStripStatusLabel1.Text = "Loading tape";
                    
                    if (!tape.Load(ref returnCode))
                    {
                        // process error here
                    }
                    break;

                case 1:// Unload
                    toolStripStatusLabel1.Text = "Unloading tape";
                    
                    if (!tape.Unload(ref returnCode))
                    {
                        // process error here
                    }
                    break;

                case 2:// Rewind
                    toolStripStatusLabel1.Text = "Rewinding tape";
                    
                    if (!tape.Rewind(ref returnCode))
                    {
                        // process error here
                    }
                    break;

                case 3:// Erase
                    toolStripStatusLabel1.Text = "Erasing tape";
                    
                    if (!tape.Erase(TapeWinAPI.TAPE_DRIVE_ERASE_SHORT,ref returnCode))
                    {
                        // process error here
                    }
                    break;

                case 4:// Format
                    toolStripStatusLabel1.Text = "Formating tape";
                    
                    if (!tape.FormatTape(ref returnCode))
                    {
                        // process error here
                    }
                    break;

                case 5:// Detect parameters

                    TapeParametersDlg dlg = new TapeParametersDlg(tape);
                    dlg.ShowDialog();
                    break;

                case 6:// Set parameters
                    MessageBox.Show("Set Parameters functionality is not implemented yet");
                    break;

                case 7:// Write filemarks
                    
                    try
                    {
                        countOrNumberFromDialog = long.Parse(textBoxCountOrNumber.Text);
                    }
                    catch (System.Exception longParse)
                    {
                        MessageBox.Show("Re-type correct amount", "Incorrect argument",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    toolStripStatusLabel1.Text = "Writing filemarks";
                        

                    if (!tape.WriteTapemark((uint)countOrNumberFromDialog, TapeWinAPI.TAPE_FILEMARKS, ref returnCode))
                    {
                        // process error here
                    }

                    break;

                case 8:// Seek or Space
                    switch (comboBoxMethodTools.SelectedIndex)
                    {

                        case 0://	Seek to BOD
                            toolStripStatusLabel1.Text = "Rewinding";
                            
                            if (!tape.Rewind(ref returnCode))
                            {
                                // process error here
                            }
                            break;

                        case 1://	Seek to EOD
                            toolStripStatusLabel1.Text = "Seeking to EOD";
                            
                            if (!tape.SeekToEOD(ref returnCode))
                            {
                                // process error here
                            }
                            break;

                        case 2://	Seek to absolute block #
                            try
                            {
                            	countOrNumberFromDialog = long.Parse(textBoxCountOrNumber.Text);
                            }
                            catch (System.Exception longParse)
                            {
                                MessageBox.Show("Re-type correct block number", "Incorrect argument",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                            toolStripStatusLabel1.Text = "Seeking to absolute block #: " 
                                + countOrNumberFromDialog.ToString();
                            
                            if (!tape.SeekToAbsoluteBlock(countOrNumberFromDialog, ref returnCode))
                            {
                                // process error here
                            }

                            break;

                        case 3://	Seek to logical block #
                            try
                            {
                                countOrNumberFromDialog = long.Parse(textBoxCountOrNumber.Text);
                            }
                            catch (System.Exception longParse)
                            {
                                MessageBox.Show("Re-type correct block number", "Incorrect argument",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                            toolStripStatusLabel1.Text = "Seeking to logical block #: "
                                + countOrNumberFromDialog.ToString();
                            
                            if (!tape.SeekToLogicalBlock(countOrNumberFromDialog, ref returnCode))
                            {
                                // process error here
                            }
                            break;

                        case 4://	Space # of blocks
                            try
                            {
                                countOrNumberFromDialog = long.Parse(textBoxCountOrNumber.Text);
                            }
                            catch (System.Exception longParse)
                            {
                                MessageBox.Show("Re-type correct amount of blocks", "Incorrect argument",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                            toolStripStatusLabel1.Text = "Skipping blocks "
                                + countOrNumberFromDialog.ToString();

                            if (!tape.SpaceBlocks(countOrNumberFromDialog, ref returnCode))
                            {
                                // process error here
                            }
                            break;

                        case 5://	space # of filemarks
                            try
                            {
                                countOrNumberFromDialog = long.Parse(textBoxCountOrNumber.Text);
                            }
                            catch (System.Exception longParse)
                            {
                                MessageBox.Show("Re-type correct amount of filemarks", "Incorrect argument",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                            toolStripStatusLabel1.Text = "Skipping filemarks "
                                + countOrNumberFromDialog.ToString();

                            if (!tape.SpaceFileMarks(countOrNumberFromDialog, ref returnCode))
                            {
                                // process error here
                            }
                            break;

                        default:// not in the list
                            MessageBox.Show("Select method!", "No method specified",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;

                    }

                    break;
                default:// not in the list
                    MessageBox.Show("Select Command!", "No command specified", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
            tape.Close();
            btnExecuteTools.Enabled = true;

        }
    }
}
