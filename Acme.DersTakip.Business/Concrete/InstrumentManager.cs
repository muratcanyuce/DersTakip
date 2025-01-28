using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Business.Abstract;
using Acme.DersTakip.DataAccess.Abstract;
using Acme.DersTakip.DataAccess.Concrete.EntityFramework;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.Business.Concrete
{
    public class InstrumentManager : IInstrumentService
    {
        private IInstrumentDal _instrumentDal;

        public InstrumentManager()
        {
            _instrumentDal = new EfInstrumentDal();
        }

        public void Add(Instrument instrument)
        {
            _instrumentDal.Add(instrument);

        }

        public void Update(Instrument instrument)
        {
            _instrumentDal.Update(instrument);

        }

        public void Delete(Instrument instrument)
        {
            _instrumentDal.Delete(instrument);
        }

        public List<Instrument> GetAll()
        {
            return _instrumentDal.GetAll();
        }
        public List<Instrument> GetInstrumentByTeacher(string teacher)
        {
            return _instrumentDal.GetAll(p => p.Teachers.Any(t => t.Name == teacher));  
        }
    }
}
