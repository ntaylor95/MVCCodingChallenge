using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Storage
{
    public class DependentStorage
    {
    
        private List<Dependent> _dependents = new List<Dependent>();
        
        #region constructor

        public DependentStorage()
        { 
            //dummy up data
            _dependents.Add(new Dependent() { FirstName = "Veruca", LastName = "Salt", Id = 1, EmployeeId = 1 });
            _dependents.Add(new Dependent() { FirstName = "Baby Jane", LastName = "Doe", Id = 2, EmployeeId = 2 });
            _dependents.Add(new Dependent() { FirstName = "My", LastName = "Name", Id = 3, EmployeeId = 2 });
            _dependents.Add(new Dependent() { FirstName = "Augustus", LastName = "Gluup III", Id = 4, EmployeeId = 5 });
        }

        #endregion constructor

        #region methods

        public IEnumerable<Dependent> GetAll()
        {
            return _dependents;
        }

        
        public IEnumerable<Dependent> GetAll(long employeeId)
        {
            return _dependents.Where(r=>r.EmployeeId == employeeId);
        }

        public Dependent Get(long id)
        {
            return _dependents.Where(r => r.Id == id).FirstOrDefault();
        }

        public void Save(Dependent item)
        {
            item.Id = _dependents.Count() + 1;
            _dependents.Add(item);
        }

        public void Delete(long id)
        {
            _dependents.RemoveAt((int)id);
        }

        #endregion methods
    }
}
