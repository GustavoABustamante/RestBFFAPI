using Bff.Infrastructure.Const;
using Bff.Infrastructure.Helper;
using Bff.SharedObjects;
using Bff.SharedObjects.DTO;
using Bff.SharedObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bff.Service.AsignacionEncuestaService
{
    public class AsignacionEncuestaService : IAsignacionEncuestaService
    {
        public async Task<List<AsignacionEncuesta>> GetAsignaciones()
        {
            string apiMethodDocentes = UrlConst.DOCENTES + "GetDocentes";
            var docenteTask = BffHelper.GetService<List<Docente>>(apiMethodDocentes); //docentes microservice

            string apiMethodEncuestas = UrlConst.ENCUESTAS + "GetEncuestas";
            var encuestaTask = BffHelper.GetService<List<Encuesta>>(apiMethodEncuestas); //encuestas microservice

            await Task.WhenAll(docenteTask, encuestaTask);

            List<AsignacionEncuesta> asignaciones = new List<AsignacionEncuesta>();
            int index = 1;

            foreach (var docente in docenteTask.Result)
            {
                var result = new AsignacionEncuesta
                {
                    Id = index,
                    Nombre = "Asignacion " + index,
                    Docente = docenteTask.Result[index - 1],
                    Encuesta = encuestaTask.Result[index - 1],
                };

                asignaciones.Add(result);
                index++;
            };

            return asignaciones;
        }

        public async Task<List<AsignacionEncuesta>> GetAsignacionesTest(int length)
        {
            string apiMethodDocentes = UrlConst.DOCENTES + "GetDocentes";
            var docenteTask = BffHelper.GetService<List<Docente>>(apiMethodDocentes); //docentes microservice

            string apiMethodEncuestas = UrlConst.ENCUESTAS + "GetEncuestas";
            var encuestaTask = BffHelper.GetService<List<Encuesta>>(apiMethodEncuestas); //encuestas microservice

            await Task.WhenAll(docenteTask, encuestaTask);

            List<AsignacionEncuesta> asignaciones = new List<AsignacionEncuesta>();
            //int index = 1;

            for (int i = 0; i < length; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(1, 11);
                var asignacionEncuestaObj = new AsignacionEncuesta()
                {
                    Id = Convert.ToInt32(i),
                    Nombre = "Asignacion " + i,
                    Docente = docenteTask.Result[index],
                    Encuesta = encuestaTask.Result[index]
                };

                asignaciones.Add(asignacionEncuestaObj);
            }

            return asignaciones;
        }
    }
}
