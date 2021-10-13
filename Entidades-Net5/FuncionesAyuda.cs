using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public static class FuncionesAyuda
    {
        public static string FormatearMinAHoras(int cantMinutos)
        {
            int horas = cantMinutos / 60;
            int minutos = cantMinutos % 60;

            return FormatearTiempo(horas) + ":" + FormatearTiempo(minutos);
        }

        private static string FormatearTiempo(int tiempo)
        {
            if (10 > tiempo)
                return "0" + tiempo.ToString();

            return tiempo.ToString();
        }
    }
}
