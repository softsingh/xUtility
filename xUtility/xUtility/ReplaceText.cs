using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using DocumentFormat.OpenXml;

namespace xUtility
{
    class ReplaceText
    {
        ReplaceTextOptions replaceTextOptions;

        public ReplaceText(ReplaceTextOptions rto)
        {
            replaceTextOptions = rto;
        }

        /// <summary>
        /// Performs the Replace Text operation on .docx, .xlsx, .pptx, .txt and .html files
        /// </summary>
        /// <returns>void</returns>
        public void Run()
        {
            string MyText;
            IEnumerable<string> Files;

            //Create Directories

            if(replaceTextOptions.docx == true)
            {
                if(replaceTextOptions.IncludeSubdirectories==true)
                    Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.docx", SearchOption.AllDirectories);
                else
                    Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.docx", SearchOption.TopDirectoryOnly);

                foreach (string MyFile in Files)
                {
                    using (WordprocessingDocument wdDoc = WordprocessingDocument.Open(MyFile, true))
                    {
                        using (StreamReader sr = new StreamReader(wdDoc.MainDocumentPart.GetStream()))
                        {
                            MyText = sr.ReadToEnd();
                        }
                    }

                    Regex Rx = new Regex(replaceTextOptions.FindWhat);
                    MyText = Rx.Replace(MyText, replaceTextOptions.ReplaceWith);

                    FileInfo NewPath = new FileInfo(MyFile.Replace(replaceTextOptions.InputFolder, replaceTextOptions.OutputFolder));

                    if (!Directory.Exists(NewPath.DirectoryName))
                    {
                        Directory.CreateDirectory(NewPath.DirectoryName);
                    }

                    using (WordprocessingDocument wdDoc = WordprocessingDocument.Create(NewPath.FullName, WordprocessingDocumentType.Document))
                    {
                        wdDoc.AddMainDocumentPart();

                        using (StreamWriter sw = new StreamWriter(wdDoc.MainDocumentPart.GetStream()))
                        {
                            sw.Write(MyText);
                        }
                    }
                }
            }

            if (replaceTextOptions.txt == true || replaceTextOptions.html == true)
            {
                if (replaceTextOptions.IncludeSubdirectories == true)
                    Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.txt", SearchOption.AllDirectories)
                    .Concat(Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.html", SearchOption.AllDirectories));
                else
                    Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.txt", SearchOption.TopDirectoryOnly)
                    .Concat(Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.html", SearchOption.TopDirectoryOnly));

                foreach (string MyFile in Files)
                {
                    using (FileStream fs = new FileStream(MyFile, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            MyText = sr.ReadToEnd();
                        }
                    }

                    Regex Rx = new Regex(replaceTextOptions.FindWhat);
                    MyText = Rx.Replace(MyText, replaceTextOptions.ReplaceWith);

                    FileInfo NewPath = new FileInfo(MyFile.Replace(replaceTextOptions.InputFolder, replaceTextOptions.OutputFolder));

                    if (!Directory.Exists(NewPath.DirectoryName))
                    {
                        Directory.CreateDirectory(NewPath.DirectoryName);
                    }

                    using (FileStream fs = new FileStream(NewPath.DirectoryName, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.Write(MyText);
                        }
                    }
                }
            }
        }
    }
}
