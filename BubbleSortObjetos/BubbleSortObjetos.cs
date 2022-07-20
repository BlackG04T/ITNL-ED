using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace BubbleSortObjetos
{
    public partial class FormBubbleSortObjetos : Form
    {
        private Alumno[] arregloAlumnos;
        private Random aleatorio = new Random();
        private Stopwatch cronometro;
        private string[] strNombres = {
                "Aarón",
                "Abel",
                "Adán",
                "Adrián",
                "Ángel",
                "Bruno",
                "Daniel",
                "David",
                "Edgar",
                "Fabián",
                "Fernando",
                "Francisco",
                "Gabriel",
                "Guillermo",
                "Héctor",
                "Hugo",
                "Isaac",
                "Iván",
                "Jaime",
                "Jesús",
                "Julián",
                "Julio",
                "Leonardo",
                "Lucas",
                "Luis",
                "Manuel",
                "Marco",
                "Miguel",
                "Omar",
                "Pablo",
                "Raúl",
                "Ricardo",
                "Samuel",
                "Santiango",
                "Sergio",
                "Tomás",
                "Vicente",
                "Adriana",
                "Ainara",
                "Alejandra",
                "Alicia",
                "Alma",
                "Andrea",
                "Camila",
                "Claudia",
                "Daniela",
                "Diana",
                "Gabriela",
                "Heidi",
                "Ilian",
                "Iris",
                "Itzel",
                "Karen",
                "Karina",
                "Laura",
                "Liliana",
                "María",
                "Mónica",
                "Paola",
                "Salma",
                "Sandra",
                "Sofía",
                "Susana",
                "Valeria",
                "Verónica"
            };
        private string[] strApellidos = {
                "Álvaro",
                "Águilar",
                "Cruz",
                "Briones",
                "Cantú",
                "Canales",
                "Carrillo",
                "Díaz",
                "Domínguez",
                "Estrada",
                "Espinoza",
                "Flores",
                "García",
                "Garza",
                "Gómez",
                "Guerrero",
                "Gutierrez",
                "Gonzalez",
                "Herrera",
                "Jímenez",
                "López",
                "Macías",
                "Márquez",
                "Martínez",
                "Mejía",
                "Morales",
                "Navarro",
                "Ortíz",
                "Peña",
                "Pérez",
                "Ramírez",
                "Rangel",
                "Ríos",
                "Rivera",
                "Rodríguez",
                "Rosales",
                "Rosas",
                "Ruiz",
                "Salas",
                "Salazar",
                "Sánchez",
                "Sosa",
                "Soto",
                "Torres",
                "Treviño",
                "Valencia",
                "Valenzuela",
                "Vargas",
                "Vázquez",
                "Villareal"
            };
        private string[] strCarreras = {
                "Administración",
                "Sistemas",
                "Contabilidad",
                "Gestión Empresarial",
                "Arquitectura",
                "Civil",
                "Industrial"
            };
        private int[] intNumeroControl = { 17100, 18100, 19100, 20100, 21100 };
        private bool blnBandera;
        private int intIntercambios;
        private int intComparaciones;
        private Alumno alumnoAuxiliar;

        public FormBubbleSortObjetos()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            dtgEstudiantes.Rows.Clear();

            foreach (Alumno unAlumno in arregloAlumnos)
            {
                string strRegular = unAlumno.Regular ? "Sí" : "No";
                dtgEstudiantes.Rows.Add(unAlumno.NumeroControl, unAlumno.Nombre, unAlumno.Apellido, unAlumno.FechaNacimiento.ToShortDateString(), unAlumno.Carrera, unAlumno.Calificacion.ToString("N1"), strRegular);
            }
        }

        private DateTime FechaAleatoria()
        {
            DateTime dtmInicio = new DateTime(1998, 1, 1);
            int intRango = (DateTime.Today - dtmInicio).Days;
            return dtmInicio.AddDays(aleatorio.Next(intRango));
        }

        private void Generar(int intCantidad)
        {
            try
            {
                arregloAlumnos = new Alumno[intCantidad];

                for (int i = 0; i < intCantidad; i++)
                {
                    Alumno miAlumno = new Alumno();

                    miAlumno.NumeroControl = intNumeroControl[aleatorio.Next(intNumeroControl.Length)].ToString() + aleatorio.Next(000, 999);
                    miAlumno.Nombre = strNombres[aleatorio.Next(strNombres.Length)];
                    miAlumno.Apellido = strApellidos[aleatorio.Next(strApellidos.Length)];
                    miAlumno.FechaNacimiento = FechaAleatoria();
                    miAlumno.Carrera = strCarreras[aleatorio.Next(strCarreras.Length)];
                    miAlumno.Calificacion = aleatorio.Next(0, 100);
                    miAlumno.Regular = aleatorio.Next(0, 2) == 1 ? true : false;

                    arregloAlumnos[i] = miAlumno;
                }

                Mostrar();

                MessageBox.Show($"Se han generado {intCantidad} objetos", "Generación de Objetos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Izquierda(ref Alumno[] arregloAlumnos)
        {
            try
            {
                for (int i = 0; i < arregloAlumnos.Length; i++)
                {
                    intComparaciones++;

                    for (int j = 0; j < arregloAlumnos.Length - 1; j++)
                    {
                        intComparaciones++;

                        if (arregloAlumnos[j].CompareTo(arregloAlumnos[j + 1]) == 1)
                        {
                            alumnoAuxiliar = arregloAlumnos[j];
                            arregloAlumnos[j] = arregloAlumnos[j + 1];
                            arregloAlumnos[j + 1] = alumnoAuxiliar;

                            intIntercambios++;

                            if (chkPasoAPaso.Checked)
                            {
                                MessageBox.Show($"Se ha intercambiado el elemento: {arregloAlumnos[j + 1].Calificacion} con {arregloAlumnos[j].Calificacion}.", "Elementos Intercambiados");
                                Mostrar();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Derecha(ref Alumno[] arregloAlumnos)
        {
            try
            {
                for (int i = 0; i < arregloAlumnos.Length; i++)
                {
                    intComparaciones++;

                    for (int j = arregloAlumnos.Length - 1; j > 0; j--)
                    {
                        intComparaciones++;

                        if (arregloAlumnos[j].CompareTo(arregloAlumnos[j - 1]) == -1)
                        {
                            alumnoAuxiliar = arregloAlumnos[j];
                            arregloAlumnos[j] = arregloAlumnos[j - 1];
                            arregloAlumnos[j - 1] = alumnoAuxiliar;

                            intIntercambios++;

                            if (chkPasoAPaso.Checked)
                            {
                                MessageBox.Show($"Se ha intercambiado el elemento: {arregloAlumnos[j - 1].Calificacion} con {arregloAlumnos[j].Calificacion}.", "Elementos Intercambiados");
                                Mostrar();
                            }
                        }
                    }
                    intComparaciones++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzquierdaConSenial(ref Alumno[] arregloAlumnos)
        {
            try
            {
                for (int i = 0; i < arregloAlumnos.Length; i++)
                {
                    intComparaciones++;
                    blnBandera = false;

                    for (int j = 0; j < arregloAlumnos.Length - 1; j++)
                    {
                        intComparaciones++;

                        if (arregloAlumnos[j].CompareTo(arregloAlumnos[j + 1]) == 1)
                        {
                            alumnoAuxiliar = arregloAlumnos[j];
                            arregloAlumnos[j] = arregloAlumnos[j + 1];
                            arregloAlumnos[j + 1] = alumnoAuxiliar;

                            blnBandera = true;

                            intIntercambios++;

                            if (chkPasoAPaso.Checked)
                            {
                                MessageBox.Show($"Se ha intercambiado el elemento: {arregloAlumnos[j + 1].Calificacion} con {arregloAlumnos[j].Calificacion}.", "Elementos Intercambiados");
                                Mostrar();
                            }
                        }
                    }

                    if (!blnBandera)
                    {
                        break;
                    }

                    intComparaciones++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DerechaConSenial(ref Alumno[] arregloAlumnos)
        {
            try
            {
                for (int i = 0; i < arregloAlumnos.Length; i++)
                {
                    intComparaciones++;
                    blnBandera = false;

                    for (int j = arregloAlumnos.Length - 1; j > 0; j--)
                    {
                        intComparaciones++;

                        if (arregloAlumnos[j].CompareTo(arregloAlumnos[j - 1]) == -1)
                        {
                            alumnoAuxiliar = arregloAlumnos[j];
                            arregloAlumnos[j] = arregloAlumnos[j - 1];
                            arregloAlumnos[j - 1] = alumnoAuxiliar;

                            blnBandera = true;

                            intIntercambios++;

                            if (chkPasoAPaso.Checked)
                            {
                                MessageBox.Show($"Se ha intercambiado el elemento: {arregloAlumnos[j - 1].Calificacion} con {arregloAlumnos[j].Calificacion}.", "Elementos Intercambiados");
                                Mostrar();
                            }
                        }
                    }

                    if (!blnBandera)
                    {
                        break;
                    }

                    intComparaciones++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void quicksort(ref Alumno[] arregloAlumnos, int primero, int ultimo)
        {
            int i, j, central;
            Alumno alumnoPivote;
            Alumno alumnoAuxiliar;

            central = (primero + ultimo) / 2;
            alumnoPivote = arregloAlumnos[central];
            i = primero;
            j = ultimo;
            do
            {
                while (arregloAlumnos[i].CompareTo(alumnoPivote) == -1) i++;
                while (arregloAlumnos[j].CompareTo(alumnoPivote) == 1) j--;
                if (i <= j)
                {
                    alumnoAuxiliar = arregloAlumnos[i];
                    arregloAlumnos[i] = arregloAlumnos[j];
                    arregloAlumnos[j] = alumnoAuxiliar;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(ref arregloAlumnos, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(ref arregloAlumnos, i, ultimo);
            }
        }*/


        /*public void RadixSort(ref Alumno[] arregloAlumnos)
        {
            Alumno[] arregloAuxiliar = new Alumno[arregloAlumnos.Length];

            int r = 4; // try to set this also to 2, 8 or 16 to see if it is 
                       // quicker or not 

            // number of bits of a C# int 
            int b = 32;

            // counting and prefix arrays
            // (note dimensions 2^r which is the number of all possible values of a 
            // r-bit number) 
            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];

            // number of groups 
            int groups = (int)Math.Ceiling((double)b / (double)r);

            // the mask to identify groups 
            int mask = (1 << r) - 1;

            // the algorithm: 
            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                // reset count array 
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                // counting elements of the c-th group 
                for (int i = 0; i < arregloAlumnos.Length; i++)
                    count[(arregloAlumnos[i] >> shift) & mask]++;

                // calculating prefixes 
                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                    pref[i] = pref[i - 1] + count[i - 1];

                // from a[] to t[] elements ordered by c-th group 
                for (int i = 0; i < arregloAlumnos.Length; i++)
                    arregloAuxiliar[pref[(arregloAlumnos[i] >> shift) & mask]++] = arregloAlumnos[i];

                // a[]=t[] and start again until the last group 
                arregloAuxiliar.CopyTo(arregloAlumnos, 0);
            }
            // a is sorted 
        }*/

        /*private void ShakerSort(ref Alumno[] arregloAlumnos)
        {
            bool blnBandera = true;
            int intInicio = 0;
            int intFinal = arregloAlumnos.Length;

            while (blnBandera == true)
            {
                blnBandera = false;

                for (int i = intInicio; i < intFinal - 1; ++i)
                {
                    if (arregloAlumnos[i].CompareTo(arregloAlumnos[i + 1]) == 1)
                    {
                        Alumno intAux = arregloAlumnos[i];
                        arregloAlumnos[i] = arregloAlumnos[i + 1];
                        arregloAlumnos[i + 1] = intAux;
                        blnBandera = true;
                    }
                }

                if (blnBandera == false)
                    break;

                blnBandera = false;

                intFinal = intFinal - 1;

                for (int i = intFinal - 1; i >= intInicio; i--)
                {
                    if (arregloAlumnos[i].CompareTo(arregloAlumnos[i + 1]) == 1)
                    {
                        Alumno intAux = arregloAlumnos[i];
                        arregloAlumnos[i] = arregloAlumnos[i + 1];
                        arregloAlumnos[i + 1] = intAux;
                        blnBandera = true;
                    }
                }

                intInicio = intInicio + 1;
            }
        }*/

        private void shellSort(ref Alumno[] arr, int array_size)
        {
            int i, j, inc;
            Alumno temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc].CompareTo(temp) == 1))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        private delegate void OrdenamientoBurbuja(ref Alumno[] arregloAlumnos);

        private void Ordenar(OrdenamientoBurbuja unOrdenamiento)
        {
            intComparaciones = 0;
            intIntercambios = 0;
            blnBandera = false;
            unOrdenamiento(ref arregloAlumnos);
            Mostrar();
        }

        private void btnGenerar50_Click(object sender, EventArgs e)
        {
            Generar(50);
        }

        private void btnGenerar5_Click(object sender, EventArgs e)
        {
            Generar(5);
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            cronometro = new Stopwatch();

            cronometro.Start();

            if (chkConSenial.Checked)
            {
                Ordenar(IzquierdaConSenial);
            }
            else
            {
                //quicksort(ref arregloAlumnos, 0, arregloAlumnos.Length - 1);
                //  ShakerSort(ref arregloAlumnos);
               // shellSort(ref arregloAlumnos, arregloAlumnos.Length);
                Mostrar();

            }

            cronometro.Stop();

            MessageBox.Show($"Objetos ordenados por la izquierda \nIntercambios realizados: {intIntercambios} \nComparaciones: {intComparaciones} \nTiempo de ejecución: {cronometro.ElapsedMilliseconds}ms", "Ordenamiento Completado");
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            cronometro = new Stopwatch();

            cronometro.Start();

            if (chkConSenial.Checked)
            {
                Ordenar(DerechaConSenial);
            }
            else
            {
                Ordenar(Derecha);
            }

            cronometro.Stop();

            MessageBox.Show($"Objetos ordenados por la derecha \nIntercambios realizados: {intIntercambios} \nComparaciones: {intComparaciones} \nTiempo de ejecución: {cronometro.ElapsedMilliseconds}ms", "Ordenamiento Completado");
        }
    }
}
