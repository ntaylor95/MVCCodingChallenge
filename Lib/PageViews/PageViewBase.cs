using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.PageViews
{
    public abstract class PageViewBase : ApplicationPageView
    {
        #region constructor

        public PageViewBase() : base()
        { }

        #endregion constructor

        #region properties

        public string PageTitle { get; set; }

        public List<PageErrors> PageErrors { get; set; }

        #endregion properties
    }
}
