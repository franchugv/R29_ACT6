using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R29_ACT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos
            Button boton = (Button)sender;
            string mensajeError = "";
            int num1 = Validacion.ValidarINT(textBoxEntrada.Text);
            int num2 = Validacion.ValidarINT(textBoxEntrada2.Text);


            // Reset a TRUE
            bool esValido = true;


            try
            {
                switch (boton.Name)
                {
                    case "BotonEvaluar":
                        ControaldorMayorQue.ControllerMayorQue(num1, num2);
                        break;
                }
            }
            catch (Exception Error)
            {
                esValido = false;
                mensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) UIPrincipal.MostrarError(mensajeError);
            }

        }

        private void TextBox_Validacion_Leave(object sender, EventArgs e)
        {
            // Recursos
            TextBox TexBox = (TextBox)sender;
            string mensajeError = "";
            // Reset a TRUE
            bool esValido = true;

            try
            {
                switch (TexBox.Name)
                {
                    case "textBoxEntrada":
                        Validacion.ValidarINT(textBoxEntrada.Text);
                        break;
                    case "textBoxEntrada2":
                        Validacion.ValidarINT(textBoxEntrada2.Text);
                        break;
                }
            }
            catch (Exception Error)
            {
                esValido = false;
                mensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) 
                {
                    UIPrincipal.MostrarError(mensajeError);
                    TexBox.Focus();
                }
            }

        }
    }
}
