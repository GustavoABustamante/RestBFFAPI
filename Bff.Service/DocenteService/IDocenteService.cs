﻿using Bff.SharedObjects;
using Bff.SharedObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bff.Service.DocenteService
{
    public interface IDocenteService
    {
        Task<List<Docente>> GetDocentes();
    }
}
