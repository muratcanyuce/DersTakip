using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Business.Abstract;
using Acme.DersTakip.DataAccess.Abstract;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Concrete
{
    public class InstrumentManager : IInstrumentService
    {
        private IInstrumentDal _instrumentDal;

        public InstrumentManager(IInstrumentDal instrumentDal)
        {
            _instrumentDal = instrumentDal;
        }

        public void Add(Instrument instrument)
        {
            _instrumentDal.Add(instrument);

        }

        public List<Instrument> GetAll()
        {
            return _instrumentDal.GetAll();
        }
    }
}
