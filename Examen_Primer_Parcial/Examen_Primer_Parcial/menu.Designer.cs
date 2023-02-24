namespace Examen_Primer_Parcial
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btt_ejercicio1 = new System.Windows.Forms.Button();
            this.btt_ejercicio2 = new System.Windows.Forms.Button();
            this.btt_ejercicio3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_ejercicio1
            // 
            this.btt_ejercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ejercicio1.Location = new System.Drawing.Point(96, 124);
            this.btt_ejercicio1.Name = "btt_ejercicio1";
            this.btt_ejercicio1.Size = new System.Drawing.Size(84, 44);
            this.btt_ejercicio1.TabIndex = 0;
            this.btt_ejercicio1.Text = "Ejercicio 1";
            this.btt_ejercicio1.UseVisualStyleBackColor = true;
            this.btt_ejercicio1.Click += new System.EventHandler(this.btt_ejercicio1_Click);
            // 
            // btt_ejercicio2
            // 
            this.btt_ejercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ejercicio2.Location = new System.Drawing.Point(196, 124);
            this.btt_ejercicio2.Name = "btt_ejercicio2";
            this.btt_ejercicio2.Size = new System.Drawing.Size(85, 42);
            this.btt_ejercicio2.TabIndex = 1;
            this.btt_ejercicio2.Text = "Ejercicio 2";
            this.btt_ejercicio2.UseVisualStyleBackColor = true;
            this.btt_ejercicio2.Click += new System.EventHandler(this.btt_ejercicio2_Click);
            // 
            // btt_ejercicio3
            // 
            this.btt_ejercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ejercicio3.Location = new System.Drawing.Point(300, 122);
            this.btt_ejercicio3.Name = "btt_ejercicio3";
            this.btt_ejercicio3.Size = new System.Drawing.Size(81, 44);
            this.btt_ejercicio3.TabIndex = 2;
            this.btt_ejercicio3.Text = "Ejercicio 3";
            this.btt_ejercicio3.UseVisualStyleBackColor = true;
            this.btt_ejercicio3.Click += new System.EventHandler(this.btt_ejercicio3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_ejercicio3);
            this.Controls.Add(this.btt_ejercicio2);
            this.Controls.Add(this.btt_ejercicio1);
            this.Name = "menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_ejercicio1;
        private System.Windows.Forms.Button btt_ejercicio2;
        private System.Windows.Forms.Button btt_ejercicio3;
        private System.Windows.Forms.Label label1;
    }
}

