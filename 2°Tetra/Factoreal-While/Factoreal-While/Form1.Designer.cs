namespace Factoreal_While
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
            this.button_Factorizar = new System.Windows.Forms.Button();
            this.button_borrar = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.textBox_No = new System.Windows.Forms.TextBox();
            this.textBox_Resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Factorizar
            // 
            this.button_Factorizar.Location = new System.Drawing.Point(12, 12);
            this.button_Factorizar.Name = "button_Factorizar";
            this.button_Factorizar.Size = new System.Drawing.Size(143, 42);
            this.button_Factorizar.TabIndex = 0;
            this.button_Factorizar.Text = "Factorizar";
            this.button_Factorizar.UseVisualStyleBackColor = true;
            this.button_Factorizar.Click += new System.EventHandler(this.button_Factorizar_Click);
            // 
            // button_borrar
            // 
            this.button_borrar.Location = new System.Drawing.Point(12, 161);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(143, 42);
            this.button_borrar.TabIndex = 1;
            this.button_borrar.Text = "Borrar";
            this.button_borrar.UseVisualStyleBackColor = true;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(255, 161);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(143, 42);
            this.button_Salir.TabIndex = 2;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // textBox_No
            // 
            this.textBox_No.Location = new System.Drawing.Point(186, 12);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.Size = new System.Drawing.Size(212, 26);
            this.textBox_No.TabIndex = 3;
            // 
            // textBox_Resultado
            // 
            this.textBox_Resultado.Location = new System.Drawing.Point(110, 79);
            this.textBox_Resultado.Name = "textBox_Resultado";
            this.textBox_Resultado.Size = new System.Drawing.Size(143, 26);
            this.textBox_Resultado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Resultado);
            this.Controls.Add(this.textBox_No);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.button_Factorizar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Factorizar;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.TextBox textBox_No;
        private System.Windows.Forms.TextBox textBox_Resultado;
        private System.Windows.Forms.Label label1;
    }
}

