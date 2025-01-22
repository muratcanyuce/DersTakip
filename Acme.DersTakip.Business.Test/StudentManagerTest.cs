using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Business.Concrete;
using Acme.DersTakip.DataAccess.Concrete.EntityFramework;
using Acme.DersTakip.Entity.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.DersTakip.Business.Test
{
    [TestClass]
    public class StudentManagerTest
    {
        private StudentManager _studentManager;

        [TestInitialize]
        public void TestInit()
        {
            _studentManager = new StudentManager(new EfStudentDal());
        }

        [TestMethod]
        public void Student_Add_Is_Working()
        {
            var pretotalCount = _studentManager.GetAll().Count();
            var student = new Student
            {
                Name = "TestStudent",
                Surname = "TestStudent",
                Phone = "05561234567",
            };

            _studentManager.Add(student);

            var totalCount = _studentManager.GetAll().Count();

            Assert.IsTrue(totalCount > pretotalCount);
        }

    }
}
