using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace xUtility
{
    class ReplaceText
    {
        ReplaceTextOptions replaceTextOptions;

        public ReplaceText(ReplaceTextOptions rto)
        {
            replaceTextOptions = rto;
        }

        public void run()
        {
            string MyText;
            IEnumerable<string> Files = Directory.EnumerateFiles(replaceTextOptions.InputFolder, "*.docx", SearchOption.AllDirectories);

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
    }
}
