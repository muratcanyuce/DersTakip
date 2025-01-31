using System;
using System.Collections.Generic;
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
    public class TeacherManager : ITeacherService
    {
        private ITeacherDal _teacherDal;

        public TeacherManager()
        {
            _teacherDal = new EfTeacherDal();
        }

        public void Add(Teacher teacher)
        {
            ValidationTool.Validate(new TeacherValidator(), teacher);
            _teacherDal.Add(teacher);

        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }

        public Teacher Get(Expression<Func<Teacher, bool>> filter)
        {
            return _teacherDal.Get(filter);
        }

        public List<Teacher> GetAll()
        {
            return _teacherDal.GetAll();
        }

        public List<Teacher> GetTeachersWithInstruments()
        {
            return _teacherDal.GetTeachersWithInstruments();
        }

        public void Update(Teacher teacher)
        {
            ValidationTool.Validate(new TeacherValidator(), teacher);
            _teacherDal.Update(teacher);
        }

        public void UpdateTeacherInstruments(int teacherId, int instrumentId)
        {
            _teacherDal.UpdateTeacherInstruments(teacherId, instrumentId);
        }
    }
}