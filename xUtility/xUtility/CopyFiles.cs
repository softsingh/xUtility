using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUtility
{
    class CopyFiles
    {
        /// <summary>
        /// Copy Files and Directories recursively from Source to Destination with Filters specified in CopyFileOptions
        /// </summary>
        /// <param name="copyFilesOptions">All copy file options</param>
        /// <returns>void</returns>
        public void Run(CopyFilesOptions copyFilesOptions)
        {
            if (copyFilesOptions.docx == false && 
                copyFilesOptions.xlsx == false && 
                copyFilesOptions.pptx == false && 
                copyFilesOptions.html == false && 
                copyFilesOptions.txt == false)
            {
                return;
            }

            if (copyFilesOptions.InputFolder == copyFilesOptions.OutputFolder)
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(copyFilesOptions.OutputFolder) == false)
            {
                Directory.CreateDirectory(copyFilesOptions.OutputFolder);
            }

            IEnumerable<string> Files = null;

            if (copyFilesOptions.docx == true)
            {
                Files = Directory.EnumerateFiles(copyFilesOptions.InputFolder, "*.docx", SearchOption.TopDirectoryOnly);
            }

            if (copyFilesOptions.xlsx == true)
            {
                Files.Concat(Directory.EnumerateFiles(copyFilesOptions.InputFolder, "*.xlsx", SearchOption.TopDirectoryOnly));
            }

            if (copyFilesOptions.pptx == true)
            {
                Files.Concat(Directory.EnumerateFiles(copyFilesOptions.InputFolder, "*.pptx", SearchOption.TopDirectoryOnly));
            }

            if (copyFilesOptions.html == true)
            {
                Files.Concat(Directory.EnumerateFiles(copyFilesOptions.InputFolder, "*.html", SearchOption.TopDirectoryOnly));
            }

            if (copyFilesOptions.txt == true)
            {
                Files.Concat(Directory.EnumerateFiles(copyFilesOptions.InputFolder, "*.txt", SearchOption.TopDirectoryOnly));
            }

            // Copy each file into it's new directory.
            foreach (string MyFile in Files)
            {
                FileInfo fi = new FileInfo(MyFile);
                fi.CopyTo(Path.Combine(copyFilesOptions.OutputFolder, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            //if (copyFilesOptions.IncludeSubdirectories == true)
            //{
            //    foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            //    {
            //        DirectoryInfo nextTargetSubDir =
            //            target.CreateSubdirectory(diSourceSubDir.Name);
            //        CopyAll(diSourceSubDir, nextTargetSubDir);
            //    }
            //}
                
        }
    }
}
