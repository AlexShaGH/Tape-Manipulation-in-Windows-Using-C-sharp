using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TapesAuxiliary
{
    /// <summary>
    /// Dialog for displaying tape drive and media parameters
    /// </summary>
    public partial class TapeParametersDlg : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tape"></param>
        public TapeParametersDlg(TapeWinAPI tape)
        {
            InitializeComponent();

            // Process drive and tape information
            try
            {
                textBoxDrive.Text = tape.TapeDriveName;

                int status = tape.GetTapeStatus();

                textBoxStatus.Text = status.ToString();

                if (status == TapeWinAPI.ERROR_NO_MEDIA_IN_DRIVE)
                {
                    textBoxMediaPresent.Text = "No";
                }
                else
                {
                    textBoxMediaPresent.Text = "Yes";
                    textBoxCapacity.Text = tape.Capacity.ToString();

                    textBoxBlockSizeTape.Text = tape.BlockSizeTape.ToString();

                    if (tape.IsWriteProtected)
                    {
                        textBoxWriteProtected.Text = "Yes";
                    }
                    else
                    {
                        textBoxWriteProtected.Text = "No";
                    }

                    textBoxPartitionCount.Text = tape.PartitionCountTape.ToString();

                    textBoxRemaining.Text = tape.Remaining.ToString();


                }
                
                textBoxEOTSize.Text = tape.EOTWarningZoneSize.ToString();

                textBoxMaximumPartCount.Text = tape.PartitionCountDriveMaximum.ToString();

                textBoxMinimumBS.Text = tape.MinimumBlockSizeDrive.ToString();

                textBoxMaximumBS.Text = tape.MaximumBlockSizeDrive.ToString();

                textBoxDefaultBlockSize.Text = tape.BlockSizeDrive.ToString();

                if (tape.IsVariableBlockCapable)
                {
                    textBoxVariableBS.Text = "Yes";
                }
                else
                {
                    textBoxVariableBS.Text = "No";
                }

                if (tape.ReportSetmarks)
                {
                    textBoxSetmarkReporting.Text = "Yes";
                }
                else
                {
                    textBoxSetmarkReporting.Text = "No";
                }

                if (tape.DataPadding)
                {
                    textBoxDataPadding.Text = "Yes";
                }
                else
                {
                    textBoxDataPadding.Text = "No";
                }

                if (tape.ECC)
                {
                    textBoxECC.Text = "Yes";
                }
                else
                {
                    textBoxECC.Text = "No";
                }

                if (tape.Compression)
                {
                    textBoxCompressionEnabled.Text = "Yes";
                }
                else
                {
                    textBoxCompressionEnabled.Text = "No";
                }

                if (tape.IsCompressionCapable)
                {
                    textBoxCompressionCapable.Text = "Yes";
                }
                else
                {
                    textBoxCompressionCapable.Text = "No";
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Can't get parameters", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }



        }
    }
}
