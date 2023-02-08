using adminlte.TASEstudianteService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace adminlte.Classes
{
    public class TASEstudianteHelper
    {
        public static string TASEstudianteObtenerNombreEstudiante(string EstudianteCI, string strAKASubCompania, string strAKASesion)
        {
            string NombreEstudiante = string.Empty;

            TASEstudianteInterfaceClient TASEstudiante = new TASEstudianteInterfaceClient();
            List<TASEstudianteEntity> ltTASEstudiante = TASEstudiante.WebTASEstudianteSeleccionar(strAKASubCompania, EstudianteCI, strAKASesion, strAKASubCompania);
            foreach (var item in ltTASEstudiante)
            {
                NombreEstudiante = item.Nombre1 + " " + item.Nombre2 + " " + item.Apellido1 + " " + item.Apellido2;
            }

            return NombreEstudiante;

        }
    }
}