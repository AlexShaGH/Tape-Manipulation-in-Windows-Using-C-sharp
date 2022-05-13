using System;
using System.IO;

namespace TapesAuxiliary
{
    /// <summary>
    /// Envelopes map file for Image class
    /// </summary>
    class MediaLayoutMap
    {
        #region Private variables
        /// <summary>
        /// represents map file
        /// </summary>
        private FileInfo MapFile = null;

        /// <summary>
        /// write stream
        /// </summary>
        private StreamWriter writer = null;

        /// <summary>
        /// read stream
        /// </summary>
        private StreamReader reader = null;

        #endregion

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public MediaLayoutMap()
            : this(new FileInfo("map.txt"))
        {
        }

        /// <summary>
        /// Constructor with the name parameter
        /// </summary>
        /// <param name="mapFileNamePassed"></param>
        public MediaLayoutMap(String mapFileNamePassed)
            : this(new FileInfo(mapFileNamePassed))
        {
        }

        /// <summary>
        /// constructor with FileInfo parameter
        /// </summary>
        /// <param name="mapFilePassed"></param>
        public MediaLayoutMap(FileInfo mapFileInfoPassed)
        {
            MapFile = mapFileInfoPassed;

            if (MapFile.Exists)
            {// open existing map as read only text
                reader = MapFile.OpenText();
            }
            else
            {// new text file to write to
                writer = MapFile.CreateText();
                writer.AutoFlush = true;
            }

        }

        #endregion

        #region Public methods

		/// <summary>
        /// Closes map file
        /// </summary>
        public void CloseMap()
        {
            if (writer!=null)
            {
                writer.Close();
            } 
            else if (reader!=null)
            {
                reader.Close();
            }
            MapFile = null;
        }


        /// <summary>
        /// adds block size record to the map file
        /// </summary>
        /// <param name="OffsetPBA"></param>
        /// <param name="BlockSize"></param>
        public void AddBSRecord(long OffsetPBA, int BlockSize)
        {
            if (writer != null)
            {
                writer.WriteLine("OfsPBA:{0} BSize:{1}", OffsetPBA, BlockSize);
            }
            else
            {
                throw new ApplicationException("Write Stream is null!");
            }
        }

        /// <summary>
        /// Adds file record for the map file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public void AddFileRecord(string fileName)
        {
            if (writer != null)
            {
            	writer.WriteLine("filename=" + fileName);
            } 
            else
            {
                throw new ApplicationException("Write Stream is null!");
            }
        }

        /// <summary>
        /// Adds filemark record to the map file
        /// </summary>
        public void AddFilemarkRecord()
        {
            if (writer != null)
            {
            	writer.WriteLine("filemark");
            } 
            else
            {
                throw new ApplicationException("Write Stream is null!");
            }
        }

        /// <summary>
        /// returns meaningful record from the map file or null if EOF
        /// </summary>
        /// <param name="recordType">
        /// 0 = EOF; 
        /// 1 = file record;
        /// 2 = Block Size record
        /// 3 = filemark record
        /// 4 = undefined (exception)
        /// </param>
        /// <returns></returns>
        public string GetRecord(out int type)
        {
            string returnString = null;

            type = 0;

            if (reader != null)
            {
	            do
	            {
	                returnString = reader.ReadLine();
	
	            } while (returnString != null && returnString.StartsWith(";"));
	
	            if (returnString != null)
	            {
	                switch (returnString.Substring(0, 7))
	                {
	                    case "filenam":
	                        type = 1;
	                        break;
	                    case "OfsPBA:":
	                        type = 2;
	                        break;
	                    case "filemar":
	                        type = 3;
	                        break;
	                    default:
	                        type = 4;
	                        break;
	                }
	            }
	
	            return returnString;
            }
            else
            {
                throw new ApplicationException("Read Stream is null!");
            }
        }

	    #endregion   
    }
}
