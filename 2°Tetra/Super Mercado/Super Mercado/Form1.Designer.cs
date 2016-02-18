namespace Super_Mercado
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
            this.button_Total = new System.Windows.Forms.Button();
            this.textBox_Articulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Descuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Iva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.button_Salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Total
            // 
            this.button_Total.Location = new System.Drawing.Point(550, 114);
            this.button_Total.Name = "button_Total";
            this.button_Total.Size = new System.Drawing.Size(161, 48);
            this.button_Total.TabIndex = 0;
            this.button_Total.Text = "Total";
            this.button_Total.UseVisualStyleBackColor = true;
            this.button_Total.Click += new System.EventHandler(this.button_Total_Click);
            // 
            // textBox_Articulo
            // 
            this.textBox_Articulo.Location = new System.Drawing.Point(16, 133);
            this.textBox_Articulo.Name = "textBox_Articulo";
            this.textBox_Articulo.Size = new System.Drawing.Size(178, 29);
            this.textBox_Articulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio del Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descuento";
            // 
            // textBox_Descuento
            // 
            this.textBox_Descuento.Location = new System.Drawing.Point(16, 227);
            this.textBox_Descuento.Name = "textBox_Descuento";
            this.textBox_Descuento.Size = new System.Drawing.Size(178, 29);
            this.textBox_Descuento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iva 16%";
            // 
            // textBox_Iva
            // 
            this.textBox_Iva.Location = new System.Drawing.Point(16, 327);
            this.textBox_Iva.Name = "textBox_Iva";
            this.textBox_Iva.Size = new System.Drawing.Size(178, 29);
            this.textBox_Iva.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(293, 133);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(178, 29);
            this.textBox_Total.TabIndex = 7;
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(550, 308);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(161, 48);
            this.button_Salir.TabIndex = 9;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(723, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "*SUPER MELGEM EL TODO PODEROSO*";
            // 
            // button_Borrar
            // 
            this.button_Borrar.Location = new System.Drawing.Point(550, 208);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(161, 48);
            this.button_Borrar.TabIndex = 11;
            this.button_Borrar.Text = "Borrar";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.Click += new System.EventHandler(this.button_Borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 408);
            this.Controls.Add(this.button_Borrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Iva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Descuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Articulo);
            this.Controls.Add(this.button_Total);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPER MERCADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Total;
        private System.Windows.Forms.TextBox textBox_Articulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Descuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Iva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Borrar;
    }
}

