using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Abstract;

namespace Acme.DersTakip.Entity.Concrete
{
    public class Instrument : IEntity
    {
        public Instrument()
        {
            Teachers = new HashSet<Teacher>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
