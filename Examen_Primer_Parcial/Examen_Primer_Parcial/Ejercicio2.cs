using System;

using System.Windows.Forms;

namespace Examen_Primer_Parcial
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btt_nuevo_Click(object sender, EventArgs e)
        {
            double cant, prec,total;
            cant = double.Parse(txtb_cantidad1.Text);
            prec = double.Parse(txtb_precio1.Text);
            total = (cant * prec);

           
            dataGridView1.Rows.Add(txt_descripcion1.Text, txtb_precio1.Text, txtb_cantidad1.Text, total);
            txt_descripcion1.Clear();
            txtb_precio1.Clear();
            txtb_cantidad1.Clear();

           

        }

        private void btt_calcular_Click(object sender, EventArgs e)
        {

            Calcularfactura();
        }

        private async void Calcularfactura()
        {
            double des, subtotal = 0;
            foreach(DataGridViewRow row  in dataGridView1.Rows)
            {
                subtotal += double.Parse(row.Cells[3].Value.ToString());
            }
            txtb_total.Text = subtotal.ToString();
            des = (subtotal * 0.15);
            txtb_descuento.Text = des.ToString();


            txtb_totalpagar.Text = (subtotal - des).ToString();


        }

        private void btt_menu_Click(object sender, EventArgs e)
        {
            menu menupantalla = new menu();
            Hide();
            menupantalla.Show();
        }
    }
}
