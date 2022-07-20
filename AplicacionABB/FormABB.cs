using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AplicacionABB
{
    public partial class FormABB : Form
    {
        ClaseABB<Personaje> ABBPersonajes = new ClaseABB<Personaje>();
        OpenFileDialog dialogoArchivo = new OpenFileDialog();
        Random aleatorio = new Random(); 
        DateTime fechaInicio = new DateTime(1990, 1, 1);
        string[] listaFotos = Directory.GetFiles(Application.StartupPath + "\\FotosPersonajes"); 
        public FormABB()
        {
            InitializeComponent();
        }

        private void radPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            radPostOrden.BackColor = radPostOrden.Checked ? Color.FromArgb(247, 86, 124) : Color.FromArgb(233, 242, 227);
            radPostOrden.ForeColor = radPostOrden.Checked ? Color.White : Color.FromArgb(247, 86, 124);
            AgregarDatagridView();
        }

        private void radPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            radPreOrden.BackColor = radPreOrden.Checked ? Color.FromArgb(247, 86, 124) : Color.FromArgb(233, 242, 227);
            radPreOrden.ForeColor = radPreOrden.Checked ? Color.White : Color.FromArgb(247, 86, 124);
            AgregarDatagridView();
        }

        private void radInOrden_CheckedChanged(object sender, EventArgs e)
        {
            radInOrden.BackColor = radInOrden.Checked ? Color.FromArgb(247, 86, 124) : Color.FromArgb(233, 242, 227);
            radInOrden.ForeColor = radInOrden.Checked ? Color.White : Color.FromArgb(247, 86, 124);
            AgregarDatagridView();
        }

        private void AgregarDatagridView()
        {
            try
            {
                if (radPostOrden.Checked)
                {
                    dtgDatos.Rows.Clear();
                    foreach (Personaje unPersonaje in ABBPersonajes.RecorrerPostOrden())
                    {
                        dtgDatos.Rows.Add(unPersonaje.Nombre, unPersonaje.Altura + "m", unPersonaje.Edad);
                    }
                }
                else if (radPreOrden.Checked)
                {
                    dtgDatos.Rows.Clear();
                    foreach (Personaje unPersonaje in ABBPersonajes.RecorrerPreOrden())
                    {
                        dtgDatos.Rows.Add(unPersonaje.Nombre, unPersonaje.Altura + "m", unPersonaje.Edad);
                    }
                }
                else if (radInOrden.Checked)
                {
                    dtgDatos.Rows.Clear();
                    foreach (Personaje unPersonaje in ABBPersonajes.RecorrerInOrden())
                    {
                        dtgDatos.Rows.Add(unPersonaje.Nombre, unPersonaje.Altura + "m", unPersonaje.Edad);
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
            txtNombre.Clear();
            txtAltura.Clear();
            txtEdad.Clear();
            dtgDatos.ClearSelection();
            dialogoArchivo.FileName = null;
        }

        DateTime DiaAleatorio()
        {
            int intRango = (DateTime.Today - fechaInicio).Days;
            return fechaInicio.AddDays(aleatorio.Next(intRango));
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
            ABBPersonajes.CrearArchivoDot(ref strResultado);
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Personaje unPersonaje = new Personaje();
                    unPersonaje.Nombre = Guid.NewGuid().ToString().Substring(0, 15);
                    unPersonaje.Altura = Math.Round(aleatorio.NextDouble() * 3, 2);
                    unPersonaje.Edad = aleatorio.Next(1, 101);
                    ABBPersonajes.AgregarNodo(unPersonaje);
                    AgregarDatagridView(); 
                    LimpiarControles(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                txtAltura.Text = dtgDatos.CurrentRow.Cells[1].Value.ToString().TrimEnd('m');
                txtEdad.Text = dtgDatos.CurrentRow.Cells[2].Value.ToString();
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
                if (!ABBPersonajes.Vacio)
                {
                    DibujarFigura();
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
                Personaje unPersonaje = new Personaje();
                unPersonaje.Nombre = txtNombre.Text;
                unPersonaje.Altura = double.Parse(txtAltura.Text);
                unPersonaje.Edad = int.Parse(txtAltura.Text);
                ABBPersonajes.AgregarNodo(unPersonaje);
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
            if (ValidarOperacion("¿Está seguro de querer eliminar este personaje?", MessageBoxIcon.Warning))
            {
                try
                {
                    Personaje unPersonajeEliminado = new Personaje();
                    unPersonajeEliminado.Nombre = txtNombre.Text;
                    MessageBox.Show(ABBPersonajes.BuscarNodo(unPersonajeEliminado).ToString("Datos"), "Personaje Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ABBPersonajes.EliminarNodo(unPersonajeEliminado);
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
                Personaje unPersonajeBuscado = new Personaje();
                unPersonajeBuscado.Nombre = txtNombre.Text;
                MessageBox.Show(ABBPersonajes.BuscarNodo(unPersonajeBuscado).ToString("Datos"), "Personaje Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ABBPersonajes.Vaciar();
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
                    foreach (Personaje unPersonaje in ABBPersonajes.RecorrerPostOrden())
                    {
                        Resultado += $"{unPersonaje.ToString()} -> ";
                    }
                    if (Resultado != "")
                    {
                        MessageBox.Show($"{Resultado}", "Recorrido PostOrden");
                    }
                }
                if (radPreOrden.Checked)
                {
                    foreach (Personaje unPersonaje in ABBPersonajes.RecorrerPreOrden())
                    {
                        Resultado += $"{unPersonaje.ToString()} -> ";
                    }
                    if (Resultado != "")
                    {
                        MessageBox.Show($"{Resultado}", "Recorrido PreOrden");
                    }
                }
                if (radInOrden.Checked)
                {
                    foreach (Personaje unPersonaje in ABBPersonajes.RecorrerInOrden())
                    {
                        Resultado += $"{unPersonaje.ToString()} -> ";
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

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            dtgDatosOrdenados.Rows.Clear();
            foreach (Personaje unPersonaje in ABBPersonajes)
            {
                dtgDatosOrdenados.Rows.Add(unPersonaje.Nombre, unPersonaje.Altura + "m", unPersonaje.Edad);
            }
        }
    }
    }
    

