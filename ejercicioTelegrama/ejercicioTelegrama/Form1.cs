using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o'; // Por defecto ordinario
            int numPalabras = 0;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text.Trim();

            // Determino si es urgente u ordinario
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
            {
                tipoTelegrama = 'o';
            }

            // Obtengo el número de palabras que forma el telegrama
            // Divido por espacios y filtro elementos vacíos
            if (!string.IsNullOrWhiteSpace(textoTelegrama))
            {
                numPalabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            // Calculo el coste según el tipo de telegrama
            if (tipoTelegrama == 'o') // Telegrama ordinario
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else // Telegrama urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            // Muestro el precio
            txtPrecio.Text = coste.ToString("F2") + " euros";
        }
    }
    }
    

