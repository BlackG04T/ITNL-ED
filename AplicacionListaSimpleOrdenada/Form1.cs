using System;
using System.IO;
using System.Windows.Forms;

namespace AplicacionListaSimpleOrdenada
{
    public partial class ListaSimpleOrdenadaForm : Form
    {
        ClaseListaSimpleOrdenada<Personaje> listaPersonajes = new ClaseListaSimpleOrdenada<Personaje>(); //Se crea la lista de personajes
        OpenFileDialog dialogoArchivo = new OpenFileDialog(); //Se crea un objeto de tipo OpenFileDialog donde se almacenará la ruta de la imagen
        Random aleatorio = new Random(); //Se crea un objeto aleatorio del tipo Random para generar números aleatorios
        DateTime fechaInicio = new DateTime(1990, 1, 1); //Fecha de inicio para generar fechas aleatorias
        string[] listaFotos = Directory.GetFiles(Application.StartupPath + "\\FotosPersonajes"); //Arreglo para almacenar las rutas de las imagenes

        public ListaSimpleOrdenadaForm()
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
                foreach (Personaje unPersonaje in listaPersonajes)
                {
                    dtgDatos.Rows.Add(unPersonaje.IDPersonaje, unPersonaje.Nombre, unPersonaje.Altura + "m", unPersonaje.Criatura, unPersonaje.Sexo, unPersonaje.FechaNacimiento.ToShortDateString(), unPersonaje.Olimpo ? "Si" : "No");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles() //Método para limpiar los controles de la aplicación 
        {
            txtIDPersonaje.Clear();
            txtNombre.Clear();
            txtAltura.Clear();
            dtgDatos.ClearSelection();
            cboCriatura.SelectedIndex = 0;
            chkOlimpo.Checked = false;
            radFemenino.Checked = true;
            radMasculino.Checked = false;
            dtmFechaNacimiento.Value = DateTime.Now;
            picFoto.Image = null;
            picFoto.ImageLocation = null;
            dialogoArchivo.FileName = null;
        }
        DateTime DiaAleatorio() //Método que regresa un día aleatorio válido
        {
            int intRango = (DateTime.Today - fechaInicio).Days;
            return fechaInicio.AddDays(aleatorio.Next(intRango));
        }
        private void ListaSimpleOrdenadaForm_Load(object sender, EventArgs e) //Se inicializan las propiedades del DataGridView
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
            dtgDatos.Columns.Add("IDPersonaje", "IDPersonaje");
            dtgDatos.Columns.Add("Nombre", "Nombre");
            dtgDatos.Columns.Add("Altura", "Altura");
            dtgDatos.Columns.Add("Criatura", "Criatura");
            dtgDatos.Columns.Add("Sexo", "Sexo");
            dtgDatos.Columns.Add("Fecha de Nacimiento", "Fecha de Nacimiento");
            dtgDatos.Columns.Add("Pertenece al Olimpo", "Pertenece al Olimpo");
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage; //Se establece el SizeMode del PictureBox a PictureBoxSizeMode.StretchImage para que la imagen se ajuste al tamaño
        }

