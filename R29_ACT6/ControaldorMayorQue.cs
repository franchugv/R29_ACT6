using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R29_ACT6
{
    public static class ControaldorMayorQue
    {
        public static void ControllerMayorQue(int numero1, int numero2)
        {
            // Recursos
            bool esValido = LogicaNegocio.ValidarMayor(numero1, numero2);

            if (esValido) UIPrincipal.MostrarMensaje($"{numero1} es mayor que {numero2}", "Mayor que");
            if (!esValido) UIPrincipal.MostrarMensaje($"{numero1} es menor o igual que {numero2}", "Mayor que");


        }
    }
}
