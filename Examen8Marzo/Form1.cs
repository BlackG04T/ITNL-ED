using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen8Marzo
{
    public partial class frmFerias : Form
    {
        ClaseListaOrdenadaSimple<Feria> listaFerias = new ClaseListaOrdenadaSimple<Feria>(); //Se crea la lista de Ferias
        Random aleatorio = new Random(); //Se crea un objeto aleatorio del tipo Random para generar números aleatorios
        DateTime fechaInicio = new DateTime(1990, 1, 1); //Fecha de inicio para generar fechas aleatorias

        public frmFerias()
        {
            InitializeComponent();
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

        private void AgregarDatagridView() //Método para agregar los datos al DataGridView recorriendo la lista con el ciclo foreach
        {
            try
            {
                dtgDatos.Rows.Clear();
                foreach (Feria unaFeria in listaFerias)
                {
                    dtgDatos.Rows.Add(unaFeria.VisitantesDiarios, unaFeria.Nombre, unaFeria.IDFeria, unaFeria.NivelSeguridadJuegos , unaFeria.PrecioEntrada, unaFeria.FechaApertura.ToShortDateString(), unaFeria.TodasEdades ? "Si" : "No", unaFeria.AtraccionPrincipal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles() //Método para limpiar los controles de la aplicación 
        {
            txtIDFeria.Clear();
            txtVisitantesDiarios.Clear();
            txtPrecioEntrada.Clear();
            txtIDFeria.Clear();
            dtgDatos.ClearSelection();
            cboAtraccionPrincipal.SelectedIndex = 0;
            cboNivelSeguridadJuegos.SelectedIndex = 0;
            chkTodasEdades.Checked = false;
            dtmFechaApertura.Value = DateTime.Now;
        }

        DateTime DiaAleatorio() //Método que regresa un día aleatorio válido
        {
            int intRango = (DateTime.Today - fechaInicio).Days;
            return fechaInicio.AddDays(aleatorio.Next(intRango));
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                lstObjetos.Items.Clear();
                Feria unaFeria = new Feria();
                unaFeria.VisitantesDiarios = int.Parse(txtVisitantesDiarios.Text);
                unaFeria.Nombre = txtNombre.Text;
                unaFeria.IDFeria = int.Parse(txtIDFeria.Text);
                unaFeria.PrecioEntrada = double.Parse(txtPrecioEntrada.Text);
                unaFeria.FechaApertura = dtmFechaApertura.Value;
                unaFeria.TodasEdades = chkTodasEdades.Checked;
                unaFeria.AtraccionPrincipal = cboAtraccionPrincipal.Text;
                unaFeria.NivelSeguridadJuegos = char.Parse(cboNivelSeguridadJuegos.Text);
                listaFerias.AgregarNodo(unaFeria);
                AgregarDatagridView();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarOperacion("¿Está seguro de querer eliminar este Feria?", MessageBoxIcon.Warning))
            {
                try
                {
                    Feria unaFeriaEliminado = new Feria();
                    unaFeriaEliminado.IDFeria = int.Parse(txtIDFeria.Text);
                    MessageBox.Show(listaFerias.BuscarNodo(unaFeriaEliminado).ToString(), "Feria Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listaFerias.EliminarNodo(unaFeriaEliminado);
                    lstObjetos.Items.Clear();
                    AgregarDatagridView();
                    LimpiarControles();
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
                Feria unaFeriaBuscada = new Feria();
                unaFeriaBuscada.IDFeria = int.Parse(txtIDFeria.Text);
                LimpiarControles();
                unaFeriaBuscada = listaFerias.BuscarNodo(unaFeriaBuscada);
                txtVisitantesDiarios.Text = unaFeriaBuscada.VisitantesDiarios.ToString();
                txtIDFeria.Text = unaFeriaBuscada.IDFeria.ToString();
                txtNombre.Text = unaFeriaBuscada.Nombre.ToString();
                cboAtraccionPrincipal.Text = unaFeriaBuscada.AtraccionPrincipal;
                cboNivelSeguridadJuegos.Text = unaFeriaBuscada.NivelSeguridadJuegos.ToString();
                dtmFechaApertura.Value = unaFeriaBuscada.FechaApertura;
                chkTodasEdades.Checked = unaFeriaBuscada.TodasEdades == true ? true : false;
                MessageBox.Show(listaFerias.BuscarNodo(unaFeriaBuscada).ToString(), "Feria Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (ValidarOperacion("¿Está seguro de querer vacíar la lista?", MessageBoxIcon.Warning))
            {
                try
                {
                    lstObjetos.Items.Clear();
                    listaFerias.Vaciar();
                    dtgDatos.Rows.Clear(); //Se limpian todas las filas del DataGridView
                    LimpiarControles();
                    MessageBox.Show("Se ha vaciado exitosamente la lista", "Lista Vaciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (ValidarOperacion("¿Está seguro de querer generar Ferias?", MessageBoxIcon.Question))
            {
                try
                {
                    lstObjetos.Items.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        Feria unaFeria = new Feria();
                        unaFeria.VisitantesDiarios = aleatorio.Next(50);
                        unaFeria.Nombre = Guid.NewGuid().ToString().Substring(0, 10);
                        unaFeria.IDFeria = aleatorio.Next(0, 99999);
                        unaFeria.PrecioEntrada = Math.Round(aleatorio.NextDouble() * 60, 2);
                        switch (aleatorio.Next(0, 4))
                        {
                            case 0: unaFeria.AtraccionPrincipal = "Montaña Rusa"; break;
                            case 1: unaFeria.AtraccionPrincipal = "Himalaya"; break;
                            case 2: unaFeria.AtraccionPrincipal = "Martillo"; break;
                            case 3: unaFeria.AtraccionPrincipal = "Avalancha"; break;
                            default: unaFeria.AtraccionPrincipal = "Montaña Rusa"; break;
                        }
                        switch (aleatorio.Next(0, 4))
                        {
                            case 0: unaFeria.NivelSeguridadJuegos = 'A'; break;
                            case 1: unaFeria.NivelSeguridadJuegos = 'B'; break;
                            case 2: unaFeria.NivelSeguridadJuegos = 'C'; break;
                            case 3: unaFeria.NivelSeguridadJuegos = 'D'; break;
                            default: unaFeria.NivelSeguridadJuegos = 'A'; break;
                        }
                        unaFeria.FechaApertura = DiaAleatorio();
                        unaFeria.TodasEdades = aleatorio.Next(0, 2) == 1 ? true : false;
                        listaFerias.AgregarNodo(unaFeria); //Se agrega el objeto a la lista
                        AgregarDatagridView(); //Se agregan los datos al DataGridView
                        LimpiarControles(); //Se limpian los controles
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            dtgDatos.Columns.Add("Visitantes diarios", "Visitantes diarios");
            dtgDatos.Columns.Add("Nombre", "Nombre");
            dtgDatos.Columns.Add("IDFeria", "IDFeria");
            dtgDatos.Columns.Add("Nivel de seguridad en juegos", "Nivel de seguridad en juegos");
            dtgDatos.Columns.Add("Precio de entrada", "Precio de entrada");
            dtgDatos.Columns.Add("Fecha de apertura", "Fecha de apertura");
            dtgDatos.Columns.Add("Es para todas las edades", "Es para todas las edades");
            dtgDatos.Columns.Add("Atraccion principal", "Atraccion principal");
        }

       
        private void grpDatos_Enter(object sender, EventArgs e)
        {
            LimpiarControles();
        }

       
        private void DevolverObjetosMenos37VisitantesDiarios()
        {
            lstObjetos.Items.Clear();
            foreach (Feria unaFeria in listaFerias)
            {
                if (unaFeria.VisitantesDiarios < 37)
                {
                    lstObjetos.Items.Add(unaFeria);
                }
            }
        }
        private void btnMostrarObjetos_Click(object sender, EventArgs e)
        {
            try
            {
                DevolverObjetosMenos37VisitantesDiarios(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVisitantesDiarios.Text = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgDatos.CurrentRow.Cells[1].Value.ToString();
            txtIDFeria.Text = dtgDatos.CurrentRow.Cells[2].Value.ToString();
            cboNivelSeguridadJuegos.Text = dtgDatos.CurrentRow.Cells[3].Value.ToString();
            txtPrecioEntrada.Text = dtgDatos.CurrentRow.Cells[4].Value.ToString();
            dtmFechaApertura.Value = DateTime.Parse(dtgDatos.CurrentRow.Cells[5].Value.ToString());
            chkTodasEdades.Checked = dtgDatos.CurrentRow.Cells[6].Value.ToString() == "Si" ? true : false;
            cboAtraccionPrincipal.Text = dtgDatos.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
