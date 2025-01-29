using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Abstract
{
    public interface IScheduleService
    {
        List<Schedule> GetAll();
        void Add(Schedule schedule);
        void Update(Schedule schedule);
        void Delete(Schedule schedule);
        List<Schedule> GetSchedulesFull();
    }
}
