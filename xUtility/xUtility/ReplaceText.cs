using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

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
                Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.docx", SearchOption.AllDirectories);

                foreach (string MyFile in Files)
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
            }

            if (replaceTextOptions.txt == true || replaceTextOptions.html == true)
            {
                Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.txt", SearchOption.AllDirectories)
                    .Concat(Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.html", SearchOption.AllDirectories));

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

                    using (FileStream fs = new FileStream(MyFile, FileMode.Create))
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
