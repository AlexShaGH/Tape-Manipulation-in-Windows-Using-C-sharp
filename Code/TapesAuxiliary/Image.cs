using System;
using System.IO;

namespace TapesAuxiliary
{
    /// <summary>
    /// Represents Image object consisting of map file and array of tape files
    /// </summary>
    class Image
    {
        #region Private variables

        /// <summary>
        /// Represents folder object
        /// </summary>
        private DirectoryInfo Folder = null;

        /// <summary>
        /// Represents map file
        /// </summary>
        private MediaLayoutMap MapFile = null;

        /// <summary>
        /// Holds all the tape files objects
        /// </summary>
        private FileInfo[] TapeFiles = null;

        /// <summary>
        /// Tracks tape files count
        /// </summary>
        private int FilesCount = 0;

        /// <summary>
        /// Holds currently opened file number
        /// </summary>
        private int CurrentFileNumber = 0;

        /// <summary>
        /// buffered stream associated with currently opened tape file
        /// </summary>
        private BufferedStream m_stream = null;

        #endregion

        #region Constructor
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="path"></param>
        public Image(string path)
        {
            //initialize members
            Folder = new DirectoryInfo(path);
            CurrentFileNumber = 0;

            if (Folder.Exists)
            {// opening existing map
                TapeFiles = Folder.GetFiles("*.dat");// retrieve array of tape file objects
                FilesCount = TapeFiles.Length;

                if (FilesCount != 0)
                {// sort files
                    Array.Sort<FileInfo>(TapeFiles, delegate(FileInfo x, FileInfo y)
                    {
                        return x.Name.CompareTo(y.Name);
                    });

                    // initialize stream
                    m_stream = new BufferedStream(TapeFiles[0].Open(FileMode.Open));

                }

            }
            else
            {// new map
                Folder.Create();

                FilesCount = 0;
            }

            // create map object
            MapFile = new MediaLayoutMap(Folder.FullName + "\\map.txt");
        }

        #endregion

        #region Public methods

        /// <summary>
        /// returns true if set of tape files and map are consistent
        /// Not implemented yet
        /// </summary>
        public bool CheckConsistency()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// switch FileStream to the next file
        /// </summary>
        /// <returns></returns>
        public bool SwitchToNextTF()
        {
            CloseFile();// close previously opened file

            CurrentFileNumber++;// increment number

            // check if still in a range
            if (CurrentFileNumber >= FilesCount) return false;

            // open it
            m_stream = new BufferedStream(TapeFiles[CurrentFileNumber].Open(FileMode.Open));

            return true;
        }

        /// <summary>
        /// Closes current tape file stream
        /// </summary>
        public void CloseFile()
        {
            if (m_stream != null)
            {
                m_stream.Flush();
                m_stream.Close();
            }

        }

        /// <summary>
        /// writes passed buffer into currently opened image file
        /// </summary>
        /// <param name="buffer"></param>
        public void WriteToCurrentTF(byte[] buffer)
        {
            m_stream.Write(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// writes passed buffer into currently opened image file
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="bytesCount"></param>
        public void WriteToCurrentTF(byte[] buffer, int bytesCount)
        {
            m_stream.Write(buffer, 0, bytesCount);

        }

        /// <summary>
        /// reads buffer from the currently opened image file
        /// returns read bytes count
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="bytesCount"></param>
        /// <returns></returns>
        public int ReadFromCurrentTF(byte[] buffer, int bytesCount)
        {
            return m_stream.Read(buffer, 0, bytesCount);

        }

        /// <summary>
        /// Adds Filemark record to the map file
        /// </summary>
        /// <returns></returns>
        public void ProcessFileMark(int count)
        {
            if (count == 0) throw new ApplicationException("filemark count = 0!");

            for (int i = 1; i <= count; i++)
            {
                MapFile.AddFilemarkRecord();
            }
        }

        /// <summary>
        /// Creates new file and switches stream pointer to it
        /// updates map file accordingly
        /// </summary>
        public void CreateNewTF()
        {
            // close previously opened stream
            CloseFile();

            CurrentFileNumber++;// increment number

            FilesCount++;// increment counter

            // make it bigger while preserving data
            Array.Resize(ref TapeFiles, FilesCount);

            // create file object
            TapeFiles[CurrentFileNumber - 1] =
                new FileInfo(Folder.FullName + "\\file" + (CurrentFileNumber - 1).ToString("X6") + ".dat");

            // associate stream
            m_stream = new BufferedStream(TapeFiles[CurrentFileNumber - 1].Create());

            if (m_stream == null)
            {
                throw new ApplicationException("Error on creating new file!");
            }

            // update map file
            MapFile.AddFileRecord(TapeFiles[CurrentFileNumber - 1].Name);

        }

        /// <summary>
        /// results in a new record in the map file for the current tape file
        /// </summary>
        /// <param name="offsetPBA"></param>
        /// <param name="blockSize"></param>
        public void UpdateBSInfo(long offsetPBA, int blockSize)
        {
            MapFile.AddBSRecord(offsetPBA, blockSize);
        }

        /// <summary>
        /// Should be called upon completion of imaging
        /// </summary>
        public void FinalyzeImage()
        {
            CloseFile();
            TapeFiles = null;
            MapFile.CloseMap();
            MapFile = null;
            Folder = null;
            FilesCount = 0;
            CurrentFileNumber = 0;
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
        public string GetNextMapRecord(out int type)
        {
            return MapFile.GetRecord(out type);
        }

        /// <summary>
        /// Parses Offset and BlockSize from the map file record
        /// </summary>
        /// <param name="recordBS"></param>
        /// <param name="offsetPBA"></param>
        /// <param name="blockSize"></param>
        public static void ParseBSRecord(string recordBS, out long offsetPBA, out int blockSize)
        {
            string[] split = recordBS.Split(new Char[] { ' ', ':' });

            offsetPBA = long.Parse(split[1]);
            blockSize = int.Parse(split[3]);

        }

        #endregion

        #region Public properties
        /// <summary>
        /// returns full path name
        /// </summary>
        public string path
        {
            get { return Folder.FullName; }

        }

        #endregion

    }
}
