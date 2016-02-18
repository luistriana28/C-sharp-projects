namespace Articulos_a_objetos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Articulo = new System.Windows.Forms.TextBox();
            this.textBox_Marca = new System.Windows.Forms.TextBox();
            this.textBox_Capacidad = new System.Windows.Forms.TextBox();
            this.textBox_Caracteristica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.button_Obtener = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.textBox_Iva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.textBox_Descuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttn_Calcular = new System.Windows.Forms.Button();
            this.bttn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Caracteristica:";
            // 
            // textBox_Articulo
            // 
            this.textBox_Articulo.Location = new System.Drawing.Point(171, 12);
            this.textBox_Articulo.Name = "textBox_Articulo";
            this.textBox_Articulo.Size = new System.Drawing.Size(297, 26);
            this.textBox_Articulo.TabIndex = 4;
            // 
            // textBox_Marca
            // 
            this.textBox_Marca.Location = new System.Drawing.Point(171, 60);
            this.textBox_Marca.Name = "textBox_Marca";
            this.textBox_Marca.Size = new System.Drawing.Size(297, 26);
            this.textBox_Marca.TabIndex = 5;
            // 
            // textBox_Capacidad
            // 
            this.textBox_Capacidad.Location = new System.Drawing.Point(171, 112);
            this.textBox_Capacidad.Name = "textBox_Capacidad";
            this.textBox_Capacidad.Size = new System.Drawing.Size(297, 26);
            this.textBox_Capacidad.TabIndex = 6;
            // 
            // textBox_Caracteristica
            // 
            this.textBox_Caracteristica.Location = new System.Drawing.Point(171, 162);
            this.textBox_Caracteristica.Name = "textBox_Caracteristica";
            this.textBox_Caracteristica.Size = new System.Drawing.Size(297, 26);
            this.textBox_Caracteristica.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio:";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(171, 211);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(297, 26);
            this.textBox_Precio.TabIndex = 9;
            // 
            // button_Registrar
            // 
            this.button_Registrar.Location = new System.Drawing.Point(369, 394);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(106, 39);
            this.button_Registrar.TabIndex = 10;
            this.button_Registrar.Text = "Registrar";
            this.button_Registrar.UseVisualStyleBackColor = true;
            this.button_Registrar.Click += new System.EventHandler(this.button_Registrar_Click);
            // 
            // button_Obtener
            // 
            this.button_Obtener.Location = new System.Drawing.Point(17, 394);
            this.button_Obtener.Name = "button_Obtener";
            this.button_Obtener.Size = new System.Drawing.Size(106, 38);
            this.button_Obtener.TabIndex = 11;
            this.button_Obtener.Text = "Obtener";
            this.button_Obtener.UseVisualStyleBackColor = true;
            this.button_Obtener.Click += new System.EventHandler(this.button_Obtener_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(17, 464);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(106, 38);
            this.button_Limpiar.TabIndex = 12;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // textBox_Iva
            // 
            this.textBox_Iva.Location = new System.Drawing.Point(86, 264);
            this.textBox_Iva.Name = "textBox_Iva";
            this.textBox_Iva.Size = new System.Drawing.Size(149, 26);
            this.textBox_Iva.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "IVA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total:";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(203, 335);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(149, 26);
            this.textBox_Total.TabIndex = 16;
            // 
            // textBox_Descuento
            // 
            this.textBox_Descuento.Location = new System.Drawing.Point(366, 264);
            this.textBox_Descuento.Name = "textBox_Descuento";
            this.textBox_Descuento.Size = new System.Drawing.Size(102, 26);
            this.textBox_Descuento.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Descuento:";
            // 
            // bttn_Calcular
            // 
            this.bttn_Calcular.Location = new System.Drawing.Point(193, 393);
            this.bttn_Calcular.Name = "bttn_Calcular";
            this.bttn_Calcular.Size = new System.Drawing.Size(106, 39);
            this.bttn_Calcular.TabIndex = 19;
            this.bttn_Calcular.Text = "Calcular";
            this.bttn_Calcular.UseVisualStyleBackColor = true;
            this.bttn_Calcular.Click += new System.EventHandler(this.bttn_Calcular_Click);
            // 
            // bttn_Salir
            // 
            this.bttn_Salir.Location = new System.Drawing.Point(369, 464);
            this.bttn_Salir.Name = "bttn_Salir";
            this.bttn_Salir.Size = new System.Drawing.Size(106, 39);
            this.bttn_Salir.TabIndex = 20;
            this.bttn_Salir.Text = "Salir";
            this.bttn_Salir.UseVisualStyleBackColor = true;
            this.bttn_Salir.Click += new System.EventHandler(this.bttn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 515);
            this.ControlBox = false;
            this.Controls.Add(this.bttn_Salir);
            this.Controls.Add(this.bttn_Calcular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Descuento);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Iva);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Obtener);
            this.Controls.Add(this.button_Registrar);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Caracteristica);
            this.Controls.Add(this.textBox_Capacidad);
            this.Controls.Add(this.textBox_Marca);
            this.Controls.Add(this.textBox_Articulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPANY MELGEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Articulo;
        private System.Windows.Forms.TextBox textBox_Marca;
        private System.Windows.Forms.TextBox textBox_Capacidad;
        private System.Windows.Forms.TextBox textBox_Caracteristica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Button button_Registrar;
        private System.Windows.Forms.Button button_Obtener;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.TextBox textBox_Iva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.TextBox textBox_Descuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttn_Calcular;
        private System.Windows.Forms.Button bttn_Salir;
    }
}

