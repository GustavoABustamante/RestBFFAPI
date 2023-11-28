using Bff.SharedObjects.DTO;
using Bff.SharedObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bff.Service.AsignacionEncuestaService
{
    public interface IAsignacionEncuestaService
    {
        Task<List<AsignacionEncuesta>> GetAsignaciones();
        Task<List<AsignacionEncuesta>> GetAsignacionesTest(int length);
    }
}
