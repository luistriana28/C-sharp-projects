namespace Fig_Circulo
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
            this.bttn_Registrar = new System.Windows.Forms.Button();
            this.txt_Radio = new System.Windows.Forms.TextBox();
            this.bttn_ObtPerimetro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Perimetro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.bttn_ObtArea = new System.Windows.Forms.Button();
            this.bttn_Limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Registrar
            // 
            this.bttn_Registrar.Location = new System.Drawing.Point(20, 41);
            this.bttn_Registrar.Name = "bttn_Registrar";
            this.bttn_Registrar.Size = new System.Drawing.Size(117, 51);
            this.bttn_Registrar.TabIndex = 0;
            this.bttn_Registrar.Text = "Registrar Dato";
            this.bttn_Registrar.UseVisualStyleBackColor = true;
            this.bttn_Registrar.Click += new System.EventHandler(this.bttn_Registrar_Click);
            // 
            // txt_Radio
            // 
            this.txt_Radio.Location = new System.Drawing.Point(176, 130);
            this.txt_Radio.Name = "txt_Radio";
            this.txt_Radio.Size = new System.Drawing.Size(100, 26);
            this.txt_Radio.TabIndex = 1;
            // 
            // bttn_ObtPerimetro
            // 
            this.bttn_ObtPerimetro.Location = new System.Drawing.Point(17, 162);
            this.bttn_ObtPerimetro.Name = "bttn_ObtPerimetro";
            this.bttn_ObtPerimetro.Size = new System.Drawing.Size(117, 51);
            this.bttn_ObtPerimetro.TabIndex = 2;
            this.bttn_ObtPerimetro.Text = "Obtener Perimetro";
            this.bttn_ObtPerimetro.UseVisualStyleBackColor = true;
            this.bttn_ObtPerimetro.Click += new System.EventHandler(this.bttn_ObtPerimetro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "R =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "P =";
            // 
            // txt_Perimetro
            // 
            this.txt_Perimetro.Location = new System.Drawing.Point(131, 39);
            this.txt_Perimetro.Name = "txt_Perimetro";
            this.txt_Perimetro.Size = new System.Drawing.Size(100, 26);
            this.txt_Perimetro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "A =";
            // 
            // txt_Area
            // 
            this.txt_Area.Location = new System.Drawing.Point(131, 112);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(100, 26);
            this.txt_Area.TabIndex = 7;
            // 
            // bttn_ObtArea
            // 
            this.bttn_ObtArea.Location = new System.Drawing.Point(162, 162);
            this.bttn_ObtArea.Name = "bttn_ObtArea";
            this.bttn_ObtArea.Size = new System.Drawing.Size(117, 51);
            this.bttn_ObtArea.TabIndex = 8;
            this.bttn_ObtArea.Text = "Obtener Area";
            this.bttn_ObtArea.UseVisualStyleBackColor = true;
            this.bttn_ObtArea.Click += new System.EventHandler(this.bttn_ObtArea_Click);
            // 
            // bttn_Limpiar
            // 
            this.bttn_Limpiar.Location = new System.Drawing.Point(20, 112);
            this.bttn_Limpiar.Name = "bttn_Limpiar";
            this.bttn_Limpiar.Size = new System.Drawing.Size(117, 51);
            this.bttn_Limpiar.TabIndex = 9;
            this.bttn_Limpiar.Text = "Limpiar Registro";
            this.bttn_Limpiar.UseVisualStyleBackColor = true;
            this.bttn_Limpiar.Click += new System.EventHandler(this.bttn_Limpiar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Radio (R)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Perimetro (P)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Area (A)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Perimetro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Area);
            this.groupBox1.Controls.Add(this.bttn_ObtArea);
            this.groupBox1.Controls.Add(this.bttn_ObtPerimetro);
            this.groupBox1.Location = new System.Drawing.Point(324, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 232);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 68);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignacion de Variabre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttn_Registrar);
            this.groupBox3.Controls.Add(this.bttn_Limpiar);
            this.groupBox3.Location = new System.Drawing.Point(639, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 190);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reg/Lim";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(639, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 123);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fig_Circulo.Properties.Resources.Circulo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 382);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Radio);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figura Circulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Registrar;
        private System.Windows.Forms.TextBox txt_Radio;
        private System.Windows.Forms.Button bttn_ObtPerimetro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Perimetro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.Button bttn_ObtArea;
        private System.Windows.Forms.Button bttn_Limpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

