using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bff.SharedObjects.Entities
{
    public class Encuesta
    {
        public string Id { get; set; } = "0";
        public string? Nombre { get; set; }
        public string? TipoEncuesta { get; set; }
    }
}
