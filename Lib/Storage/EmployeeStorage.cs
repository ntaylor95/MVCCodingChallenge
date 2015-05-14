using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Storage
{
    public class EmployeeStorage
    {
        private List<Employee> _employees = new List<Employee>();
        
        #region constructor

        public EmployeeStorage()
        { 
            //dummy up data
            _employees.Add(new Employee() { FirstName = "John", LastName = "Doe", Id = 1 });
            _employees.Add(new Employee() { FirstName = "Jane", LastName = "Doe", Id = 2 });
            _employees.Add(new Employee() { FirstName = "My", LastName = "Name", Id = 3 });
            _employees.Add(new Employee() { FirstName = "Your", LastName = "Name", Id = 4 });
            _employees.Add(new Employee() { FirstName = "Augustus", LastName = "Gluup", Id = 5 });
            _employees.Add(new Employee() { FirstName = "Albert", LastName = "Einstein", Id = 6 });
        }

        #endregion constructor

        #region methods

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee Get(long id)
        {
            return _employees.Where(r => r.Id == id).FirstOrDefault();
        }

        public void Save(Employee item)
        {
            item.Id = _employees.Count() + 1;
            _employees.Add(item);
        }

        public void Delete(long id)
        {
            _employees.RemoveAt((int)id);
        }

        #endregion methods
    }
}
