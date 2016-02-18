namespace Tarea_de_suma
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
            this.txtBox_No1 = new System.Windows.Forms.TextBox();
            this.txtBox_No2 = new System.Windows.Forms.TextBox();
            this.Bttn_Resultado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            // 
            // txtBox_No1
            // 
            this.txtBox_No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_No1.Location = new System.Drawing.Point(189, 12);
            this.txtBox_No1.Name = "txtBox_No1";
            this.txtBox_No1.Size = new System.Drawing.Size(116, 26);
            this.txtBox_No1.TabIndex = 1;
            this.txtBox_No1.TextChanged += new System.EventHandler(this.txtBox_No1_TextChanged);
            // 
            // txtBox_No2
            // 
            this.txtBox_No2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_No2.Location = new System.Drawing.Point(189, 61);
            this.txtBox_No2.Name = "txtBox_No2";
            this.txtBox_No2.Size = new System.Drawing.Size(116, 26);
            this.txtBox_No2.TabIndex = 2;
            this.txtBox_No2.TextChanged += new System.EventHandler(this.txtBox_No2_TextChanged);
            // 
            // Bttn_Resultado
            // 
            this.Bttn_Resultado.Location = new System.Drawing.Point(189, 119);
            this.Bttn_Resultado.Name = "Bttn_Resultado";
            this.Bttn_Resultado.Size = new System.Drawing.Size(172, 52);
            this.Bttn_Resultado.TabIndex = 3;
            this.Bttn_Resultado.Text = "Resultado";
            this.Bttn_Resultado.UseVisualStyleBackColor = true;
            this.Bttn_Resultado.Click += new System.EventHandler(this.Bttn_Resultado_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "1er Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "2do Numero:";
            // 
            // bttn_Salir
            // 
            this.bttn_Salir.Location = new System.Drawing.Point(12, 146);
            this.bttn_Salir.Name = "bttn_Salir";
            this.bttn_Salir.Size = new System.Drawing.Size(141, 40);
            this.bttn_Salir.TabIndex = 6;
            this.bttn_Salir.Text = "Exit";
            this.bttn_Salir.UseVisualStyleBackColor = true;
            this.bttn_Salir.Click += new System.EventHandler(this.bttn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 198);
            this.Controls.Add(this.bttn_Salir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bttn_Resultado);
            this.Controls.Add(this.txtBox_No2);
            this.Controls.Add(this.txtBox_No1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_No1;
        private System.Windows.Forms.TextBox txtBox_No2;
        private System.Windows.Forms.Button Bttn_Resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttn_Salir;
    }
}

