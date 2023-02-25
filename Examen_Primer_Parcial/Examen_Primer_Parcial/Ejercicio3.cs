using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Primer_Parcial
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {

            InitializeComponent();
        }

        private void Multiplos(string nombre, string apellido)
        {
            for (int i = 1; i <= 100; i++)
            {
                ltb_datos.Items.Add(i);
                if (i % 3 == 0)
                {
                    //  multiplo de '3'
                    //Console.WriteLine();
                    ltb_datos.Items.Add(nombre);
                }
                if (i % 5 == 0)
                {
                    // El numero es multiplo de 5
                    ltb_datos.Items.Add(apellido);
                }
                if (i % 3 == 0 & i % 5 == 0)
                {
                    //Console.WriteLine(nombre + " " + apellido);
                    ltb_datos.Items.Add(nombre + " " + apellido);
                }

            }
        }

        private void btt_mostrar_Click(object sender, EventArgs e)
        {
            Multiplos("Jonathan", "Sanchez");
        }

        private void bttn_menu_Click(object sender, EventArgs e)
        {
            menu menupantalla = new menu();
            Hide();
            menupantalla.Show();
        }
    }
}
