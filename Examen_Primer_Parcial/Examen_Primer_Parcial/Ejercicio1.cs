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
    public partial class Ejercicio1 : Form
    {
        void CalcularIntereses(double capital, double tasaInteres)
        {
            double interesMensual = 0;

            for (int i = 1; i <= 12; i++)
            {
                interesMensual = (capital * tasaInteres / 100) * 1;
                //Console.WriteLine("Interes para " + ObtenerMes(i - 1) + ":" + interesMensual);
                capital += interesMensual;
                lbx_datos.Items.Add(ObtenerMes(i - 1) + ": " + Math.Round(interesMensual, 2));

            }
        }

        // Funcion para buscar mes, recibe el indice a buscar
       private string ObtenerMes(int numeroMes)
        {
            string[] meses = {
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre",
            };
            return meses[numeroMes];

            //List<string> list = new List<string>();
            //list.Add("Enero");
            //list.Add("Febrero");
            //list.Add("Marzo");
            //list.Add("Abril");
            //list.Add("Mayo");
            //list.Add("Junio");
            //list.Add("Julio");
            //list.Add("Agosto");
            //list.Add("Septiembre");
            //list.Add("Octubre");
            //list.Add("Noviembre");
            //list.Add("Diciembre");

           // return list.ElementAt(numeroMes);
        }

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btt_Calcular_Click(object sender, EventArgs e)
        {
            CalcularIntereses(200000,1.50 );
        }

        private void btt_Menu_Click(object sender, EventArgs e)
        {
            menu menupantalla = new menu();
            Hide();
            menupantalla.Show();
        }
    }
}
