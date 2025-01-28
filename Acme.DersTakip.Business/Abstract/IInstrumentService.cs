using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Abstract
{
    public interface IInstrumentService
    {
        void Add(Instrument instrument);
        void Update(Instrument instrument);
        void Delete(Instrument instrument);

        List<Instrument> GetAll();
    }
}
