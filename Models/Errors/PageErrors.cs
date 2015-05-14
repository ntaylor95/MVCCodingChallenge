using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PageErrors
    {
        #region constructor

        public PageErrors()
        { }

        #endregion constructor

        #region properties

        public string ErrorMessage { get; set; }

        public Exception ExceptionErrorInfo { get; set; }

        public string PageTitle { get; set; }

        public long ClientEventId { get; set; }

        public string ClassName { get; set; }

        public string FunctionName { get; set; }

        public string Custom1 { get; set; } //used to store other custom information that might be used for the page error

        public string Custom2 { get; set; }

        public string Custom3 { get; set; }

        #endregion properties
    }
}
