using Bff.Infrastructure.Const;
using Bff.Infrastructure.Helper;
using Bff.SharedObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bff.Service.EncuestaService
{
    public class EncuestaService : IEncuestaService
    {
        public async Task<List<Encuesta>> GetEncuestas()
        {
            string apiMethod = UrlConst.ENCUESTAS + "GetEncuestas";
            var encuestaResult = await BffHelper.GetService<List<Encuesta>>(apiMethod); //encuestas microservice

            return encuestaResult;
        }
    }
}
