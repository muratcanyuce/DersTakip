using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Abstract
{
    public interface ITeacherService
    {
        void Add(Teacher teacher);

        void Delete(Teacher teacher);

        List<Teacher> GetAll();

        void Update(Teacher teacher);

        List<Teacher> GetTeachersWithInstruments();

        Teacher Get(Expression<Func<Teacher, bool>> filter);

        void UpdateTeacherInstruments(int teacherId, int instrumentId);
    }
}
