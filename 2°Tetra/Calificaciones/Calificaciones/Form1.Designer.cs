namespace Calificaciones
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_MateriaLabel;
            System.Windows.Forms.Label materiaLabel;
            System.Windows.Forms.Label maestroLabel;
            System.Windows.Forms.Label calificacionesLabel;
            System.Windows.Forms.Label horarioLabel;
            System.Windows.Forms.Label fecha_InicioLabel;
            System.Windows.Forms.Label fecha_FinLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.escuelaDataSet1 = new Calificaciones.EscuelaDataSet1();
            this.calificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calificacionesTableAdapter = new Calificaciones.EscuelaDataSet1TableAdapters.CalificacionesTableAdapter();
            this.tableAdapterManager = new Calificaciones.EscuelaDataSet1TableAdapters.TableAdapterManager();
            this.calificacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.calificacionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_MateriaTextBox = new System.Windows.Forms.TextBox();
            this.materiaTextBox = new System.Windows.Forms.TextBox();
            this.maestroTextBox = new System.Windows.Forms.TextBox();
            this.calificacionesTextBox = new System.Windows.Forms.TextBox();
            this.horarioTextBox = new System.Windows.Forms.TextBox();
            this.fecha_InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_FinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            id_MateriaLabel = new System.Windows.Forms.Label();
            materiaLabel = new System.Windows.Forms.Label();
            maestroLabel = new System.Windows.Forms.Label();
            calificacionesLabel = new System.Windows.Forms.Label();
            horarioLabel = new System.Windows.Forms.Label();
            fecha_InicioLabel = new System.Windows.Forms.Label();
            fecha_FinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingNavigator)).BeginInit();
            this.calificacionesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_MateriaLabel
            // 
            id_MateriaLabel.AutoSize = true;
            id_MateriaLabel.Location = new System.Drawing.Point(12, 42);
            id_MateriaLabel.Name = "id_MateriaLabel";
            id_MateriaLabel.Size = new System.Drawing.Size(57, 13);
            id_MateriaLabel.TabIndex = 3;
            id_MateriaLabel.Text = "Id Materia:";
            // 
            // materiaLabel
            // 
            materiaLabel.AutoSize = true;
            materiaLabel.Location = new System.Drawing.Point(12, 81);
            materiaLabel.Name = "materiaLabel";
            materiaLabel.Size = new System.Drawing.Size(45, 13);
            materiaLabel.TabIndex = 5;
            materiaLabel.Text = "Materia:";
            // 
            // maestroLabel
            // 
            maestroLabel.AutoSize = true;
            maestroLabel.Location = new System.Drawing.Point(12, 125);
            maestroLabel.Name = "maestroLabel";
            maestroLabel.Size = new System.Drawing.Size(48, 13);
            maestroLabel.TabIndex = 7;
            maestroLabel.Text = "Maestro:";
            // 
            // calificacionesLabel
            // 
            calificacionesLabel.AutoSize = true;
            calificacionesLabel.Location = new System.Drawing.Point(12, 163);
            calificacionesLabel.Name = "calificacionesLabel";
            calificacionesLabel.Size = new System.Drawing.Size(75, 13);
            calificacionesLabel.TabIndex = 9;
            calificacionesLabel.Text = "Calificaciones:";
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.Location = new System.Drawing.Point(12, 199);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(44, 13);
            horarioLabel.TabIndex = 11;
            horarioLabel.Text = "Horario:";
            // 
            // fecha_InicioLabel
            // 
            fecha_InicioLabel.AutoSize = true;
            fecha_InicioLabel.Location = new System.Drawing.Point(12, 266);
            fecha_InicioLabel.Name = "fecha_InicioLabel";
            fecha_InicioLabel.Size = new System.Drawing.Size(68, 13);
            fecha_InicioLabel.TabIndex = 13;
            fecha_InicioLabel.Text = "Fecha Inicio:";
            // 
            // fecha_FinLabel
            // 
            fecha_FinLabel.AutoSize = true;
            fecha_FinLabel.Location = new System.Drawing.Point(338, 266);
            fecha_FinLabel.Name = "fecha_FinLabel";
            fecha_FinLabel.Size = new System.Drawing.Size(57, 13);
            fecha_FinLabel.TabIndex = 15;
            fecha_FinLabel.Text = "Fecha Fin:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(725, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calificaciones.Properties.Resources._704676_565898843438595_1716883498_o;
            this.pictureBox1.Location = new System.Drawing.Point(401, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // escuelaDataSet1
            // 
            this.escuelaDataSet1.DataSetName = "EscuelaDataSet1";
            this.escuelaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calificacionesBindingSource
            // 
            this.calificacionesBindingSource.DataMember = "Calificaciones";
            this.calificacionesBindingSource.DataSource = this.escuelaDataSet1;
            // 
            // calificacionesTableAdapter
            // 
            this.calificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalificacionesTableAdapter = this.calificacionesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Calificaciones.EscuelaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calificacionesBindingNavigator
            // 
            this.calificacionesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.calificacionesBindingNavigator.BindingSource = this.calificacionesBindingSource;
            this.calificacionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.calificacionesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.calificacionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.calificacionesBindingNavigatorSaveItem});
            this.calificacionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.calificacionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.calificacionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.calificacionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.calificacionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.calificacionesBindingNavigator.Name = "calificacionesBindingNavigator";
            this.calificacionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.calificacionesBindingNavigator.Size = new System.Drawing.Size(868, 25);
            this.calificacionesBindingNavigator.TabIndex = 2;
            this.calificacionesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // calificacionesBindingNavigatorSaveItem
            // 
            this.calificacionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.calificacionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("calificacionesBindingNavigatorSaveItem.Image")));
            this.calificacionesBindingNavigatorSaveItem.Name = "calificacionesBindingNavigatorSaveItem";
            this.calificacionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.calificacionesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.calificacionesBindingNavigatorSaveItem.Click += new System.EventHandler(this.calificacionesBindingNavigatorSaveItem_Click);
            // 
            // id_MateriaTextBox
            // 
            this.id_MateriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calificacionesBindingSource, "Id Materia", true));
            this.id_MateriaTextBox.Location = new System.Drawing.Point(93, 35);
            this.id_MateriaTextBox.Name = "id_MateriaTextBox";
            this.id_MateriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_MateriaTextBox.TabIndex = 4;
            // 
            // materiaTextBox
            // 
            this.materiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calificacionesBindingSource, "Materia", true));
            this.materiaTextBox.Location = new System.Drawing.Point(93, 78);
            this.materiaTextBox.Name = "materiaTextBox";
            this.materiaTextBox.Size = new System.Drawing.Size(200, 20);
            this.materiaTextBox.TabIndex = 6;
            // 
            // maestroTextBox
            // 
            this.maestroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calificacionesBindingSource, "Maestro", true));
            this.maestroTextBox.Location = new System.Drawing.Point(93, 122);
            this.maestroTextBox.Name = "maestroTextBox";
            this.maestroTextBox.Size = new System.Drawing.Size(200, 20);
            this.maestroTextBox.TabIndex = 8;
            // 
            // calificacionesTextBox
            // 
            this.calificacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calificacionesBindingSource, "Calificaciones", true));
            this.calificacionesTextBox.Location = new System.Drawing.Point(93, 160);
            this.calificacionesTextBox.Name = "calificacionesTextBox";
            this.calificacionesTextBox.Size = new System.Drawing.Size(200, 20);
            this.calificacionesTextBox.TabIndex = 10;
            // 
            // horarioTextBox
            // 
            this.horarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calificacionesBindingSource, "Horario", true));
            this.horarioTextBox.Location = new System.Drawing.Point(93, 196);
            this.horarioTextBox.Name = "horarioTextBox";
            this.horarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.horarioTextBox.TabIndex = 12;
            // 
            // fecha_InicioDateTimePicker
            // 
            this.fecha_InicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.calificacionesBindingSource, "Fecha Inicio", true));
            this.fecha_InicioDateTimePicker.Location = new System.Drawing.Point(93, 266);
            this.fecha_InicioDateTimePicker.Name = "fecha_InicioDateTimePicker";
            this.fecha_InicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_InicioDateTimePicker.TabIndex = 14;
            // 
            // fecha_FinDateTimePicker
            // 
            this.fecha_FinDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.calificacionesBindingSource, "Fecha Fin", true));
            this.fecha_FinDateTimePicker.Location = new System.Drawing.Point(401, 262);
            this.fecha_FinDateTimePicker.Name = "fecha_FinDateTimePicker";
            this.fecha_FinDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_FinDateTimePicker.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(868, 311);
            this.Controls.Add(fecha_FinLabel);
            this.Controls.Add(this.fecha_FinDateTimePicker);
            this.Controls.Add(fecha_InicioLabel);
            this.Controls.Add(this.fecha_InicioDateTimePicker);
            this.Controls.Add(horarioLabel);
            this.Controls.Add(this.horarioTextBox);
            this.Controls.Add(calificacionesLabel);
            this.Controls.Add(this.calificacionesTextBox);
            this.Controls.Add(maestroLabel);
            this.Controls.Add(this.maestroTextBox);
            this.Controls.Add(materiaLabel);
            this.Controls.Add(this.materiaTextBox);
            this.Controls.Add(id_MateriaLabel);
            this.Controls.Add(this.id_MateriaTextBox);
            this.Controls.Add(this.calificacionesBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingNavigator)).EndInit();
            this.calificacionesBindingNavigator.ResumeLayout(false);
            this.calificacionesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EscuelaDataSet1 escuelaDataSet1;
        private System.Windows.Forms.BindingSource calificacionesBindingSource;
        private EscuelaDataSet1TableAdapters.CalificacionesTableAdapter calificacionesTableAdapter;
        private EscuelaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator calificacionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton calificacionesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_MateriaTextBox;
        private System.Windows.Forms.TextBox materiaTextBox;
        private System.Windows.Forms.TextBox maestroTextBox;
        private System.Windows.Forms.TextBox calificacionesTextBox;
        private System.Windows.Forms.TextBox horarioTextBox;
        private System.Windows.Forms.DateTimePicker fecha_InicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_FinDateTimePicker;
    }
}

