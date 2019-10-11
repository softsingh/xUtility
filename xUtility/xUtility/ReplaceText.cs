﻿using System;
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

            if(replaceTextOptions.docx == true)
            {
                if(replaceTextOptions.IncludeSubdirectories==true)
                    Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.docx", SearchOption.AllDirectories);
                else
                    Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.docx", SearchOption.TopDirectoryOnly);

                foreach (string MyFile in Files)
                {
                    try
                    {
                        using (WordprocessingDocument wdDoc = WordprocessingDocument.Open(MyFile, true))
                        {
                            using (StreamReader sr = new StreamReader(wdDoc.MainDocumentPart.GetStream()))
                            {
                                MyText = sr.ReadToEnd();
                            }
                            Regex Rx = new Regex(replaceTextOptions.FindWhat);
                            MyText = Rx.Replace(MyText, replaceTextOptions.ReplaceWith);

                            using (StreamWriter sw = new StreamWriter(wdDoc.MainDocumentPart.GetStream(FileMode.Create)))
                            {
                                sw.Write(MyText);
                            }
                        }
                    }
                    catch (Exception Ex)
                    {
                        throw new Exception(Ex.Message + Environment.NewLine + MyFile);
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
                    try
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

                        using (FileStream fs = new FileStream(MyFile, FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.Write(MyText);
                            }
                        }
                    }
                    catch (Exception Ex)
                    {
                        throw new Exception(Ex.Message + Environment.NewLine + MyFile);
                    }
                }
            }
        }
    }
}
