using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal class clsUtil
    {
        public static string GenerateGUID()
        {
            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            string FileName = sourceFile;
            FileInfo fi = new FileInfo(FileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;
        }
        public static bool CopyImageToProjectImageFolder(ref string sourceFile)
        {
            string DesrinationFolder = @"C:\Users\Abdo\source\repos\DVLD\People - Images";
            if(!CreateFolderIfDoesNotExist(DesrinationFolder))
            {
                return false;
            }

            string DestinationFile = DesrinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, DestinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            sourceFile = DestinationFile;
            return true;
        }

    }
}
