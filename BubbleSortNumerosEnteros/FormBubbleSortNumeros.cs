using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace BubbleSortNumerosEnteros
{
    public partial class FormBubbleSortNumeros : Form
    {
        public List<int> intArreglo = new List<int>(); 
        public Random aleatorio = new Random();
        public Stopwatch cronometro;
        public int intComparaciones;
        public int intIntercambios;
        public int intAuxiliar;
        public bool blnBandera;

        public FormBubbleSortNumeros()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            dtgNumeros.Rows.Clear();

            for (int x = 0; x < intArreglo.Count; x++)
            {
                dtgNumeros.Rows.Add(intArreglo[x].ToString());
            }
        }

        private void Generar(int intCantidad)
        {
            try
            {
                intArreglo.Clear();

                for (int i = 0; i < intCantidad; i++)
                {
                    intArreglo.Add(aleatorio.Next(0, 999));
                }

                MessageBox.Show($"Se han generado {intCantidad} números", "Generación de Números");

                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Izquierda(ref List<int> intArreglo)
        {
            try
            {
                for (int x = 0; x < intArreglo.Count; x++)              // n
                {
                    intComparaciones++;
                    for (int y = 0; y < intArreglo.Count - 1; y++)      // n^2
                    {
                        intComparaciones++;
                        if (intArreglo[y] > intArreglo[y + 1])          // n^2
                        {
                            intAuxiliar = intArreglo[y];                // n^2
                            intArreglo[y] = intArreglo[y + 1];          // n^2
                            intArreglo[y + 1] = intAuxiliar;            // n^2
                                                                        // 5n^2 + n = O(n^2)
                            intIntercambios++;

                            if (chkPasoAPaso.Checked)
                            {
                                Mostrar();
                                MessageBox.Show($"Se intercambia el número: {intArreglo[y + 1]} con: {intArreglo[y]}.", "Elementos Intercambiados");
                            }
                        }
                    }
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Derecha(ref List<int> intArreglo)
        {
            try
            {
                for (int x = 0; x < intArreglo.Count; x++)
                {
                    intComparaciones++;

                    for (int y = intArreglo.Count - 1; y > 0; y--)
                    {
                        intComparaciones++;

                        if (intArreglo[y] < intArreglo[y - 1])
                        {
                            intAuxiliar = intArreglo[y];
                            intArreglo[y] = intArreglo[y - 1];
                            intArreglo[y - 1] = intAuxiliar;

                            intIntercambios++;

                            if (chkPasoAPaso.Checked)
                            {
                                Mostrar();
                                MessageBox.Show($"Se intercambia el número: {intArreglo[y + 1]} con: {intArreglo[y]}.", "Elementos Intercambiados");
                            }
                        }
                    }
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzquierdaConSenial(ref List<int> intArreglo)
        {
            try
            {
                for (int x = 0; x < intArreglo.Count; x++)
                {
                    intComparaciones++;
                    blnBandera = false;

                    for (int y = 0; y < intArreglo.Count - 1; y++)
                    {
                        intComparaciones++;

                        if (intArreglo[y] > intArreglo[y + 1])
                        {
                            intAuxiliar = intArreglo[y];
                            intArreglo[y] = intArreglo[y + 1];
                            intArreglo[y + 1] = intAuxiliar;

                            blnBandera = true;

                            intIntercambios++;

                            if (chkPasoAPaso.Checked)
                            {
                                Mostrar();
                                MessageBox.Show($"Se intercambia el número: {intArreglo[y + 1]} con: {intArreglo[y]}.", "Elementos Intercambiados");
                            }
                        }
                    }

                    if (!blnBandera)
                    {
                        break;
                    }

                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DerechaConSenial(ref List<int> intArreglo)
        {
            try
            {
                for (int x = 0; x < intArreglo.Count; x++)
                {
                    intComparaciones++;
                    blnBandera = false;

                    for (int y = intArreglo.Count - 1; y > 0; y--)
                    {
                        intComparaciones++;
                         
                        if (intArreglo[y] < intArreglo[y - 1])
                        {
                            intAuxiliar = intArreglo[y];
                            intArreglo[y] = intArreglo[y - 1];
                            intArreglo[y - 1] = intAuxiliar;

                            blnBandera = true;

                            intIntercambios++;

                            if (chkPasoAPaso.Checked)
                            {
                                Mostrar();
                                MessageBox.Show($"Se intercambia el número: {intArreglo[y + 1]} con: {intArreglo[y]}.", "Elementos Intercambiados");
                            }
                        }
                    }

                    if (!blnBandera)
                    {
                        break;
                    }

                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private delegate void OrdenamientoBurbuja(ref List<int> intArreglo);

        private void Ordenar(OrdenamientoBurbuja unOrdenamiento)
        {
            intAuxiliar = 0;
            intComparaciones = 0;
            intIntercambios = 0;
            blnBandera = false;

            unOrdenamiento(ref intArreglo);
        }

        private void btnGenerar100_Click(object sender, EventArgs e)
        {
            Generar(100);
        }

        private void btnGenerar25_Click(object sender, EventArgs e)
        {
            Generar(25);
        }

        private void btnGenerar5Orden_Click(object sender, EventArgs e)
        {
            intArreglo.Clear();

            for (int i = 5; i > 0; i--)
            {
                intArreglo.Add(i);
            }

            MessageBox.Show("Se generaron 5 números del 1 al 5", "Generación de Números");

            Mostrar();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            cronometro = Stopwatch.StartNew();

            if (chkConSenial.Checked)
            {
                Ordenar(IzquierdaConSenial);
            }
            else
            {
                Ordenar(Izquierda);
            }

            cronometro.Stop();

            MessageBox.Show($"Números ordenados por la izquierda \nIntercambios realizados: {intIntercambios} \nComparaciones: {intComparaciones} \nTiempo de ejecución: {cronometro.ElapsedMilliseconds}ms", "Ordenamiento Completado");
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            cronometro = Stopwatch.StartNew();

            if (chkConSenial.Checked)
            {
                Ordenar(DerechaConSenial);
            }
            else
            {
                Ordenar(Derecha);
            }

            cronometro.Stop();

            MessageBox.Show($"Números ordenados por la derecha \nMovimientos realizados: {intIntercambios} \nComparaciones: {intComparaciones} \nTiempo de ejecución: {cronometro.ElapsedMilliseconds}ms", "Ordenamiento Completado");
        }
    }
}
