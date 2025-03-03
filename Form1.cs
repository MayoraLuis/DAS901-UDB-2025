using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //Libreria para usar graficos 


namespace HotelReservacionesGUI
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes = new List<Cliente>(); // Lista de clientes registrados
        private Dictionary<int, Reservacion> reservaciones = new Dictionary<int, Reservacion>(); // Diccionario de reservaciones
        private Habitacion[,] habitaciones = new Habitacion[5, 10]; // Matriz de habitaciones (5 pisos x 10 habitaciones)

        public Form1()
        {
            InitializeComponent();
            InicializarHabitaciones();
            CargarHabitacionesEnComboBox();
            ActualizarHabitacionesGrid();
            ActualizarGraficoEstadisticas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí puede inicializar datos cuando se carga el formulario
            MessageBox.Show("Bienvenido al sistema de reservaciones.");
        }

        private void InicializarHabitaciones()
        {
            Random random = new Random();
            string[] tipos = { "Sencilla", "Doble", "Suite" };
            double[] precios = { 50.0, 100.0, 200.0 };

            for (int piso = 0; piso < 5; piso++)
            {
                for (int num = 0; num < 10; num++)
                {
                    int tipoIndex = random.Next(0, 3);
                    habitaciones[piso, num] = new Habitacion((piso * 10) + (num + 1), tipos[tipoIndex], precios[tipoIndex]);
                }
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string documento = txtDocumento.Text.Trim().ToLower();
            string telefono = txtTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clientes.Exists(c => c.Documento == documento))
            {
                MessageBox.Show("El cliente ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente nuevoCliente = new Cliente(nombre, documento, telefono);
            clientes.Add(nuevoCliente);

            ActualizarClientesGrid();

            MessageBox.Show($"Cliente {nombre} registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
        }

        private void ActualizarClientesGrid()
        {
            dgvClientes.Rows.Clear();
            foreach (var cliente in clientes)
            {
                dgvClientes.Rows.Add(cliente.Nombre, cliente.Documento, cliente.Telefono);
            }
        }

        private void ActualizarHabitacionesGrid()
        {
            dgvHabitaciones.Rows.Clear();
            for (int piso = 0; piso < 5; piso++)
            {
                for (int num = 0; num < 10; num++)
                {
                    var hab = habitaciones[piso, num];
                    dgvHabitaciones.Rows.Add(hab.Numero, hab.Tipo, hab.PrecioPorNoche, hab.Disponible ? "Disponible" : "Ocupada");
                }
            }
        }

        private void CargarHabitacionesEnComboBox()
        {
            cbHabitaciones.Items.Clear();
            for (int piso = 0; piso < 5; piso++)
            {
                for (int num = 0; num < 10; num++)
                {
                    if (habitaciones[piso, num].Disponible)
                    {
                        cbHabitaciones.Items.Add(habitaciones[piso, num].Numero);
                    }
                }
            }
        }

        private void CargarHabitacionesReservadas()
        {
            cbHabitacionesReservadas.Items.Clear();
            foreach (var numHabitacion in reservaciones.Keys)
            {
                cbHabitacionesReservadas.Items.Add(numHabitacion);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (clientes.Count == 0)
            {
                MessageBox.Show("No hay clientes registrados. Por favor, registre un cliente antes de reservar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = clientes.Last();
            int noches = (int)nudNoches.Value;

            if (cbHabitaciones.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numeroHabitacion = int.Parse(cbHabitaciones.SelectedItem.ToString());
            Habitacion habitacion = habitaciones[(numeroHabitacion - 1) / 10, (numeroHabitacion - 1) % 10];

            if (!habitacion.Disponible)
            {
                MessageBox.Show("La habitación ya está ocupada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Reservacion reservacion = new Reservacion(cliente, habitacion, noches);
            reservaciones[numeroHabitacion] = reservacion;
            habitacion.Disponible = false;

            MessageBox.Show($" Reservación creada para {cliente.Nombre} en habitación {numeroHabitacion} por {noches} noches.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizar la interfaz de usuario
            ActualizarReservacionesGrid();
            CargarHabitacionesEnComboBox();
            CargarHabitacionesReservadas();
            ActualizarHabitacionesGrid();
            ActualizarGraficoEstadisticas();
        }

        private void ActualizarReservacionesGrid()
        {
            dgvReservaciones.Rows.Clear();
            foreach (var res in reservaciones.Values)
            {
                dgvReservaciones.Rows.Add(res.Cliente.Nombre, res.Cliente.Documento, res.Habitacion.Numero, res.Noches, res.MontoTotal);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (reservaciones.Count == 0)
            {
                MessageBox.Show("No hay reservaciones activas.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje = " Reservaciones Activas:\n";
            foreach (var res in reservaciones.Values)
            {
                mensaje += $" Cliente: {res.Cliente.Nombre} - Habitación: {res.Habitacion.Numero} - Noches: {res.Noches} - Total: ${res.MontoTotal}\n";
            }

            MessageBox.Show(mensaje, "Reservaciones Activas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelarReservacion_Click(object sender, EventArgs e)
        {
            if (cbHabitacionesReservadas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una habitación reservada para cancelar la reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numeroHabitacion = int.Parse(cbHabitacionesReservadas.SelectedItem.ToString());

            if (reservaciones.ContainsKey(numeroHabitacion))
            {
                // Marca la habitación como disponible
                reservaciones[numeroHabitacion].Habitacion.Disponible = true;

                // Elimina la reservación
                reservaciones.Remove(numeroHabitacion);

                MessageBox.Show($" Reservación de la Habitación {numeroHabitacion} cancelada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la interfaz de usuario
                ActualizarReservacionesGrid();
                CargarHabitacionesEnComboBox();
                CargarHabitacionesReservadas();
                ActualizarHabitacionesGrid();
                ActualizarGraficoEstadisticas();
            }
            else
            {
                MessageBox.Show("No hay una reservación en esta habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etiqueta clickeada.");
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Hiciste clic en la fila {e.RowIndex} y columna {e.ColumnIndex}.");
        }

        //Metodo para actualizacion de graficos
        private void ActualizarGraficoEstadisticas()
        {
            if (chartEstadisticas == null)
            {
                MessageBox.Show("Error: No se encontró el gráfico de estadísticas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chartEstadisticas.Series.Clear(); // Limpiar gráfico
            chartEstadisticas.ChartAreas.Clear(); // Limpiar áreas previas

            //Crear Área para Gráfico de Pie (Estado de Habitaciones)
            ChartArea areaPie = new ChartArea("PieArea");
            chartEstadisticas.ChartAreas.Add(areaPie);

            //Crear Serie para Habitaciones Disponibles vs. Ocupadas
            Series serieEstadoHabitaciones = new Series("Estado de Habitaciones")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "PieArea"
            };

            int habitacionesDisponibles = habitaciones.Cast<Habitacion>().Count(h => h.Disponible);
            int habitacionesOcupadas = habitaciones.Cast<Habitacion>().Count(h => !h.Disponible);

            serieEstadoHabitaciones.Points.AddXY("Disponibles", habitacionesDisponibles);
            serieEstadoHabitaciones.Points.AddXY("Ocupadas", habitacionesOcupadas);

            chartEstadisticas.Series.Add(serieEstadoHabitaciones);

            //Crear Área para Gráfico de Columnas (Tipos de Habitaciones)
            ChartArea areaColumnas = new ChartArea("ColumnArea");
            chartEstadisticas.ChartAreas.Add(areaColumnas);

            //Crear Serie para Tipos de Habitaciones Reservadas
            Series serieTiposHabitaciones = new Series("Tipos de Habitaciones")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "ColumnArea"
            };

            int sencillas = reservaciones.Values.Count(r => r.Habitacion.Tipo == "Sencilla");
            int dobles = reservaciones.Values.Count(r => r.Habitacion.Tipo == "Doble");
            int suites = reservaciones.Values.Count(r => r.Habitacion.Tipo == "Suite");

            serieTiposHabitaciones.Points.AddXY("Sencilla", sencillas);
            serieTiposHabitaciones.Points.AddXY("Doble", dobles);
            serieTiposHabitaciones.Points.AddXY("Suite", suites);

            chartEstadisticas.Series.Add(serieTiposHabitaciones);
        }
    }
}