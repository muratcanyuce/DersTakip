using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Abstract
{
    public interface IStudentService
    {
        void Add(Student student);

        List<Student> GetAll();
    }
}
