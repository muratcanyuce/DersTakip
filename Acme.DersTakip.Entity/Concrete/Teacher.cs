using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Abstract;

namespace Acme.DersTakip.Entity.Concrete
{
    public class Teacher : IEntity
    {
        public Teacher()
        {
            Instruments = new HashSet<Instrument>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<Instrument> Instruments { get; set; }
    }
}
