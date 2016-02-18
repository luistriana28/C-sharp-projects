namespace PrueblaGeometria_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bttn_PerimetroCirculo = new System.Windows.Forms.Button();
            this.Bttn_AreaCiculo = new System.Windows.Forms.Button();
            this.Text_FormulaCirculo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bttn_PerimetroCuadrado = new System.Windows.Forms.Button();
            this.Bttn_AreaCuadrado = new System.Windows.Forms.Button();
            this.Text_FormulaCuadrado = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Bttn_VolumenEsfera = new System.Windows.Forms.Button();
            this.Text_FormulaEsfera = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Bttn_VolumenCilindro = new System.Windows.Forms.Button();
            this.Text_FormulaCilindro = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.Text_NCirculo = new System.Windows.Forms.TextBox();
            this.Text_NCuadrado = new System.Windows.Forms.TextBox();
            this.Text_NEsfera = new System.Windows.Forms.TextBox();
            this.Text_NRadioCilindro = new System.Windows.Forms.TextBox();
            this.Text_NAlturaCilindro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Text_NCirculo);
            this.groupBox1.Controls.Add(this.Bttn_PerimetroCirculo);
            this.groupBox1.Controls.Add(this.Bttn_AreaCiculo);
            this.groupBox1.Controls.Add(this.Text_FormulaCirculo);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(318, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circulo";
            // 
            // Bttn_PerimetroCirculo
            // 
            this.Bttn_PerimetroCirculo.Location = new System.Drawing.Point(182, 110);
            this.Bttn_PerimetroCirculo.Name = "Bttn_PerimetroCirculo";
            this.Bttn_PerimetroCirculo.Size = new System.Drawing.Size(116, 53);
            this.Bttn_PerimetroCirculo.TabIndex = 2;
            this.Bttn_PerimetroCirculo.Text = "Calc Perimetro";
            this.Bttn_PerimetroCirculo.UseVisualStyleBackColor = true;
            this.Bttn_PerimetroCirculo.Click += new System.EventHandler(this.Bttn_PerimetroCirculo_Click);
            // 
            // Bttn_AreaCiculo
            // 
            this.Bttn_AreaCiculo.Location = new System.Drawing.Point(8, 110);
            this.Bttn_AreaCiculo.Name = "Bttn_AreaCiculo";
            this.Bttn_AreaCiculo.Size = new System.Drawing.Size(116, 53);
            this.Bttn_AreaCiculo.TabIndex = 1;
            this.Bttn_AreaCiculo.Text = "Calc Area";
            this.Bttn_AreaCiculo.UseVisualStyleBackColor = true;
            this.Bttn_AreaCiculo.Click += new System.EventHandler(this.Bttn_AreaCiculo_Click);
            // 
            // Text_FormulaCirculo
            // 
            this.Text_FormulaCirculo.Location = new System.Drawing.Point(8, 69);
            this.Text_FormulaCirculo.Name = "Text_FormulaCirculo";
            this.Text_FormulaCirculo.Size = new System.Drawing.Size(290, 26);
            this.Text_FormulaCirculo.TabIndex = 0;
            this.Text_FormulaCirculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Text_NCuadrado);
            this.groupBox2.Controls.Add(this.Bttn_PerimetroCuadrado);
            this.groupBox2.Controls.Add(this.Bttn_AreaCuadrado);
            this.groupBox2.Controls.Add(this.Text_FormulaCuadrado);
            this.groupBox2.Location = new System.Drawing.Point(375, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(318, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuadrado";
            // 
            // Bttn_PerimetroCuadrado
            // 
            this.Bttn_PerimetroCuadrado.Location = new System.Drawing.Point(182, 110);
            this.Bttn_PerimetroCuadrado.Name = "Bttn_PerimetroCuadrado";
            this.Bttn_PerimetroCuadrado.Size = new System.Drawing.Size(116, 53);
            this.Bttn_PerimetroCuadrado.TabIndex = 2;
            this.Bttn_PerimetroCuadrado.Text = "Calc Perimetro";
            this.Bttn_PerimetroCuadrado.UseVisualStyleBackColor = true;
            this.Bttn_PerimetroCuadrado.Click += new System.EventHandler(this.Bttn_PerimetroCuadrado_Click);
            // 
            // Bttn_AreaCuadrado
            // 
            this.Bttn_AreaCuadrado.Location = new System.Drawing.Point(8, 110);
            this.Bttn_AreaCuadrado.Name = "Bttn_AreaCuadrado";
            this.Bttn_AreaCuadrado.Size = new System.Drawing.Size(116, 53);
            this.Bttn_AreaCuadrado.TabIndex = 1;
            this.Bttn_AreaCuadrado.Text = "Calc Area";
            this.Bttn_AreaCuadrado.UseVisualStyleBackColor = true;
            this.Bttn_AreaCuadrado.Click += new System.EventHandler(this.Bttn_AreaCuadrado_Click);
            // 
            // Text_FormulaCuadrado
            // 
            this.Text_FormulaCuadrado.Location = new System.Drawing.Point(8, 69);
            this.Text_FormulaCuadrado.Name = "Text_FormulaCuadrado";
            this.Text_FormulaCuadrado.Size = new System.Drawing.Size(290, 26);
            this.Text_FormulaCuadrado.TabIndex = 0;
            this.Text_FormulaCuadrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Text_NEsfera);
            this.groupBox3.Controls.Add(this.Bttn_VolumenEsfera);
            this.groupBox3.Controls.Add(this.Text_FormulaEsfera);
            this.groupBox3.Location = new System.Drawing.Point(730, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(318, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Esfera";
            // 
            // Bttn_VolumenEsfera
            // 
            this.Bttn_VolumenEsfera.Location = new System.Drawing.Point(99, 110);
            this.Bttn_VolumenEsfera.Name = "Bttn_VolumenEsfera";
            this.Bttn_VolumenEsfera.Size = new System.Drawing.Size(116, 53);
            this.Bttn_VolumenEsfera.TabIndex = 1;
            this.Bttn_VolumenEsfera.Text = "Calc Volumen";
            this.Bttn_VolumenEsfera.UseVisualStyleBackColor = true;
            this.Bttn_VolumenEsfera.Click += new System.EventHandler(this.Bttn_VolumenEsfera_Click);
            // 
            // Text_FormulaEsfera
            // 
            this.Text_FormulaEsfera.Location = new System.Drawing.Point(8, 69);
            this.Text_FormulaEsfera.Name = "Text_FormulaEsfera";
            this.Text_FormulaEsfera.Size = new System.Drawing.Size(290, 26);
            this.Text_FormulaEsfera.TabIndex = 0;
            this.Text_FormulaEsfera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(774, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 53);
            this.button5.TabIndex = 2;
            this.button5.Text = "Limpiar Registro";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Text_NAlturaCilindro);
            this.groupBox4.Controls.Add(this.Bttn_VolumenCilindro);
            this.groupBox4.Controls.Add(this.Text_FormulaCilindro);
            this.groupBox4.Controls.Add(this.Text_NRadioCilindro);
            this.groupBox4.Location = new System.Drawing.Point(375, 215);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(318, 186);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cilindro";
            // 
            // Bttn_VolumenCilindro
            // 
            this.Bttn_VolumenCilindro.Location = new System.Drawing.Point(98, 125);
            this.Bttn_VolumenCilindro.Name = "Bttn_VolumenCilindro";
            this.Bttn_VolumenCilindro.Size = new System.Drawing.Size(116, 53);
            this.Bttn_VolumenCilindro.TabIndex = 1;
            this.Bttn_VolumenCilindro.Text = "Calc Volumen";
            this.Bttn_VolumenCilindro.UseVisualStyleBackColor = true;
            this.Bttn_VolumenCilindro.Click += new System.EventHandler(this.Bttn_VolumenCilindro_Click);
            // 
            // Text_FormulaCilindro
            // 
            this.Text_FormulaCilindro.Location = new System.Drawing.Point(8, 36);
            this.Text_FormulaCilindro.Name = "Text_FormulaCilindro";
            this.Text_FormulaCilindro.Size = new System.Drawing.Size(290, 26);
            this.Text_FormulaCilindro.TabIndex = 0;
            this.Text_FormulaCilindro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(933, 343);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 53);
            this.button8.TabIndex = 4;
            this.button8.Text = "Salir";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Text_NCirculo
            // 
            this.Text_NCirculo.Location = new System.Drawing.Point(8, 27);
            this.Text_NCirculo.Name = "Text_NCirculo";
            this.Text_NCirculo.Size = new System.Drawing.Size(100, 26);
            this.Text_NCirculo.TabIndex = 3;
            // 
            // Text_NCuadrado
            // 
            this.Text_NCuadrado.Location = new System.Drawing.Point(8, 27);
            this.Text_NCuadrado.Name = "Text_NCuadrado";
            this.Text_NCuadrado.Size = new System.Drawing.Size(100, 26);
            this.Text_NCuadrado.TabIndex = 5;
            // 
            // Text_NEsfera
            // 
            this.Text_NEsfera.Location = new System.Drawing.Point(8, 27);
            this.Text_NEsfera.Name = "Text_NEsfera";
            this.Text_NEsfera.Size = new System.Drawing.Size(100, 26);
            this.Text_NEsfera.TabIndex = 5;
            // 
            // Text_NRadioCilindro
            // 
            this.Text_NRadioCilindro.Location = new System.Drawing.Point(8, 68);
            this.Text_NRadioCilindro.Name = "Text_NRadioCilindro";
            this.Text_NRadioCilindro.Size = new System.Drawing.Size(100, 26);
            this.Text_NRadioCilindro.TabIndex = 5;
            // 
            // Text_NAlturaCilindro
            // 
            this.Text_NAlturaCilindro.Location = new System.Drawing.Point(198, 68);
            this.Text_NAlturaCilindro.Name = "Text_NAlturaCilindro";
            this.Text_NAlturaCilindro.Size = new System.Drawing.Size(100, 26);
            this.Text_NAlturaCilindro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Radio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Altura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 415);
            this.ControlBox = false;
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bttn_PerimetroCirculo;
        private System.Windows.Forms.Button Bttn_AreaCiculo;
        private System.Windows.Forms.TextBox Text_FormulaCirculo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bttn_PerimetroCuadrado;
        private System.Windows.Forms.Button Bttn_AreaCuadrado;
        private System.Windows.Forms.TextBox Text_FormulaCuadrado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Bttn_VolumenEsfera;
        private System.Windows.Forms.TextBox Text_FormulaEsfera;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Bttn_VolumenCilindro;
        private System.Windows.Forms.TextBox Text_FormulaCilindro;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox Text_NCirculo;
        private System.Windows.Forms.TextBox Text_NCuadrado;
        private System.Windows.Forms.TextBox Text_NEsfera;
        private System.Windows.Forms.TextBox Text_NRadioCilindro;
        private System.Windows.Forms.TextBox Text_NAlturaCilindro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

