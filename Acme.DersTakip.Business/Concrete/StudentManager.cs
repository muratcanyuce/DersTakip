using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Business.Abstract;
using Acme.DersTakip.Business.Utilities;
using Acme.DersTakip.Business.validationrules.FluentValidation;
using Acme.DersTakip.DataAccess.Abstract;
using Acme.DersTakip.DataAccess.Concrete.EntityFramework;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager()
        {
            _studentDal = new EfStudentDal();
        }

        public void Add(Student student)
        {
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Add(student);

        }
        public void Update(Student student)
        {
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Update(student);
        }
        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }
    }
}
