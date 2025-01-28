using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.DataAccess.Abstract;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.DataAccess.Concrete.EntityFramework
{
    public class EfInstrumentDal :EfEntityRepositoryBase <Instrument, DersTakipContext>, IInstrumentDal
    {

    }
}
