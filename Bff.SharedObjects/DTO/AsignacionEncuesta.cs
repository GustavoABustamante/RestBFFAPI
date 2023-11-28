using Bff.SharedObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bff.SharedObjects.DTO
{
    public class AsignacionEncuesta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Docente Docente { get; set; }
        public Encuesta Encuesta { get; set; }
    }
}
