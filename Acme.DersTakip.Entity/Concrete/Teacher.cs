using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<Instrument> Instruments { get; set; }
    }
}
