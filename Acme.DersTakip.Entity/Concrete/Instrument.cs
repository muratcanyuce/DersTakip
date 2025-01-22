using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Abstract;

namespace Acme.DersTakip.Entity.Concrete
{
    public class Instrument:IEntity
    {
        public string EnstrumanId { get; set; }
        public string EnstrumanAd { get; set; }
    }
}
