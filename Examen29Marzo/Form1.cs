using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen29Marzo
{
    public partial class frmVehiculos : Form
    {
        ClasePila<Vehiculo> pilaVehiculos = new ClasePila<Vehiculo>(); //Se crea la pila de personajes
        DateTime fechaInicio = new DateTime(1990, 1, 1); //Fecha de inicio para generar fechas aleatorias
        Random aleatorio = new Random(); //Se crea un objeto aleatorio del tipo Random para generar números aleatorios
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void AgregarDatagridView() //Método para agregar los datos al DataGridView recorriendo la pila con el ciclo foreach
        {
            try
            {
                dtgDatos.Rows.Clear();
                foreach (Vehiculo unVehiculo in pilaVehiculos)
                {
                    dtgDatos.Rows.Add(unVehiculo.Placas, unVehiculo.Modelo, unVehiculo.Tipo, unVehiculo.CapacidadPasajeros, unVehiculo.NombrePropietario, unVehiculo.CalcularTiempo());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarOperacion(string mensajeConfirmacion, MessageBoxIcon icono) //Método para confirmar cada operación
        {
            string strMensaje = mensajeConfirmacion;
            string strLeyendaMensaje = "Confirmar Operación";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(strMensaje, strLeyendaMensaje, botones, icono);
            if (resultado == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LimpiarControles() //Método para limpiar los controles de la aplicación 
        {
            foreach (Control unControl in grpDatos.Controls)
            {
                if (unControl is TextBox)
                {
                    unControl.Text = "";
                }
                cboTipo.SelectedIndex = 0;
            }
        }

        DateTime DiaAleatorio() //Método que regresa un día aleatorio válido
        {
            int intRango = (DateTime.Today - fechaInicio).Days;
            return fechaInicio.AddDays(aleatorio.Next(intRango));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.MultiSelect = false;
            dtgDatos.ReadOnly = true;
            dtgDatos.AllowUserToResizeColumns = false;
            dtgDatos.AllowUserToResizeRows = false;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.AllowUserToOrderColumns = false;
            dtgDatos.Columns.Add("Placas", "Placas");
            dtgDatos.Columns.Add("Modelo", "Modelo");
            dtgDatos.Columns.Add("Tipo", "Tipo");
            dtgDatos.Columns.Add("Capacidad de Pasajeros", "Capacidad de Pasajeros");
            dtgDatos.Columns.Add("Nombre del Propietario", "Nombre del Propietario");
            dtgDatos.Columns.Add("Hora de Ingreso", "Hora de Ingreso");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarOperacion("¿Está seguro de querer agregar un vehiculo?", MessageBoxIcon.Question))
            {
                try
                {
                    Vehiculo unVehiculo = new Vehiculo();
                    unVehiculo.Placas = txtPlacas.Text;
                    unVehiculo.Modelo = int.Parse(txtModelo.Text);
                    unVehiculo.Tipo = cboTipo.Text;
                    unVehiculo.CapacidadPasajeros = int.Parse(txtCapacidadPasajeros.Text);
                    unVehiculo.NombrePropietario = txtNombrePropietario.Text;
                    unVehiculo.HoraIngreso = DateTime.Now;
                    pilaVehiculos.Push(unVehiculo);
                    AgregarDatagridView();
                    LimpiarControles();
                    btnCamionetasEstacionadas.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo unVehiculoBuscado = new Vehiculo();
                unVehiculoBuscado.Placas = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                MessageBox.Show(pilaVehiculos.BuscarNodo(unVehiculoBuscado).ToString(), "Vehiculo Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarOperacion("¿Está seguro de querer eliminar este vehiculo?", MessageBoxIcon.Warning))
            {
                try
                {
                    Vehiculo unVehiculoEliminado = new Vehiculo();
                    unVehiculoEliminado.Placas = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                    MessageBox.Show(pilaVehiculos.Pop(unVehiculoEliminado).ToString(), "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AgregarDatagridView();
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (ValidarOperacion("¿Está seguro de querer vacíar la pila?", MessageBoxIcon.Warning))
            {
                try
                {
                    pilaVehiculos.Vaciar();
                    dtgDatos.Rows.Clear(); //Se limpian todas las filas del DataGridView
                    LimpiarControles();
                    MessageBox.Show("Se ha vaciado exitosamente la pila", "Pila Vaciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCamionetasEstacionadas.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Vehiculo unVehiculo = new Vehiculo();
                    unVehiculo.Placas = Guid.NewGuid().ToString().Substring(0, 10);
                    unVehiculo.Modelo = aleatorio.Next(1900, 2024);
                    switch (aleatorio.Next(0,3))
                    {
                        case 0: unVehiculo.Tipo = "Sedán"; break;
                        case 1: unVehiculo.Tipo = "Camioneta"; break;
                        case 2: unVehiculo.Tipo = "Vagoneta"; break;
                        default: unVehiculo.Tipo = "Sedán"; break;
                    }
                    unVehiculo.CapacidadPasajeros = aleatorio.Next(2, 10);
                    unVehiculo.NombrePropietario = Guid.NewGuid().ToString().Substring(0, 6);
                    unVehiculo.HoraIngreso = DiaAleatorio();
                    pilaVehiculos.Push(unVehiculo); //Se agrega el objeto a la pila
                    AgregarDatagridView(); //Se agregan los datos al DataGridView
                    LimpiarControles(); //Se limpian los controles
                    btnCamionetasEstacionadas.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarTop_Click(object sender, EventArgs e)
        {
            if (ValidarOperacion("¿Está seguro de querer eliminar el primer vehiculo?", MessageBoxIcon.Warning))
            {
                try
                {
                    Vehiculo unVehiculoEliminado = new Vehiculo();
                    MessageBox.Show(pilaVehiculos.Pop().ToString(), "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AgregarDatagridView();
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtPlacas.Text = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                txtModelo.Text = dtgDatos.CurrentRow.Cells[1].Value.ToString();
                cboTipo.Text = dtgDatos.CurrentRow.Cells[2].Value.ToString(); 
                txtCapacidadPasajeros.Text = dtgDatos.CurrentRow.Cells[3].Value.ToString();
                txtNombrePropietario.Text = dtgDatos.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int DevolverCantidadCamionetasEstacionadas()
        {
            int intCantidadCamionetas;
            intCantidadCamionetas = 0;
            foreach (Vehiculo unVehiculo in pilaVehiculos)
            {
                if (unVehiculo.Tipo == "Camioneta")
                {
                    intCantidadCamionetas++;
                }
            }
            return intCantidadCamionetas;
        }
        private void btnCamionetasEstacionadas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad de camionetas estacionadas: "+DevolverCantidadCamionetasEstacionadas().ToString() , "Vehiculo Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
