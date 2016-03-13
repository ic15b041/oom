using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    public class Tests
    {
        [Test]
        public void Employeewithfirstname()
        {
            var x = new HoferMitarbeiter("David", "Boisits", 1234, 2000);
            Assert.IsNotNull(x.firstname);
        }
        [Test]
        public void Employeewithlastname()
        {
            var x = new HoferMitarbeiter("David", "Boisits", 1234, 2000);
            Assert.IsNotNull(x.lastname);
        }
        [Test]
        public void Employeewithsvn()
        {
            var x = new HoferMitarbeiter("David", "Boisits", 1234, 2000);
            Assert.IsNotNull(x.svn);
        }
        [Test]
        public void Employeewithsalary()
        {
            var x = new HoferMitarbeiter("David", "Boisits", 1234, 2000);
            Assert.IsNotNull(x.salary);
        }


        [Test]
        public void CannotCreateEmployeeWithoutFirstname()
        {
            Assert.Catch(() =>
            {
                var x = new HoferMitarbeiter("", "Boisits", 1234, 2000);
            });
        }
        [Test]
        public void CannotCreateEmployeeWithoutLastname()
        {
            Assert.Catch(() =>
            {
                var x = new HoferMitarbeiter("David", "", 1234, 2000);
            });
        }
        [Test]
        public void CannotCreateEmployeeWithoutFourDigitSVN()
        {
            Assert.Catch(() =>
            {
                var x = new HoferMitarbeiter("David", "Boisits", 0, 2000);
                var y = new HoferMitarbeiter("David", "Boisits", 01, 2000);
                var z = new HoferMitarbeiter("David", "Boisits", 012, 2000);
            });
        }
        [Test]
        public void CreateEmployeeWithFourDigitSVN()
        {
            var x = new HoferMitarbeiter("David", "Boisits", 1234, 2000);
            Assert.IsTrue(x.svn.ToString().Length == 4);
        }
        [Test]
        public void CannotCreateEmployeeWithNegativeOrZeroSalary()
        {
            Assert.Catch(() =>
            {
                var x = new HoferMitarbeiter("David", "Boisits", 1234, -100);
                var y = new HoferMitarbeiter("David", "Boisits", 1235, 0);
            });
        }

    }
}
