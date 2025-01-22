using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Abstract;

namespace Acme.DersTakip.Entity.Concrete
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string ParentPhone { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
