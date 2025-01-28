using System;
using System.Linq;
using Acme.DersTakip.Business.Concrete;
using Acme.DersTakip.DataAccess.Concrete.EntityFramework;
using Acme.DersTakip.Entity.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.DersTakip.Business.Test
{
    [TestClass]
    public class InstrumentManagerTest
    {
        private InstrumentManager _instrumentManager;

        [TestInitialize]
        public void TestInit()
        {
            _instrumentManager = new InstrumentManager();
        }

        [TestMethod]
        public void Instrument_Add_Is_Working()
        {
            var pretotalCount = _instrumentManager.GetAll().Count();
            var instrument = new Instrument
            {
                Name = "TestInstrument",
            };

            _instrumentManager.Add(instrument);

            var totalCount = _instrumentManager.GetAll().Count();

            Assert.IsTrue(totalCount > pretotalCount);
        }

    }
}
