using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.PageViews
{
    public abstract class ApplicationPageView
    {
        #region constructor

        public ApplicationPageView()
        { }

        #endregion constructor

        #region properties

        public int MajorVersion { get; set; }

        public double MinorVersion { get; set; }

        public string BaseViewPath { get; set; }

        #endregion properties
    }
}
