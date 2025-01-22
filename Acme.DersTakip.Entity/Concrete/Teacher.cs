using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Abstract;

namespace Acme.DersTakip.Entity.Concrete
{
    public class Teacher :IEntity
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherPhone { get; set; }
        public string TeacherEmail { get; set; }
    }
}
