﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Repositories
{
    public interface IPropertyRepository
    {
        IQueryable<Models.PropertyViewModel> All { get; }
    }
}
