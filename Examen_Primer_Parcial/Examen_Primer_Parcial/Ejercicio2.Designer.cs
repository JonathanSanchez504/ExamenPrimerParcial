namespace Examen_Primer_Parcial
{
    partial class Ejercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descripcion1 = new System.Windows.Forms.TextBox();
            this.txtb_cantidad1 = new System.Windows.Forms.TextBox();
            this.txtb_precio1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtb_descuento = new System.Windows.Forms.TextBox();
            this.txtb_totalpagar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btt_nuevo = new System.Windows.Forms.Button();
            this.btt_menu = new System.Windows.Forms.Button();
            this.btt_calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jonathan Sanchez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto/Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(301, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(421, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // txt_descripcion1
            // 
            this.txt_descripcion1.Location = new System.Drawing.Point(55, 188);
            this.txt_descripcion1.Name = "txt_descripcion1";
            this.txt_descripcion1.Size = new System.Drawing.Size(207, 29);
            this.txt_descripcion1.TabIndex = 5;
            // 
            // txtb_cantidad1
            // 
            this.txtb_cantidad1.Location = new System.Drawing.Point(305, 188);
            this.txtb_cantidad1.Name = "txtb_cantidad1";
            this.txtb_cantidad1.Size = new System.Drawing.Size(88, 29);
            this.txtb_cantidad1.TabIndex = 6;
            // 
            // txtb_precio1
            // 
            this.txtb_precio1.Location = new System.Drawing.Point(423, 188);
            this.txtb_precio1.Name = "txtb_precio1";
            this.txtb_precio1.Size = new System.Drawing.Size(84, 29);
            this.txtb_precio1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(624, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total:";
            // 
            // txtb_total
            // 
            this.txtb_total.Location = new System.Drawing.Point(720, 341);
            this.txtb_total.Name = "txtb_total";
            this.txtb_total.Size = new System.Drawing.Size(100, 29);
            this.txtb_total.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(585, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Descuento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(575, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total a Pagar:";
            // 
            // txtb_descuento
            // 
            this.txtb_descuento.Location = new System.Drawing.Point(722, 391);
            this.txtb_descuento.Name = "txtb_descuento";
            this.txtb_descuento.Size = new System.Drawing.Size(100, 29);
            this.txtb_descuento.TabIndex = 18;
            // 
            // txtb_totalpagar
            // 
            this.txtb_totalpagar.Location = new System.Drawing.Point(720, 430);
            this.txtb_totalpagar.Name = "txtb_totalpagar";
            this.txtb_totalpagar.Size = new System.Drawing.Size(100, 29);
            this.txtb_totalpagar.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(31, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 236);
            this.dataGridView1.TabIndex = 24;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // btt_nuevo
            // 
            this.btt_nuevo.Location = new System.Drawing.Point(643, 136);
            this.btt_nuevo.Name = "btt_nuevo";
            this.btt_nuevo.Size = new System.Drawing.Size(133, 30);
            this.btt_nuevo.TabIndex = 21;
            this.btt_nuevo.Text = "Nuevo";
            this.btt_nuevo.UseVisualStyleBackColor = true;
            this.btt_nuevo.Click += new System.EventHandler(this.btt_nuevo_Click);
            // 
            // btt_menu
            // 
            this.btt_menu.Location = new System.Drawing.Point(643, 228);
            this.btt_menu.Name = "btt_menu";
            this.btt_menu.Size = new System.Drawing.Size(133, 32);
            this.btt_menu.TabIndex = 22;
            this.btt_menu.Text = "Menu";
            this.btt_menu.UseVisualStyleBackColor = true;
            this.btt_menu.Click += new System.EventHandler(this.btt_menu_Click);
            // 
            // btt_calcular
            // 
            this.btt_calcular.Location = new System.Drawing.Point(643, 183);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(133, 34);
            this.btt_calcular.TabIndex = 20;
            this.btt_calcular.Text = "Calcular";
            this.btt_calcular.UseVisualStyleBackColor = true;
            this.btt_calcular.Click += new System.EventHandler(this.btt_calcular_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(956, 500);
            this.Controls.Add(this.btt_nuevo);
            this.Controls.Add(this.btt_menu);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtb_totalpagar);
            this.Controls.Add(this.txtb_descuento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtb_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_precio1);
            this.Controls.Add(this.txtb_cantidad1);
            this.Controls.Add(this.txt_descripcion1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ejercicio2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descripcion1;
        private System.Windows.Forms.TextBox txtb_cantidad1;
        private System.Windows.Forms.TextBox txtb_precio1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtb_descuento;
        private System.Windows.Forms.TextBox txtb_totalpagar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btt_nuevo;
        private System.Windows.Forms.Button btt_menu;
        private System.Windows.Forms.Button btt_calcular;
    }
}