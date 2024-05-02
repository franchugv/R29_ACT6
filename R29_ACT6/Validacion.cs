using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R29_ACT6
{
    public static class Validacion
    {
        public static int ValidarINT(string cadena)
        {
            // Recursos
            int Numero = 0;

            // Validación
            if (string.IsNullOrEmpty(cadena)) throw new ArgumentNullException("Cadena vacía");

            // Conversión
            Numero = Convert.ToInt32(cadena);

            return Numero;

        }
    }
}
