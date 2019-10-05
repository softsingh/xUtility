using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUtility
{
    class ReplaceTextOptions
    {
        public bool docx;
        public bool xlsx;
        public bool pptx;
        public bool txt;
        public bool html;

        public bool SameAsInputFolder;

        public string InputFolder;
        public string OutputFolder;

        public string FindWhat;
        public string ReplaceWith;
    }
}
