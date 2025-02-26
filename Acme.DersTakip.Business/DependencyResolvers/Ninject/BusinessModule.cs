using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Business.Abstract;
using Acme.DersTakip.Business.Concrete;
using Acme.DersTakip.DataAccess.Abstract;
using Acme.DersTakip.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Acme.DersTakip.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();
            Bind<ITeacherService>().To<TeacherManager>().InSingletonScope();
            Bind<ITeacherDal>().To<EfTeacherDal>().InSingletonScope();
            Bind<IInstrumentService>().To<InstrumentManager>().InSingletonScope();
            Bind<IInstrumentDal>().To<EfInstrumentDal>().InSingletonScope();
            Bind<IScheduleService>().To<ScheduleManager>().InSingletonScope();
            Bind<IScheduleDal>().To<EfScheduleDal>().InSingletonScope();
        }
    }
}
