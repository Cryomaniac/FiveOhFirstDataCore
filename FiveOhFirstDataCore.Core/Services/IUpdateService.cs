﻿using FiveOhFirstDataCore.Core.Structures.Updates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveOhFirstDataCore.Core.Services
{
    public interface IUpdateService
    {
        public Task<List<UpdateBase>> GetRosterUpdatesAsync();
    }
}