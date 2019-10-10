using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUtility
{
    class ReplaceTextOptions: Options
    {
        public bool SameAsInputFolder { get; set; }
        public string FindWhat { get; set; }
        public string ReplaceWith { get; set; }

        public ReplaceTextOptions() : base()
        {
        }

        public ReplaceTextOptions(Options options) : base(options)
        {
        }

        public ReplaceTextOptions(ReplaceTextOptions RTO) : base(RTO)
        {
            SameAsInputFolder = RTO.SameAsInputFolder;
            FindWhat = RTO.FindWhat;
            ReplaceWith = RTO.ReplaceWith;
        }
    }
}
