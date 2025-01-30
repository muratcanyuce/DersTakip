using Acme.DersTakip.Business.Concrete;
using Acme.DersTakip.DataAccess.Concrete.EntityFramework;
using Acme.DersTakip.Entity.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.DersTakip.Business.Test
{
    [TestClass]
    public class TeacherManagerTest
    {
        private TeacherManager _teacherManager;
        [TestInitialize]
        public void TestInit()
        {
            _teacherManager = new TeacherManager();
        }

        [TestMethod]
        public void Teacher_Add_Is_Working()
        {
            var pretotalCount = _teacherManager.GetAll().Count();
            var teacher = new Teacher
            {
                Name = "Test",
                Surname = "Test",
                Email = "test@test.com",
                Phone = "05551234567",
            };

            _teacherManager.Add(teacher);

            var totalCount = _teacherManager.GetAll().Count();

            Assert.IsTrue(totalCount > pretotalCount);
        }
    }
}
