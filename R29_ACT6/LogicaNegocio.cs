using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R29_ACT6
{
    public static class LogicaNegocio
    {
        public static bool ValidarMayor(int numero1, int numero2)
        {
            bool esValido = true;

            if (numero1 > numero2) esValido = true;
            else esValido = false;

            return esValido;
        }
    }
}
