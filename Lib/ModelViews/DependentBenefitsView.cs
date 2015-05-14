using Lib.Storage;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.ModelViews
{
    public class DependentBenefitsView : ModelViewBase<Dependent>
    {
        public const double DEPENDENT_COST = 500.00;
        public const double DEPENDENT_DISCOUNT = .10;
        
        #region constructor

        public DependentBenefitsView()
            : base()
        {
        }

        public DependentBenefitsView(Dependent model)
            : base(model)
        {
            if (model != null)
            {
                double discount = ((model.FirstName.Substring(0,1) == "A") || (model.LastName.Substring(0,1) == "A")) ? 1.00 - DEPENDENT_DISCOUNT : 1.00;
                DependentBenefitsCost = DEPENDENT_COST * discount;
            }
        }

        #endregion constructor

        #region properties

        public double DependentBenefitsCost { get; set; }

        public string DependentBenefitsCostString
        {
            get
            {
                return String.Format("{0:C}", DependentBenefitsCost);
            }
        }

        #endregion properties

        #region methods

        public static List<DependentBenefitsView> FetchByEmployeeId(long employeeId)
        {
            //TODO: Typically will cache this result set
            List<DependentBenefitsView> items = new List<DependentBenefitsView>();

            //foreach employee returned from storage, dummying this data up here
            DependentStorage dependents = new DependentStorage();
            foreach (Dependent dependent in dependents.GetAll(employeeId))
            {
                items.Add(new DependentBenefitsView(dependent));
            }

            return items;
        }

        public static DependentBenefitsView Fetch(long id)
        {
            DependentStorage dependent = new DependentStorage();
            return new DependentBenefitsView(dependent.Get(id));
        }

        #endregion methods
    }
}
