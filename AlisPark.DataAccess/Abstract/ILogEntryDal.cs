﻿using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.DataAccess.Abstract
{
    public interface ILogEntryDal : IEntityRepository<LogEntry>
    {
    }
}