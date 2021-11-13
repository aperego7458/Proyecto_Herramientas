
namespace Proyecto_Herramientas
{
    partial class Bienes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPFotos = new System.Windows.Forms.TextBox();
            this.txtPPrecio = new System.Windows.Forms.TextBox();
            this.txtPCiudad = new System.Windows.Forms.TextBox();
            this.txtPDireccion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBienes = new System.Windows.Forms.DataGridView();
            this.txtChabitaciones = new System.Windows.Forms.TextBox();
            this.txtCbanos = new System.Windows.Forms.TextBox();
            this.txtIdPropiedad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.epError1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(510, 416);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 31);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(304, 416);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 31);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(110, 416);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 31);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 36);
            this.label7.TabIndex = 31;
            this.label7.Text = "Propiedades";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fotos (Link)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cantidad baños";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cantidad habitaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ciudad";
            // 
            // txtPFotos
            // 
            this.txtPFotos.Location = new System.Drawing.Point(26, 348);
            this.txtPFotos.Name = "txtPFotos";
            this.txtPFotos.Size = new System.Drawing.Size(180, 20);
            this.txtPFotos.TabIndex = 23;
            this.txtPFotos.Validated += new System.EventHandler(this.txtPFotos_Validated);
            // 
            // txtPPrecio
            // 
            this.txtPPrecio.Location = new System.Drawing.Point(26, 295);
            this.txtPPrecio.Name = "txtPPrecio";
            this.txtPPrecio.Size = new System.Drawing.Size(180, 20);
            this.txtPPrecio.TabIndex = 22;
            this.txtPPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPPrecio_KeyPress);
            this.txtPPrecio.Validated += new System.EventHandler(this.txtPPrecio_Validated);
            // 
            // txtPCiudad
            // 
            this.txtPCiudad.Location = new System.Drawing.Point(26, 81);
            this.txtPCiudad.Name = "txtPCiudad";
            this.txtPCiudad.Size = new System.Drawing.Size(180, 20);
            this.txtPCiudad.TabIndex = 18;
            this.txtPCiudad.Validated += new System.EventHandler(this.txtPCiudad_Validated);
            // 
            // txtPDireccion
            // 
            this.txtPDireccion.Location = new System.Drawing.Point(26, 135);
            this.txtPDireccion.Name = "txtPDireccion";
            this.txtPDireccion.Size = new System.Drawing.Size(180, 20);
            this.txtPDireccion.TabIndex = 19;
            this.txtPDireccion.Validated += new System.EventHandler(this.txtPDireccion_Validated);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(645, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 31);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvBienes
            // 
            this.dgvBienes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBienes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBienes.Location = new System.Drawing.Point(224, 62);
            this.dgvBienes.Name = "dgvBienes";
            this.dgvBienes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBienes.Size = new System.Drawing.Size(550, 329);
            this.dgvBienes.TabIndex = 28;
            this.dgvBienes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBienes_CellClick);
            this.dgvBienes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtChabitaciones
            // 
            this.txtChabitaciones.Location = new System.Drawing.Point(26, 192);
            this.txtChabitaciones.Name = "txtChabitaciones";
            this.txtChabitaciones.Size = new System.Drawing.Size(180, 20);
            this.txtChabitaciones.TabIndex = 20;
            this.txtChabitaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChabitaciones_KeyPress);
            this.txtChabitaciones.Validated += new System.EventHandler(this.txtChabitaciones_Validated);
            // 
            // txtCbanos
            // 
            this.txtCbanos.Location = new System.Drawing.Point(26, 241);
            this.txtCbanos.Name = "txtCbanos";
            this.txtCbanos.Size = new System.Drawing.Size(180, 20);
            this.txtCbanos.TabIndex = 21;
            this.txtCbanos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCbanos_KeyPress);
            this.txtCbanos.Validated += new System.EventHandler(this.txtCbanos_Validated);
            // 
            // txtIdPropiedad
            // 
            this.txtIdPropiedad.Location = new System.Drawing.Point(500, 24);
            this.txtIdPropiedad.Name = "txtIdPropiedad";
            this.txtIdPropiedad.Size = new System.Drawing.Size(139, 20);
            this.txtIdPropiedad.TabIndex = 32;
            this.txtIdPropiedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPropiedad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID PROPIEDAD";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // epError1
            // 
            this.epError1.ContainerControl = this;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(26, 14);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 32);
            this.btnAtras.TabIndex = 62;
            this.btnAtras.Text = "<- Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Bienes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdPropiedad);
            this.Controls.Add(this.txtCbanos);
            this.Controls.Add(this.txtChabitaciones);
            this.Controls.Add(this.dgvBienes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPFotos);
            this.Controls.Add(this.txtPPrecio);
            this.Controls.Add(this.txtPCiudad);
            this.Controls.Add(this.txtPDireccion);
            this.Name = "Bienes";
            this.Text = "Bienes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPFotos;
        private System.Windows.Forms.TextBox txtPPrecio;
        private System.Windows.Forms.TextBox txtPCiudad;
        private System.Windows.Forms.TextBox txtPDireccion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBienes;
        private System.Windows.Forms.TextBox txtChabitaciones;
        private System.Windows.Forms.TextBox txtCbanos;
        private System.Windows.Forms.TextBox txtIdPropiedad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider epError1;
        private System.Windows.Forms.Button btnAtras;
    }
}