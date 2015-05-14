using Lib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.PageViews
{
    public class EmployeeBenefitsPageView : PageViewBase
    {
        #region constructor

        public EmployeeBenefitsPageView() : base()
        {
            PageTitle = "Employee Benefits";
            Employees = EmployeeBenefitsView.Fetch();
        }

        #endregion constructor

        #region properties

        public List<EmployeeBenefitsView> Employees { get; set; }

        #endregion properties
    }
}
