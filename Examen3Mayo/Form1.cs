using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen3Mayo
{
    public partial class Form1 : Form
    {
        ClaseABB<Cliente> ABBClientes = new ClaseABB<Cliente>();
        Random aleatorio = new Random();
        DateTime fechaInicio = new DateTime(1990, 1, 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDatos.Columns.Add("IDCliente", "IDCliente");
            dtgDatos.Columns.Add("Nombre", "Nombre");
            dtgDatos.Columns.Add("Altura", "Altura");
            dtgDatosAlfabeticamente.Columns.Add("IDCliente", "IDCliente");
            dtgDatosAlfabeticamente.Columns.Add("Nombre", "Nombre");
            dtgDatosAlfabeticamente.Columns.Add("Altura", "Altura");
        }
        private void AgregarDatagridView()
        {
            try
            {
                if (radPostOrden.Checked)
                {
                    dtgDatos.Rows.Clear();
                    foreach (Cliente unCliente in ABBClientes.RecorrerPostOrden())
                    {
                        dtgDatos.Rows.Add(unCliente.IDCliente, unCliente.Nombre, unCliente.Altura + "m");
                    }
                }
                else if (radPreOrden.Checked)
                {
                    dtgDatos.Rows.Clear();
                    foreach (Cliente unCliente in ABBClientes.RecorrerPreOrden())
                    {
                        dtgDatos.Rows.Add(unCliente.IDCliente, unCliente.Nombre, unCliente.Altura + "m");
                    }
                }
                else if (radInOrden.Checked)
                {
                    dtgDatos.Rows.Clear();
                    foreach (Cliente unCliente in ABBClientes.RecorrerInOrden())
                    {
                        dtgDatos.Rows.Add(unCliente.IDCliente, unCliente.Nombre, unCliente.Altura + "m");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarOperacion(string mensajeConfirmacion, MessageBoxIcon icono)
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
        private void LimpiarControles()
        {
            txtIDCliente.Clear();
            txtNombre.Clear();
            txtAltura.Clear();
            dtgDatos.ClearSelection();
        }

        private void DibujarFigura()
        {
            string strResultado = CrearArchivoDot();
            picABB.LoadAsync("https://quickchart.io/graphviz?format=png&graph=" + strResultado); //Uso de la API de GraphViz de Quickchart para dibujar el ABB
            MessageBox.Show($"{strResultado}", "ABB en lenguaje dot");
        }

        private string CrearArchivoDot()
        {
            string strResultado = "";
            ABBClientes.CrearArchivoDot(ref strResultado);
            using (var fs = new FileStream(Application.StartupPath + "arbol.txt", FileMode.Create, FileAccess.ReadWrite)) //Creación de archivo de texto en memoria para evitar el formato string con secuencias de escape
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.Write(strResultado);
                    tw.Flush();
                }
            }
            File.Delete(Application.StartupPath + "arbol.txt");
            return strResultado;
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDCliente.Text = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dtgDatos.CurrentRow.Cells[1].Value.ToString();
                txtAltura.Text = dtgDatos.CurrentRow.Cells[2].Value.ToString().TrimEnd('m');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ABBClientes.Vacio)
                {
                    DibujarFigura();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Cliente unCliente = new Cliente();
                    unCliente.IDCliente = aleatorio.Next(99999);
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    unCliente.Nombre = new string(Enumerable.Repeat(chars, 6).Select(s => s[aleatorio.Next(s.Length)]).ToArray());
                    unCliente.Altura = Math.Round(aleatorio.NextDouble() * 3, 2);
                    ABBClientes.AgregarNodo(unCliente);
                    AgregarDatagridView();
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente unCliente = new Cliente();
                unCliente.IDCliente = int.Parse(txtIDCliente.Text);
                unCliente.Nombre = txtNombre.Text;
                unCliente.Altura = double.Parse(txtAltura.Text);
                ABBClientes.AgregarNodo(unCliente);
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
            if (ValidarOperacion("¿Está seguro de querer eliminar este cliente?", MessageBoxIcon.Warning))
            {
                try
                {
                    Cliente unClienteEliminado = new Cliente();
                    unClienteEliminado.Nombre = txtNombre.Text;
                    MessageBox.Show(ABBClientes.BuscarNodo(unClienteEliminado).ToString("Datos"), "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ABBClientes.EliminarNodo(unClienteEliminado);
                    DibujarFigura();
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
                Cliente unClienteBuscado = new Cliente();
                unClienteBuscado.Nombre = txtNombre.Text;
                MessageBox.Show(ABBClientes.BuscarNodo(unClienteBuscado).ToString("Datos"), "Cliente Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (ValidarOperacion("¿Está seguro de querer vacíar el ABB?", MessageBoxIcon.Warning))
            {
                try
                {
                    ABBClientes.Vaciar();
                    dtgDatos.Rows.Clear();
                    LimpiarControles();
                    MessageBox.Show("Se ha vaciado exitosamente el ABB", "ABB Vaciado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    picABB.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            try
            {
                string Resultado = "";
                if (radPostOrden.Checked)
                {
                    foreach (Cliente unCliente in ABBClientes.RecorrerPostOrden())
                    {
                        Resultado += $"{unCliente.ToString()} -> ";
                    }
                    if (Resultado != "")
                    {
                        MessageBox.Show($"{Resultado}", "Recorrido PostOrden");
                    }
                }
                if (radPreOrden.Checked)
                {
                    foreach (Cliente unCliente in ABBClientes.RecorrerPreOrden())
                    {
                        Resultado += $"{unCliente.ToString()} -> ";
                    }
                    if (Resultado != "")
                    {
                        MessageBox.Show($"{Resultado}", "Recorrido PreOrden");
                    }
                }
                if (radInOrden.Checked)
                {
                    foreach (Cliente unCliente in ABBClientes.RecorrerInOrden())
                    {
                        Resultado += $"{unCliente.ToString()} -> ";
                    }
                    if (Resultado != "")
                    {
                        MessageBox.Show($"{Resultado}", "Recorrido InOrden");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenarAlfabeticamente_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Cliente unCliente in ABBClientes.GetEnumerator())
                {
                    dtgDatosAlfabeticamente.Rows.Add(unCliente.IDCliente, unCliente.Nombre, unCliente.Altura + "m");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDatosAlfabeticamente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDCliente.Text = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dtgDatos.CurrentRow.Cells[1].Value.ToString();
                txtAltura.Text = dtgDatos.CurrentRow.Cells[2].Value.ToString().TrimEnd('m');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            AgregarDatagridView();
        }

        private void radPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            AgregarDatagridView();
        }

        private void radInOrden_CheckedChanged(object sender, EventArgs e)
        {
            AgregarDatagridView();
        }
    }
}

