using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Business.Abstract;
using Acme.DersTakip.DataAccess.Abstract;
using Acme.DersTakip.DataAccess.Concrete.EntityFramework;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Concrete
{
    public class ScheduleManager : IScheduleService
    {
        private IScheduleDal _scheduleDal;
        public ScheduleManager()
        {
            _scheduleDal = new EfScheduleDal();
        }

        public void Add(Schedule schedule)
        {
            _scheduleDal.Add(schedule);
        }

        public List<Schedule> GetAll()
        {
            return _scheduleDal.GetAll();
        }

        public void Update(Schedule schedule)
        {
           _scheduleDal.Update(schedule);
        }
        public void Delete(Schedule schedule)
        {
            _scheduleDal.Delete(schedule);
        }

        public List<Schedule> GetSchedulesFull()
        {
            return _scheduleDal.GetSchedulesFull();
        }
    }
}
