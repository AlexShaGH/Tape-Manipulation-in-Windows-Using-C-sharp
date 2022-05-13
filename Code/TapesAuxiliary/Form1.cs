using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace TapesAuxiliary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TapeWinAPI myTape = new TapeWinAPI();
            uint returnCode = 0;
            uint byetsRead = 0;
            byte [] myBuffer = new byte[256*65536];
            uint blockSize = 65536;
            for (int i = 0; i < 256;i++ )
            {
                for (int j = 0; j < 65536;j++ )
                {
                    myBuffer[i * 65536 + j] = (byte)i;
                }
            }


            myTape.Open(0);
            myTape.Load(ref returnCode);
            myTape.Rewind(ref returnCode);



            for (int i = 1; i <= 4;i++ )
            {
                myTape.BlockSizeTape = (int)(Math.Pow(2,(double)(i-1)) * blockSize);
                myTape.Write(ref myBuffer, 256 * blockSize, ref byetsRead, ref returnCode);
                Thread.Sleep(1000);
                myTape.WriteTapemark((uint) i, 1, ref returnCode);
                Thread.Sleep(1000);
            }


            this.button1.Text = returnCode.ToString();
            this.label1.Text =  TapeWinAPI.ConvertErrCode(returnCode);

            myTape.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TapeWinAPI myTape = new TapeWinAPI();
            uint returnCode = 0;
            myTape.Open(0);
            myTape.Load(ref returnCode);
            myTape.Rewind(ref returnCode);
            myTape.Erase(0, ref returnCode);
            myTape.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TapeWinAPI myTape = new TapeWinAPI();
            uint returnCode = 0;
            
            myTape.Open((uint)this.numericUpDown1.Value);
            myTape.Load(ref returnCode);

            this.labelTapeCapacity2.Text = myTape.Capacity.ToString();
            this.labelTapeRemaining2.Text = myTape.Remaining.ToString();
            this.labelTapeBlockSize2.Text = myTape.BlockSizeTape.ToString();
            this.labelTapePartitionCount2.Text = myTape.PartitionCountTape.ToString();
            this.labelTapeWriteProtect2.Text = myTape.IsWriteProtected.ToString();

            this.labelDriveECC2.Text = myTape.ECC.ToString();
            this.labelDriveCompression2.Text = myTape.Compression.ToString();
            this.labelDataPadding2.Text = myTape.DataPadding.ToString();
            this.labelReportSetMarks2.Text = myTape.ReportSetmarks.ToString();

            this.labelDefaultBlockSize2.Text = myTape.BlockSizeDrive.ToString();
            this.labelMaximumBlockSize2.Text = myTape.MaximumBlockSizeDrive.ToString();
            this.labelMinimumBlockSize2.Text = myTape.MinimumBlockSizeDrive.ToString();

            this.labelDrivePartitionCount2.Text = myTape.PartitionCountDriveMaximum.ToString();

            this.labelFeaturesLow2.Text = myTape.FeaturesLowDrive.ToString();
            this.labelFeaturesHigh2.Text = myTape.FeaturesHighDrive.ToString();

            this.labelEOT2.Text = myTape.EOTWarningZoneSize.ToString();

            this.labelCompressionCapable2.Text = myTape.IsCompressionCapable.ToString();
            this.labelVariableBlockCapable2.Text = myTape.IsVariableBlockCapable.ToString();

//            myTape.Rewind(ref returnCode);

//            myTape.BlockSizeTape = 65536;
//            myTape.SetBlockSize(16384, ref returnCode);
//            this.button1.Text = TapeWinAPI.ConvertErrCode(returnCode);
//            this.label1.Text = myTape.BlockSizeTape.ToString();
//            myTape.BlockSizeTape = 0;
//            this.label1.Text = myTape.BlockSizeTape.ToString();
//            this.label2.Text = myTape.BlockSizeDrive.ToString();

            myTape.Close();

        }

        private void buttonSetToFalse_Click(object sender, EventArgs e)
        {
            TapeWinAPI myTape = new TapeWinAPI();
            uint returnCode = 0;

            myTape.Open((uint)this.numericUpDown1.Value);
            myTape.Load(ref returnCode);

            myTape.ECC = false;
            myTape.Compression = false;
            myTape.DataPadding = false;
            myTape.ReportSetmarks = false;

            myTape.Close();

        }

        private void buttonSetToTrue_Click(object sender, EventArgs e)
        {
            TapeWinAPI myTape = new TapeWinAPI();
            uint returnCode = 0;

            myTape.Open((uint)this.numericUpDown1.Value);
            myTape.Load(ref returnCode);

            myTape.ECC = true;
            myTape.Compression = true;
            myTape.DataPadding = true;
            myTape.ReportSetmarks = true;

            myTape.Close();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FileInfo mapFile = new FileInfo("map2.txt");
            MediaLayoutMap map = new MediaLayoutMap(mapFile);
//            ApplicationException e = new ApplicationException();
            try
            {
	            map.AddFilemarkRecord();
	            map.AddFileRecord("file1.dat");
	            map.AddBSRecord(0, 65536);
	            map.AddFilemarkRecord();
            }
            catch (ApplicationException ex1)
            {
                MessageBox.Show(ex1.Message);
            }

            int type = 0;

            string tmp = null;

            try
            {
	            do 
	            {
	                tmp = map.GetRecord(out type);
	                MessageBox.Show(tmp + " " + type.ToString());
	            } while (tmp!=null);
	 
            }
            catch (System.Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);

            Image tapeImage = new Image(dir.FullName);

            byte[] myBuffer = new byte[65536];

            for (int i = 0; i <= 255;i++)
            {
                for (int j = 0; j < 65536; j++)
                    {
                        myBuffer[j] = (byte)i;
                    }

                tapeImage.CreateNewTF();
                tapeImage.UpdateBSInfo(0, 65536);
                tapeImage.WriteToCurrentTF(myBuffer);
                tapeImage.ProcessFileMark(1);


            }

            tapeImage.FinalyzeImage();
            


            

        }

    }
}
