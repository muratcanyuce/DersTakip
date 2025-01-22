using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Abstract;

namespace Acme.DersTakip.Entity.Concrete
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentPhone { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string ParentPhone { get; set; }
    }
}
