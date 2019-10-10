using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUtility
{
    class Options
    {
        public bool docx { get; set; }
        public bool xlsx { get; set; }
        public bool pptx { get; set; }
        public bool txt { get; set; }
        public bool html { get; set; }

        public bool IncludeSubdirectories { get; set; }

        public string InputFolder { get; set; }
        public string OutputFolder { get; set; }

        public Options() { }

        public Options(Options options)
        {
            docx = options.docx;
            xlsx = options.xlsx;
            pptx = options.pptx;
            txt = options.txt;
            html = options.html;

            IncludeSubdirectories = options.IncludeSubdirectories;

            InputFolder = options.InputFolder;
            OutputFolder = options.OutputFolder;
        }
    }
}
