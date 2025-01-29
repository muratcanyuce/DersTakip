using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.DataAccess.Concrete.EntityFramework;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.DataAccess.Abstract
{
    public interface IScheduleDal : IEntityRepository<Schedule>
    {
        List<Schedule> GetSchedulesFull();

    }
}
