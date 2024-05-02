using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R29_ACT6
{
    public static class UIPrincipal
    {
        public static void MostrarMensaje(string cadena, string cabecera)
        {
            MessageBox.Show(cadena, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarError(string cadena) 
        {
            MessageBox.Show($"Error: {cadena}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
