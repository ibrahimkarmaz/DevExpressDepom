﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlandService:IGenericService<Bland>
    {
        bool GetByBlandName(Expression<Func<Bland, bool>> filter = null);
    }
}