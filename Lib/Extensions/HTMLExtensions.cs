using Lib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web;

namespace Lib.Extensions
{
    public static class HTMLExtensions
	{
        //Add Title as an attribute to the options in the select list
        public static MvcHtmlString EmployeeDropDown(this HtmlHelper htmlHelper)
        {
            List<EmployeeBenefitsView> items = EmployeeBenefitsView.Fetch();
            string selectListHtml = "";

            foreach (EmployeeBenefitsView item in items)
            {
                selectListHtml += string.Format(
                    "<option value='{0}'>{1} - {2}</option>",
                    item.Id,
                    item.FullName,
                    item.Id);
            }

            var html = string.Format("<select class='select-box medium' id='Employee' name='Employee' style='width:250px;'>{1}</select>", selectListHtml);
            return new MvcHtmlString(html);
        }
    }
}
