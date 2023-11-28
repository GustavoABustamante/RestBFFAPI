using Bff.Infrastructure.Const;
using Bff.Infrastructure.Helper;
using Bff.SharedObjects;
using Bff.SharedObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bff.Service.DocenteService
{
    public class DocenteService : IDocenteService
    {

        public async Task<List<Docente>> GetDocentes()
        {
            string apiMethod = UrlConst.DOCENTES + "GetDocentes";
            var docenteResult = await BffHelper.GetService<List<Docente>>(apiMethod); //docentes microservice

            return docenteResult;
        }
    }
}
