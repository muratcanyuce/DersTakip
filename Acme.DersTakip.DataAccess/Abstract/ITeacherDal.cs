﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.DataAccess.Abstract
{
    public interface ITeacherDal : IEntityRepository<Teacher>
    {
        List<Teacher> GetTeachersWithInstruments();
        void UpdateTeacherInstruments(int teacherId, int instrumentId);
    }
}
