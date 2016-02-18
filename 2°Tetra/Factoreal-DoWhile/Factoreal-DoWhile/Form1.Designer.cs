namespace Factoreal_DoWhile
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
            this.textBox_No = new System.Windows.Forms.TextBox();
            this.textBox_Resultado = new System.Windows.Forms.TextBox();
            this.button_Factorizar = new System.Windows.Forms.Button();
            this.button_Borrar = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_No
            // 
            this.textBox_No.Location = new System.Drawing.Point(12, 12);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.Size = new System.Drawing.Size(219, 26);
            this.textBox_No.TabIndex = 0;
            // 
            // textBox_Resultado
            // 
            this.textBox_Resultado.Location = new System.Drawing.Point(12, 149);
            this.textBox_Resultado.Name = "textBox_Resultado";
            this.textBox_Resultado.Size = new System.Drawing.Size(219, 26);
            this.textBox_Resultado.TabIndex = 1;
            // 
            // button_Factorizar
            // 
            this.button_Factorizar.Location = new System.Drawing.Point(12, 66);
            this.button_Factorizar.Name = "button_Factorizar";
            this.button_Factorizar.Size = new System.Drawing.Size(135, 50);
            this.button_Factorizar.TabIndex = 2;
            this.button_Factorizar.Text = "Factorizar";
            this.button_Factorizar.UseVisualStyleBackColor = true;
            this.button_Factorizar.Click += new System.EventHandler(this.button_Factorizar_Click);
            // 
            // button_Borrar
            // 
            this.button_Borrar.Location = new System.Drawing.Point(269, 12);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(111, 44);
            this.button_Borrar.TabIndex = 3;
            this.button_Borrar.Text = "Borrar";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.Click += new System.EventHandler(this.button_Borrar_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(269, 131);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(111, 44);
            this.button_Salir.TabIndex = 4;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 207);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Borrar);
            this.Controls.Add(this.button_Factorizar);
            this.Controls.Add(this.textBox_Resultado);
            this.Controls.Add(this.textBox_No);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_No;
        private System.Windows.Forms.TextBox textBox_Resultado;
        private System.Windows.Forms.Button button_Factorizar;
        private System.Windows.Forms.Button button_Borrar;
        private System.Windows.Forms.Button button_Salir;
    }
}

