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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btt_ejercicio1_Click(object sender, EventArgs e)
        {
            //Montramos pantalla ejercicio1

            Ejercicio1 Ejercicio1 = new Ejercicio1(); 
            Hide();
            Ejercicio1.Show();


        }

        private void btt_ejercicio2_Click(object sender, EventArgs e)
        {
            //Montramos pantalla ejercicio2

            Ejercicio2 Ejercicio2 = new Ejercicio2();
            Hide();
            Ejercicio2.Show();
        }

        private void btt_ejercicio3_Click(object sender, EventArgs e)
        {
            //Montramos pantalla ejercicio3

            Ejercicio3 Ejercicio3 = new Ejercicio3();
            Hide();
            Ejercicio3.Show();
        }

        private void btt_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
