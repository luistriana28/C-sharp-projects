namespace Bancote
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttn_Deposito = new System.Windows.Forms.Button();
            this.bttn_ObtenerRetiro = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Comision = new System.Windows.Forms.TextBox();
            this.txt_Interes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Deposito = new System.Windows.Forms.TextBox();
            this.txt_Retiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Inversion = new System.Windows.Forms.RadioButton();
            this.radioButton_Ahorro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.txt_Nocuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_Salir = new System.Windows.Forms.Button();
            this.bttn_Registrar = new System.Windows.Forms.Button();
            this.bttn_Leer = new System.Windows.Forms.Button();
            this.bttn_Limpiar = new System.Windows.Forms.Button();
            this.bttn_Obtener = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttn_Deposito);
            this.groupBox2.Controls.Add(this.bttn_ObtenerRetiro);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_Deposito);
            this.groupBox2.Controls.Add(this.txt_Retiro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 151);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago:";
            // 
            // bttn_Deposito
            // 
            this.bttn_Deposito.Location = new System.Drawing.Point(210, 86);
            this.bttn_Deposito.Name = "bttn_Deposito";
            this.bttn_Deposito.Size = new System.Drawing.Size(95, 49);
            this.bttn_Deposito.TabIndex = 22;
            this.bttn_Deposito.Text = "Hacer Deposito";
            this.bttn_Deposito.UseVisualStyleBackColor = true;
            this.bttn_Deposito.Click += new System.EventHandler(this.bttn_Deposito_Click);
            // 
            // bttn_ObtenerRetiro
            // 
            this.bttn_ObtenerRetiro.Location = new System.Drawing.Point(210, 21);
            this.bttn_ObtenerRetiro.Name = "bttn_ObtenerRetiro";
            this.bttn_ObtenerRetiro.Size = new System.Drawing.Size(95, 49);
            this.bttn_ObtenerRetiro.TabIndex = 21;
            this.bttn_ObtenerRetiro.Text = "Hacer Retiro";
            this.bttn_ObtenerRetiro.UseVisualStyleBackColor = true;
            this.bttn_ObtenerRetiro.Click += new System.EventHandler(this.bttn_ObtenerRetiro_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Comision);
            this.groupBox3.Controls.Add(this.txt_Interes);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(323, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 122);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Genera:";
            // 
            // txt_Comision
            // 
            this.txt_Comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comision.Location = new System.Drawing.Point(93, 73);
            this.txt_Comision.Name = "txt_Comision";
            this.txt_Comision.Size = new System.Drawing.Size(153, 24);
            this.txt_Comision.TabIndex = 21;
            // 
            // txt_Interes
            // 
            this.txt_Interes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Interes.Location = new System.Drawing.Point(93, 23);
            this.txt_Interes.Name = "txt_Interes";
            this.txt_Interes.Size = new System.Drawing.Size(153, 24);
            this.txt_Interes.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Comision:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Interes:";
            // 
            // txt_Deposito
            // 
            this.txt_Deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Deposito.Location = new System.Drawing.Point(120, 101);
            this.txt_Deposito.Name = "txt_Deposito";
            this.txt_Deposito.Size = new System.Drawing.Size(71, 24);
            this.txt_Deposito.TabIndex = 17;
            // 
            // txt_Retiro
            // 
            this.txt_Retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Retiro.Location = new System.Drawing.Point(120, 46);
            this.txt_Retiro.Name = "txt_Retiro";
            this.txt_Retiro.Size = new System.Drawing.Size(71, 24);
            this.txt_Retiro.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Deposito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Retiro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Inversion);
            this.groupBox1.Controls.Add(this.radioButton_Ahorro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Saldo);
            this.groupBox1.Controls.Add(this.txt_Nocuenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(85, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 236);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta:";
            // 
            // radioButton_Inversion
            // 
            this.radioButton_Inversion.AutoSize = true;
            this.radioButton_Inversion.Location = new System.Drawing.Point(314, 130);
            this.radioButton_Inversion.Name = "radioButton_Inversion";
            this.radioButton_Inversion.Size = new System.Drawing.Size(94, 22);
            this.radioButton_Inversion.TabIndex = 15;
            this.radioButton_Inversion.Text = "Inversion";
            this.radioButton_Inversion.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ahorro
            // 
            this.radioButton_Ahorro.AutoSize = true;
            this.radioButton_Ahorro.Location = new System.Drawing.Point(191, 130);
            this.radioButton_Ahorro.Name = "radioButton_Ahorro";
            this.radioButton_Ahorro.Size = new System.Drawing.Size(77, 22);
            this.radioButton_Ahorro.TabIndex = 14;
            this.radioButton_Ahorro.Text = "Ahorro";
            this.radioButton_Ahorro.UseVisualStyleBackColor = false;
            this.radioButton_Ahorro.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "N° de Cuenta:";
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Saldo.Location = new System.Drawing.Point(191, 185);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(227, 24);
            this.txt_Saldo.TabIndex = 11;
            // 
            // txt_Nocuenta
            // 
            this.txt_Nocuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nocuenta.Location = new System.Drawing.Point(191, 33);
            this.txt_Nocuenta.Name = "txt_Nocuenta";
            this.txt_Nocuenta.Size = new System.Drawing.Size(227, 24);
            this.txt_Nocuenta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Cuenta:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(191, 81);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(227, 24);
            this.txt_Nombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // bttn_Salir
            // 
            this.bttn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Salir.Location = new System.Drawing.Point(541, 438);
            this.bttn_Salir.Name = "bttn_Salir";
            this.bttn_Salir.Size = new System.Drawing.Size(88, 54);
            this.bttn_Salir.TabIndex = 16;
            this.bttn_Salir.Text = "Salir Cuenta";
            this.bttn_Salir.UseVisualStyleBackColor = true;
            this.bttn_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_Registrar
            // 
            this.bttn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Registrar.Location = new System.Drawing.Point(140, 438);
            this.bttn_Registrar.Name = "bttn_Registrar";
            this.bttn_Registrar.Size = new System.Drawing.Size(101, 54);
            this.bttn_Registrar.TabIndex = 17;
            this.bttn_Registrar.Text = "Registrar Dato";
            this.bttn_Registrar.UseVisualStyleBackColor = true;
            this.bttn_Registrar.Click += new System.EventHandler(this.bttn_Registrar_Click);
            // 
            // bttn_Leer
            // 
            this.bttn_Leer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Leer.Location = new System.Drawing.Point(20, 438);
            this.bttn_Leer.Name = "bttn_Leer";
            this.bttn_Leer.Size = new System.Drawing.Size(78, 54);
            this.bttn_Leer.TabIndex = 18;
            this.bttn_Leer.Text = "Leer Dato";
            this.bttn_Leer.UseVisualStyleBackColor = true;
            this.bttn_Leer.Click += new System.EventHandler(this.bttn_Leer_Click);
            // 
            // bttn_Limpiar
            // 
            this.bttn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Limpiar.Location = new System.Drawing.Point(420, 438);
            this.bttn_Limpiar.Name = "bttn_Limpiar";
            this.bttn_Limpiar.Size = new System.Drawing.Size(93, 54);
            this.bttn_Limpiar.TabIndex = 19;
            this.bttn_Limpiar.Text = "Limpiar Registro";
            this.bttn_Limpiar.UseVisualStyleBackColor = true;
            this.bttn_Limpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // bttn_Obtener
            // 
            this.bttn_Obtener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Obtener.Location = new System.Drawing.Point(287, 438);
            this.bttn_Obtener.Name = "bttn_Obtener";
            this.bttn_Obtener.Size = new System.Drawing.Size(96, 54);
            this.bttn_Obtener.TabIndex = 20;
            this.bttn_Obtener.Text = "Obtener Int/Comis";
            this.bttn_Obtener.UseVisualStyleBackColor = true;
            this.bttn_Obtener.Click += new System.EventHandler(this.bttn_Obtener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(645, 517);
            this.ControlBox = false;
            this.Controls.Add(this.bttn_Obtener);
            this.Controls.Add(this.bttn_Limpiar);
            this.Controls.Add(this.bttn_Leer);
            this.Controls.Add(this.bttn_Registrar);
            this.Controls.Add(this.bttn_Salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Bancaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Deposito;
        private System.Windows.Forms.TextBox txt_Retiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Inversion;
        private System.Windows.Forms.RadioButton radioButton_Ahorro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_Nocuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttn_Salir;
        private System.Windows.Forms.Button bttn_Registrar;
        private System.Windows.Forms.Button bttn_Leer;
        private System.Windows.Forms.Button bttn_Limpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Comision;
        private System.Windows.Forms.TextBox txt_Interes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttn_Obtener;
        private System.Windows.Forms.Button bttn_ObtenerRetiro;
        private System.Windows.Forms.Button bttn_Deposito;
    }
}

