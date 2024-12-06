namespace Proyecto_CRUD_DatosPersona
{
    partial class Form1
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
            this.Nombre = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCelular = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(35, 106);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(35, 147);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(32, 13);
            this.Edad.TabIndex = 1;
            this.Edad.Text = "Edad";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Location = new System.Drawing.Point(35, 191);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(39, 13);
            this.Celular.TabIndex = 2;
            this.Celular.Text = "Celular";
            this.Celular.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(96, 265);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(100, 23);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Actualizar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.BurlyWood;
            this.textNombre.Location = new System.Drawing.Point(96, 99);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 4;
            // 
            // textCelular
            // 
            this.textCelular.BackColor = System.Drawing.Color.BurlyWood;
            this.textCelular.Location = new System.Drawing.Point(96, 184);
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(100, 20);
            this.textCelular.TabIndex = 5;
            // 
            // textEdad
            // 
            this.textEdad.BackColor = System.Drawing.Color.BurlyWood;
            this.textEdad.Location = new System.Drawing.Point(96, 140);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(100, 20);
            this.textEdad.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 379);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(39, 62);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 9;
            this.Id.Text = "Id";
            this.Id.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.BurlyWood;
            this.textId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textId.Location = new System.Drawing.Point(96, 55);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 10;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(96, 345);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 23);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(96, 306);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(100, 23);
            this.buttonLimpiar.TabIndex = 12;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(96, 221);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 23);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textCelular);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCelular;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonAgregar;
    }
}

