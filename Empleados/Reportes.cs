using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class Reportes
    {
        string nombrEmpleado;
        int mes;
        decimal sueldoMensual;

        public string NombrEmpleado { get => nombrEmpleado; set => nombrEmpleado = value; }
        public int Mes { get => mes; set => mes = value; }
        public decimal SueldoMensual { get => sueldoMensual; set => sueldoMensual = value; }
    }
}
