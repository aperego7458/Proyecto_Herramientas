
namespace Proyecto_Herramientas
{
    partial class Agenda
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
            this.dgvInmueble = new System.Windows.Forms.DataGridView();
            this.txtIDBienes = new System.Windows.Forms.TextBox();
            this.txtIdlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCita = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmueble)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInmueble
            // 
            this.dgvInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmueble.Location = new System.Drawing.Point(260, 53);
            this.dgvInmueble.Name = "dgvInmueble";
            this.dgvInmueble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInmueble.Size = new System.Drawing.Size(651, 366);
            this.dgvInmueble.TabIndex = 8;
            this.dgvInmueble.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInmueble_CellClick);
            this.dgvInmueble.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInmueble_CellContentClick);
            // 
            // txtIDBienes
            // 
            this.txtIDBienes.Enabled = false;
            this.txtIDBienes.Location = new System.Drawing.Point(22, 172);
            this.txtIDBienes.Name = "txtIDBienes";
            this.txtIDBienes.Size = new System.Drawing.Size(222, 20);
            this.txtIDBienes.TabIndex = 7;
            // 
            // txtIdlog
            // 
            this.txtIdlog.Enabled = false;
            this.txtIdlog.Location = new System.Drawing.Point(22, 120);
            this.txtIdlog.Multiline = true;
            this.txtIdlog.Name = "txtIdlog";
            this.txtIdlog.Size = new System.Drawing.Size(222, 20);
            this.txtIdlog.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tu ID";
            // 
            // dtpCita
            // 
            this.dtpCita.Location = new System.Drawing.Point(22, 229);
            this.dtpCita.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpCita.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpCita.Name = "dtpCita";
            this.dtpCita.Size = new System.Drawing.Size(222, 20);
            this.dtpCita.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID propiedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de cita";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(78, 350);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(104, 34);
            this.btnAgendar.TabIndex = 14;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
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
            this.cbHora.Location = new System.Drawing.Point(22, 283);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(222, 21);
            this.cbHora.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hora de cita";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 36);
            this.label7.TabIndex = 32;
            this.label7.Text = "Agendar cita";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cerrar sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInmueble);
            this.Controls.Add(this.txtIDBienes);
            this.Controls.Add(this.txtIdlog);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmueble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInmueble;
        private System.Windows.Forms.TextBox txtIDBienes;
        private System.Windows.Forms.TextBox txtIdlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}