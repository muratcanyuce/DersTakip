using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Business.Abstract;
using Acme.DersTakip.DataAccess.Abstract;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);

        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }
    }
}
