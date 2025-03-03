namespace HotelReservacionesGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbReservacion = new System.Windows.Forms.GroupBox();
            this.cbHabitacionesReservadas = new System.Windows.Forms.ComboBox();
            this.btnCancelarReservacion = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.nudNoches = new System.Windows.Forms.NumericUpDown();
            this.lblNoches = new System.Windows.Forms.Label();
            this.cbHabitaciones = new System.Windows.Forms.ComboBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReservaciones = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.gbReservacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Tipo,
            this.Precio,
            this.Estado});
            this.dgvHabitaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvHabitaciones.Location = new System.Drawing.Point(263, 12);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(460, 162);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número de Habitación";
            this.Numero.Name = "Numero";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de Habitación";
            this.Tipo.Name = "Tipo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio por Noche";
            this.Precio.Name = "Precio";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbCliente.Controls.Add(this.btnRegistrarCliente);
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.lblTelefono);
            this.gbCliente.Controls.Add(this.txtDocumento);
            this.gbCliente.Controls.Add(this.lblDocumento);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.Color.White;
            this.gbCliente.Location = new System.Drawing.Point(12, 189);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(343, 146);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(207, 117);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(96, 23);
            this.btnRegistrarCliente.TabIndex = 6;
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(87, 103);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 23);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 104);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(63, 16);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(87, 69);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 23);
            this.txtDocumento.TabIndex = 3;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(6, 72);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(80, 16);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Documento:";
            this.lblDocumento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // gbReservacion
            // 
            this.gbReservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbReservacion.Controls.Add(this.cbHabitacionesReservadas);
            this.gbReservacion.Controls.Add(this.btnCancelarReservacion);
            this.gbReservacion.Controls.Add(this.btnConsultar);
            this.gbReservacion.Controls.Add(this.btnReservar);
            this.gbReservacion.Controls.Add(this.nudNoches);
            this.gbReservacion.Controls.Add(this.lblNoches);
            this.gbReservacion.Controls.Add(this.cbHabitaciones);
            this.gbReservacion.Controls.Add(this.lblHabitacion);
            this.gbReservacion.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReservacion.ForeColor = System.Drawing.Color.White;
            this.gbReservacion.Location = new System.Drawing.Point(504, 180);
            this.gbReservacion.Name = "gbReservacion";
            this.gbReservacion.Size = new System.Drawing.Size(544, 140);
            this.gbReservacion.TabIndex = 2;
            this.gbReservacion.TabStop = false;
            this.gbReservacion.Text = "Reservaciones";
            // 
            // cbHabitacionesReservadas
            // 
            this.cbHabitacionesReservadas.BackColor = System.Drawing.Color.White;
            this.cbHabitacionesReservadas.ForeColor = System.Drawing.Color.White;
            this.cbHabitacionesReservadas.FormattingEnabled = true;
            this.cbHabitacionesReservadas.Location = new System.Drawing.Point(389, 94);
            this.cbHabitacionesReservadas.Name = "cbHabitacionesReservadas";
            this.cbHabitacionesReservadas.Size = new System.Drawing.Size(45, 24);
            this.cbHabitacionesReservadas.TabIndex = 7;
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.BackColor = System.Drawing.Color.Red;
            this.btnCancelarReservacion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarReservacion.Location = new System.Drawing.Point(248, 94);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(135, 24);
            this.btnCancelarReservacion.TabIndex = 6;
            this.btnCancelarReservacion.Text = "Cancelar Reservación";
            this.btnCancelarReservacion.UseVisualStyleBackColor = false;
            this.btnCancelarReservacion.Click += new System.EventHandler(this.btnCancelarReservacion_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(250, 39);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(135, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar Reservaciones";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(87, 111);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(119, 23);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reservar Habitación";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // nudNoches
            // 
            this.nudNoches.Location = new System.Drawing.Point(88, 70);
            this.nudNoches.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNoches.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoches.Name = "nudNoches";
            this.nudNoches.Size = new System.Drawing.Size(120, 23);
            this.nudNoches.TabIndex = 3;
            this.nudNoches.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Location = new System.Drawing.Point(6, 72);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(55, 16);
            this.lblNoches.TabIndex = 2;
            this.lblNoches.Text = "Noches:";
            // 
            // cbHabitaciones
            // 
            this.cbHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabitaciones.FormattingEnabled = true;
            this.cbHabitaciones.Location = new System.Drawing.Point(87, 33);
            this.cbHabitaciones.Name = "cbHabitaciones";
            this.cbHabitaciones.Size = new System.Drawing.Size(121, 24);
            this.cbHabitaciones.TabIndex = 1;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(6, 39);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(75, 16);
            this.lblHabitacion.TabIndex = 0;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Documento,
            this.Telefono});
            this.dgvClientes.Location = new System.Drawing.Point(12, 335);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(344, 106);
            this.dgvClientes.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // dgvReservaciones
            // 
            this.dgvReservaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Document,
            this.Habitacion,
            this.Noches,
            this.Total});
            this.dgvReservaciones.Location = new System.Drawing.Point(504, 320);
            this.dgvReservaciones.Name = "dgvReservaciones";
            this.dgvReservaciones.Size = new System.Drawing.Size(544, 112);
            this.dgvReservaciones.TabIndex = 4;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Document
            // 
            this.Document.HeaderText = "Documento";
            this.Document.Name = "Document";
            // 
            // Habitacion
            // 
            this.Habitacion.HeaderText = "Habitación";
            this.Habitacion.Name = "Habitacion";
            // 
            // Noches
            // 
            this.Noches.HeaderText = "Noches";
            this.Noches.Name = "Noches";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total a pagar";
            this.Total.Name = "Total";
            // 
            // chartEstadisticas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEstadisticas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEstadisticas.Legends.Add(legend1);
            this.chartEstadisticas.Location = new System.Drawing.Point(385, 449);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEstadisticas.Series.Add(series1);
            this.chartEstadisticas.Size = new System.Drawing.Size(293, 220);
            this.chartEstadisticas.TabIndex = 5;
            this.chartEstadisticas.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1100, 681);
            this.Controls.Add(this.chartEstadisticas);
            this.Controls.Add(this.dgvReservaciones);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gbReservacion);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.dgvHabitaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbReservacion.ResumeLayout(false);
            this.gbReservacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox gbReservacion;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.NumericUpDown nudNoches;
        private System.Windows.Forms.Label lblNoches;
        private System.Windows.Forms.ComboBox cbHabitaciones;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelarReservacion;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvReservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cbHabitacionesReservadas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
    }
}

