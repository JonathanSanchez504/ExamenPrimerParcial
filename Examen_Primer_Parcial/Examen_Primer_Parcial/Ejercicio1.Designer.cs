namespace Examen_Primer_Parcial
{
    partial class Ejercicio1
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
            this.lbx_datos = new System.Windows.Forms.ListBox();
            this.btt_Calcular = new System.Windows.Forms.Button();
            this.btt_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(348, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ejercicio 1 ";
            // 
            // lbx_datos
            // 
            this.lbx_datos.FormattingEnabled = true;
            this.lbx_datos.ItemHeight = 24;
            this.lbx_datos.Location = new System.Drawing.Point(49, 117);
            this.lbx_datos.Name = "lbx_datos";
            this.lbx_datos.Size = new System.Drawing.Size(273, 292);
            this.lbx_datos.TabIndex = 2;
            // 
            // btt_Calcular
            // 
            this.btt_Calcular.Location = new System.Drawing.Point(393, 165);
            this.btt_Calcular.Name = "btt_Calcular";
            this.btt_Calcular.Size = new System.Drawing.Size(131, 47);
            this.btt_Calcular.TabIndex = 3;
            this.btt_Calcular.Text = "Calcular";
            this.btt_Calcular.UseVisualStyleBackColor = true;
            this.btt_Calcular.Click += new System.EventHandler(this.btt_Calcular_Click);
            // 
            // btt_Menu
            // 
            this.btt_Menu.Location = new System.Drawing.Point(393, 238);
            this.btt_Menu.Name = "btt_Menu";
            this.btt_Menu.Size = new System.Drawing.Size(130, 31);
            this.btt_Menu.TabIndex = 4;
            this.btt_Menu.Text = "Menu";
            this.btt_Menu.UseVisualStyleBackColor = true;
            this.btt_Menu.Click += new System.EventHandler(this.btt_Menu_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(548, 482);
            this.Controls.Add(this.btt_Menu);
            this.Controls.Add(this.btt_Calcular);
            this.Controls.Add(this.lbx_datos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_datos;
        private System.Windows.Forms.Button btt_Calcular;
        private System.Windows.Forms.Button btt_Menu;
    }
}