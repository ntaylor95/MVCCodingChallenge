using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.ModelViews;
using System.Collections.Generic;
using Lib.Storage;
using Models;

namespace NicoleFun.Tests.ModelViews
{
    [TestClass]
    public class EmployeeViewTest
    {
        [TestMethod]
        public void GetAll()
        {
            List<EmployeeBenefitsView> employees = EmployeeBenefitsView.Fetch();

            Assert.AreEqual(employees.Count, 6);
        }

        [TestMethod]
        public void Get()
        {
            Employee employee1 = EmployeeBenefitsView.Fetch(3).Model;
            Employee employee2 = new EmployeeStorage().Get(3);

            Assert.AreEqual(employee1.FullName, employee2.FullName);
        }

        [TestMethod]
        public void GetEmpty()
        {
            EmployeeBenefitsView employee1 = EmployeeBenefitsView.Fetch(33);
            Assert.IsNull(employee1.Model);
        }
    }
}
