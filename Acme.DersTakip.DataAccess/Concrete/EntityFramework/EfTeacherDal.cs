using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.DataAccess.Abstract;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.DataAccess.Concrete.EntityFramework
{
    public class EfTeacherDal : EfEntityRepositoryBase<Teacher, DersTakipContext>, ITeacherDal
    {
        public void UpdateTeacherInstruments(int teacherId, int instrumentId)
        {
            using (DersTakipContext context = new DersTakipContext())
            {
                var teacher = context.Teachers.Find(teacherId);
                var instrument = context.Instruments.Find(instrumentId);
                teacher.Instruments.Add(instrument);
                context.SaveChanges();
            }
        }

        public List<Teacher> GetTeachersWithInstruments()
        {
            using (DersTakipContext context = new DersTakipContext())
            {
                return context.Teachers.Include("Instruments").ToList();
            }
        }
    }
}
