using Bff.SharedObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bff.Service.EncuestaService
{
    public interface IEncuestaService
    {
        Task<List<Encuesta>> GetEncuestas();
    }
}
