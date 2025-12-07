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
            // 1. Tomar texto de la caja
            string texto = txtTelegrama.Text;

            // 2. Contar palabras básico
            int palabras = 0;
            if (texto.Length > 0)
            {
                palabras = 1; // Al menos una palabra

                for (int i = 0; i < texto.Length; i++)
                {
                    if (texto[i] == ' ' && i + 1 < texto.Length && texto[i + 1] != ' ')
                    {
                        palabras++;
                    }
                }
            }

            // 3. Ver si es urgente
            double precio;

            if (chkUrgente.Checked == true) // URGENTE
            {
                if (palabras <= 10)
                {
                    precio = 5.0;
                }
                else
                {
                    precio = 5.0 + (palabras - 10) * 0.75;
                }
            }
            else // ORDINARIO
            {
                if (palabras <= 10)
                {
                    precio = 2.5;
                }
                else
                {
                    precio = 2.5 + (palabras - 10) * 0.5;
                }
            }

            // 4. Mostrar precio
            txtPrecio.Text = precio.ToString("N2") + " euros";
        }
    }
    }
    

