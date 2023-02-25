namespace Examen_Primer_Parcial
{
    partial class Ejercicio3
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
            this.ltb_datos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_mostrar = new System.Windows.Forms.Button();
            this.bttn_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltb_datos
            // 
            this.ltb_datos.FormattingEnabled = true;
            this.ltb_datos.ItemHeight = 20;
            this.ltb_datos.Location = new System.Drawing.Point(22, 138);
            this.ltb_datos.Margin = new System.Windows.Forms.Padding(5);
            this.ltb_datos.Name = "ltb_datos";
            this.ltb_datos.Size = new System.Drawing.Size(855, 464);
            this.ltb_datos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ejercicio 3";
            // 
            // btt_mostrar
            // 
            this.btt_mostrar.Location = new System.Drawing.Point(347, 75);
            this.btt_mostrar.Name = "btt_mostrar";
            this.btt_mostrar.Size = new System.Drawing.Size(137, 30);
            this.btt_mostrar.TabIndex = 2;
            this.btt_mostrar.Text = "Mostar";
            this.btt_mostrar.UseVisualStyleBackColor = true;
            this.btt_mostrar.Click += new System.EventHandler(this.btt_mostrar_Click);
            // 
            // bttn_menu
            // 
            this.bttn_menu.Location = new System.Drawing.Point(500, 75);
            this.bttn_menu.Name = "bttn_menu";
            this.bttn_menu.Size = new System.Drawing.Size(95, 30);
            this.bttn_menu.TabIndex = 3;
            this.bttn_menu.Text = "Menu";
            this.bttn_menu.UseVisualStyleBackColor = true;
            this.bttn_menu.Click += new System.EventHandler(this.bttn_menu_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(891, 650);
            this.Controls.Add(this.bttn_menu);
            this.Controls.Add(this.btt_mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltb_datos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ejercicio3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btt_mostrar;
        private System.Windows.Forms.Button bttn_menu;
    }
}