using Lib.Storage;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.ModelViews
{
    public class EmployeeBenefitsView : ModelViewBase<Employee>
    {
        public const double EMPLOYEE_COST = 1000.00;
        public const double EMPLOYEE_DISCOUNT = .10;
        public const int PAYCHECKS_IN_YEAR = 26;
        
        #region constructor

        public EmployeeBenefitsView() 
            :base()
        {
        }

        public EmployeeBenefitsView(Employee model)
            :base(model)
        {
            if (model != null)
            {
                Dependents = DependentBenefitsView.FetchByEmployeeId(model.Id);
                YearlySalary = model.Salary * PAYCHECKS_IN_YEAR;

                double discount = ((model.FirstName.Substring(0,1) == "A") || (model.LastName.Substring(0,1) == "A")) ? 1.00 - EMPLOYEE_DISCOUNT : 1.00;
                EmployeeBenefitsCost = EMPLOYEE_COST * discount;

                TotalBenefitsCost = EmployeeBenefitsCost;
                foreach(DependentBenefitsView dependent in Dependents)
                {
                    TotalBenefitsCost += dependent.DependentBenefitsCost;
                }
            }
        }

        #endregion constructor

        #region properties

        public List<DependentBenefitsView> Dependents { get; set; }

        public double YearlySalary { get; set; }

        public double EmployeeBenefitsCost { get; set; }

        public string YearlySalaryString
        {
            get
            {
                return String.Format("{0:C}", YearlySalary);
            }
        }

        public string EmployeeBenefitsCostString
        {
            get
            {
                return String.Format("{0:C}", EmployeeBenefitsCost);
            }
        }

        public double TotalBenefitsCost { get; set; }

        public string TotalBenefitsCostString
        {
            get
            {
                return String.Format("{0:C}", TotalBenefitsCost);
            }
        }

        #endregion properties

        #region methods

        public static List<EmployeeBenefitsView> Fetch()
        {
            //TODO: Typically will cache this result set
            List<EmployeeBenefitsView> items = new List<EmployeeBenefitsView>();

            //foreach employee returned from storage, dummying this data up here
            EmployeeStorage employees = new EmployeeStorage();
            foreach (Employee employee in employees.GetAll())
            {
                items.Add(new EmployeeBenefitsView(employee));
            }

            return items;
        }

        public static EmployeeBenefitsView Fetch(long id)
        {
            EmployeeStorage employees = new EmployeeStorage();
            return new EmployeeBenefitsView(employees.Get(id));
        }

        #endregion methods
    }
}