        private void btnGenerar_Click(object sender, EventArgs e) //Evento de Click del botón Generar que genera objetos aleatorios
        {
            if (ValidarOperacion("¿Está seguro de querer generar personajes?", MessageBoxIcon.Question))
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Personaje unPersonaje = new Personaje();
                        unPersonaje.IDPersonaje = aleatorio.Next(99999);
                        unPersonaje.Nombre = Guid.NewGuid().ToString().Substring(0, 10);
                        unPersonaje.Altura = Math.Round(aleatorio.NextDouble() * 3, 2);
                        switch (aleatorio.Next(0, 6))
                        {
                            case 0: unPersonaje.Criatura = "Humano"; break;
                            case 1: unPersonaje.Criatura = "Semidios"; break;
                            case 2: unPersonaje.Criatura = "Dios Olimpico"; break;
                            case 3: unPersonaje.Criatura = "Minotauro"; break;
                            case 4: unPersonaje.Criatura = "Gorgona"; break;
                            default: unPersonaje.Criatura = "Humano"; break;
                        }
                        unPersonaje.FechaNacimiento = DiaAleatorio();
                        unPersonaje.Olimpo = aleatorio.Next(0, 2) == 1 ? true : false;
                        unPersonaje.Sexo = aleatorio.Next(0, 2) == 1 ? 'F' : 'M';
                        unPersonaje.RutaFoto = listaFotos[aleatorio.Next(0, 10)]; //Se establece una imagen aleatoria dependiendo el indíce dado por un número aleatorio del 0 al 9
                        listaPersonajes.AgregarNodo(unPersonaje); //Se agrega el objeto a la lista
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

        private void btnAgregar_Click(object sender, EventArgs e) //Evento Click del botón Agregar que agrega objetos a la lista
        {
            if (ValidarOperacion("¿Está seguro de querer agregar un personaje?", MessageBoxIcon.Question))
            {
                try
                {
                    Personaje unPersonaje = new Personaje();
                    unPersonaje.IDPersonaje = int.Parse(txtIDPersonaje.Text);
                    unPersonaje.Nombre = txtNombre.Text;
                    unPersonaje.Altura = double.Parse(txtAltura.Text);
                    unPersonaje.Criatura = cboCriatura.Text;
                    unPersonaje.FechaNacimiento = dtmFechaNacimiento.Value;
                    unPersonaje.Olimpo = chkOlimpo.Checked;
                    unPersonaje.RutaFoto = dialogoArchivo.FileName;
                    unPersonaje.Sexo = radFemenino.Checked == true ? 'F' : 'M';
                    listaPersonajes.AgregarNodo(unPersonaje);
                    AgregarDatagridView();
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) //Evento Click del botón Eliminar que elimina objetos de la lista
        {
            if (ValidarOperacion("¿Está seguro de querer eliminar este personaje?", MessageBoxIcon.Warning))
            {
                try
                {
                    Personaje unPersonajeEliminado = new Personaje();
                    unPersonajeEliminado.IDPersonaje = int.Parse(txtIDPersonaje.Text);
                    MessageBox.Show(listaPersonajes.BuscarNodo(unPersonajeEliminado).ToString(), "Personaje Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listaPersonajes.EliminarNodo(unPersonajeEliminado);
                    AgregarDatagridView();
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) //Evento Click del botón Buscar que busca objetos en la lista tomando su ID y regresa su método ToString()
        {
                try
                {
                    Personaje unPersonajeBuscado = new Personaje();
                    unPersonajeBuscado.IDPersonaje = int.Parse(txtIDPersonaje.Text);
                    LimpiarControles();
                    unPersonajeBuscado = listaPersonajes.BuscarNodo(unPersonajeBuscado);
                    txtIDPersonaje.Text = unPersonajeBuscado.IDPersonaje.ToString();
                    txtNombre.Text = unPersonajeBuscado.Nombre;
                    txtAltura.Text = unPersonajeBuscado.Altura.ToString();
                    cboCriatura.Text = unPersonajeBuscado.Criatura;
                    switch (unPersonajeBuscado.Sexo.ToString())
                    {
                        case "F": radFemenino.Checked = true; break;
                        case "M": radMasculino.Checked = true; break;
                        default: radFemenino.Checked = true; break;
                    }
                    dtmFechaNacimiento.Value = unPersonajeBuscado.FechaNacimiento;
                    chkOlimpo.Checked = unPersonajeBuscado.Olimpo == true ? true : false;
                    picFoto.ImageLocation = unPersonajeBuscado.RutaFoto; //Se establece la localización de la imagen
                    picFoto.Load(unPersonajeBuscado.RutaFoto); //Se carga la imagen 
                    MessageBox.Show(listaPersonajes.BuscarNodo(unPersonajeBuscado).ToString(), "Personaje Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnVaciar_Click(object sender, EventArgs e) //Evento Click del botón Vaciar que vacía la lista
        {
            if (ValidarOperacion("¿Está seguro de querer vacíar la lista?", MessageBoxIcon.Warning))
            {
                try
                {
                    listaPersonajes.Vaciar();
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

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e) //Evento CellClick del DataGridView dtgDatos que muestra los datos del objeto en los controles visuales al dar click en una celda
        {
            try
            {
                txtIDPersonaje.Text = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dtgDatos.CurrentRow.Cells[1].Value.ToString();
                txtAltura.Text = dtgDatos.CurrentRow.Cells[2].Value.ToString().TrimEnd('m'); //Se corta el carácter 'm' para ser mostrado en el TextBox txtAltura 
                cboCriatura.Text = dtgDatos.CurrentRow.Cells[3].Value.ToString();
                radFemenino.Checked = dtgDatos.CurrentRow.Cells[4].Value.ToString() == "F" ? true : false;
                radMasculino.Checked = dtgDatos.CurrentRow.Cells[4].Value.ToString() == "M" ? true : false;
                dtmFechaNacimiento.Value = DateTime.Parse(dtgDatos.CurrentRow.Cells[5].Value.ToString());
                chkOlimpo.Checked = dtgDatos.CurrentRow.Cells[6].Value.ToString() == "Si" ? true : false;
                Personaje unPersonajeBuscado = new Personaje(); //Se crea un objeto para buscar al personaje y mostrar su imagen en el PictureBox picFoto
                unPersonajeBuscado.IDPersonaje = int.Parse(dtgDatos.CurrentRow.Cells[0].Value.ToString());
                picFoto.ImageLocation = listaPersonajes.BuscarNodo(unPersonajeBuscado).RutaFoto; //Se establece la localización de la imagen
                picFoto.Load(listaPersonajes.BuscarNodo(unPersonajeBuscado).RutaFoto); //Se carga la imagen 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCargar_Click(object sender, EventArgs e) //Evento Click del botón Cargar que carga una imagen a los objetos
        {
            try
            {
                dialogoArchivo.InitialDirectory = Path.Combine(Application.StartupPath, "\\FotosPersonajes"); //Se establece el directorio inicial en la carpeta de la aplicación
                dialogoArchivo.Filter = "JPG (*.jpg) | *.jpg";
                dialogoArchivo.RestoreDirectory = true;
                if (dialogoArchivo.ShowDialog() == DialogResult.OK)
                {
                    picFoto.ImageLocation = dialogoArchivo.FileName;
                    picFoto.Load(dialogoArchivo.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIDPersonaje_Click(object sender, EventArgs e) //Evento Click de la MaskedTextBox que posiciona el cursor a la izquierda cuando se le da click al campo de texto
        {
            this.txtIDPersonaje.Select(0, 0);
        }

        private void grpDatos_Enter(object sender, EventArgs e) //Al entrar al GroupBox de Datos se limpian los controles
        {
            LimpiarControles();
        }

        private void txtIDPersonaje_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("La entrada de ID debe ser de tipo int menor a 5 carácteres", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}