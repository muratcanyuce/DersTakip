using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Abstract;

namespace Acme.DersTakip.Entity.Concrete
{
    public class TeacherInstrument :IEntity
    {
        public int TeacherId { get; set; }
        public int InstrumentId { get; set; }
    }
}
