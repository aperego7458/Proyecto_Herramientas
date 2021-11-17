
namespace Proyecto_Herramientas
{
    partial class AgendaAdmin
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCita = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtIDBienes = new System.Windows.Forms.TextBox();
            this.txtIdlog = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvInmuebles = new System.Windows.Forms.DataGridView();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIdAgenda = new System.Windows.Forms.TextBox();
            this.btnBuscarAgenda = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(20, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hora de cita";
            // 
            // cbHora
            // 
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "7:00 AM",
            "8:00 AM\t",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 AM",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM"});
            this.cbHora.Location = new System.Drawing.Point(23, 351);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(222, 21);
            this.cbHora.TabIndex = 25;
            this.cbHora.Validated += new System.EventHandler(this.cbHora_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha de cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID propiedad";
            // 
            // dtpCita
            // 
            this.dtpCita.Location = new System.Drawing.Point(23, 297);
            this.dtpCita.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpCita.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpCita.Name = "dtpCita";
            this.dtpCita.Size = new System.Drawing.Size(222, 20);
            this.dtpCita.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(267, 284);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(549, 154);
            this.dgvClientes.TabIndex = 19;
            // 
            // txtIDBienes
            // 
            this.txtIDBienes.Location = new System.Drawing.Point(23, 203);
            this.txtIDBienes.Name = "txtIDBienes";
            this.txtIDBienes.Size = new System.Drawing.Size(222, 20);
            this.txtIDBienes.TabIndex = 18;
            this.txtIDBienes.Validated += new System.EventHandler(this.txtIDBienes_Validated);
            // 
            // txtIdlog
            // 
            this.txtIdlog.Location = new System.Drawing.Point(23, 106);
            this.txtIdlog.Multiline = true;
            this.txtIdlog.Name = "txtIdlog";
            this.txtIdlog.Size = new System.Drawing.Size(222, 20);
            this.txtIdlog.TabIndex = 17;
            this.txtIdlog.Validated += new System.EventHandler(this.txtIdlog_Validated);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(141, 394);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 33);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(76, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 33);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(23, 132);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 34);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvInmuebles
            // 
            this.dgvInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmuebles.Location = new System.Drawing.Point(267, 284);
            this.dgvInmuebles.Name = "dgvInmuebles";
            this.dgvInmuebles.Size = new System.Drawing.Size(549, 200);
            this.dgvInmuebles.TabIndex = 30;
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(267, 90);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(549, 394);
            this.dgvCitas.TabIndex = 31;
            this.dgvCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellClick);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(23, 229);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(90, 34);
            this.btnBuscarP.TabIndex = 32;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 393);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 34);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIdAgenda
            // 
            this.txtIdAgenda.Location = new System.Drawing.Point(573, 31);
            this.txtIdAgenda.Name = "txtIdAgenda";
            this.txtIdAgenda.Size = new System.Drawing.Size(139, 20);
            this.txtIdAgenda.TabIndex = 34;
            // 
            // btnBuscarAgenda
            // 
            this.btnBuscarAgenda.Location = new System.Drawing.Point(726, 23);
            this.btnBuscarAgenda.Name = "btnBuscarAgenda";
            this.btnBuscarAgenda.Size = new System.Drawing.Size(90, 34);
            this.btnBuscarAgenda.TabIndex = 35;
            this.btnBuscarAgenda.Text = "Buscar";
            this.btnBuscarAgenda.UseVisualStyleBackColor = true;
            this.btnBuscarAgenda.Click += new System.EventHandler(this.btnBuscarAgenda_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(17, 24);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 32);
            this.btnAtras.TabIndex = 62;
            this.btnAtras.Text = "<- Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(282, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 45);
            this.label9.TabIndex = 63;
            this.label9.Text = "Citas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(490, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "ID agenda";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // AgendaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(833, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBuscarAgenda);
            this.Controls.Add(this.txtIdAgenda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.dgvInmuebles);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtIDBienes);
            this.Controls.Add(this.txtIdlog);
            this.Name = "AgendaAdmin";
            this.Opacity = 0.93D;
            this.Text = "AgendaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtIDBienes;
        private System.Windows.Forms.TextBox txtIdlog;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvInmuebles;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdAgenda;
        private System.Windows.Forms.Button btnBuscarAgenda;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider epError;
    }
}