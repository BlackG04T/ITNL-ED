using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionABB
{
    internal class ClaseABB<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        private ClaseNodo<Tipo> _raiz;
        public ClaseNodo<Tipo> Raiz
        {
            get { return _raiz; }
            set { _raiz = value; }
        }

        public bool Vacio
        {
            get
            {
                return Raiz == null ? true : false; 
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            foreach (Tipo unObjeto in RecorrerInOrden())
            {
                yield return unObjeto;
            }
        }

        public void AgregarNodo(Tipo objeto)
        {
            if (Vacio)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.HijoIzq = null;
                nodoNuevo.HijoDer = null;
                Raiz = nodoNuevo;
            }
            else
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.HijoIzq = null;
                nodoNuevo.HijoDer = null;

                ClaseNodo<Tipo> nodoPadre = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Raiz;

                do
                {
                    nodoPadre = nodoActual;
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Nodos duplicados");
                    }
                    if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        nodoActual = nodoActual.HijoIzq;
                    }
                    else if (objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
                    {
                        nodoActual = nodoActual.HijoDer;
                    }
                } while (nodoActual != null);

                if (objeto.CompareTo(nodoPadre.ObjetoConDatos) == -1)
                {
                    nodoPadre.HijoIzq = nodoNuevo;
                }
                else
                {
                    nodoPadre.HijoDer = nodoNuevo;
                }
            }
        }

        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacio)
            {
                throw new Exception("Arbol vacio");
            }
            else
            {
                ClaseNodo<Tipo> nodoPadre = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoPadre = null;
                nodoActual = Raiz;
                Tipo objetoEliminado = nodoActual.ObjetoConDatos;
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        if (nodoActual.HijoDer == null)
                        {
                            if (nodoPadre == null)
                            {
                                Raiz = nodoActual.HijoIzq;
                            }
                            else
                            {
                                switch (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos))
                                {
                                    case 1: nodoPadre.HijoIzq = nodoActual.HijoIzq; break;
                                    case -1: nodoPadre.HijoDer = nodoActual.HijoIzq; break;
                                }
                            }
                        }
                        else
                        {
                            if (nodoActual.HijoDer.HijoIzq == null)
                            {
                                nodoActual.HijoDer.HijoIzq = nodoActual.HijoIzq;
                                if (nodoPadre == null)
                                {
                                    Raiz = nodoActual.HijoDer;
                                }
                                else
                                {
                                    switch (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos))
                                    {
                                        case 1: nodoPadre.HijoIzq = nodoActual.HijoDer; break;
                                        case -1: nodoPadre.HijoDer = nodoActual.HijoDer; break;
                                    }
                                }
                            }
                            else
                            {
                                ClaseNodo<Tipo> nodoPadreMenor = new ClaseNodo<Tipo>();
                                ClaseNodo<Tipo> nodoMenor = new ClaseNodo<Tipo>();
                                nodoPadreMenor = nodoActual.HijoDer;
                                nodoMenor = nodoActual.HijoDer.HijoIzq;
                                do
                                {
                                    nodoPadreMenor = nodoMenor;
                                    nodoMenor = nodoMenor.HijoIzq;
                                } while (nodoMenor.HijoIzq != null);
                                nodoPadreMenor.HijoIzq = nodoMenor.HijoDer;
                                nodoMenor.HijoIzq = nodoActual.HijoIzq;
                                nodoMenor.HijoDer = nodoActual.HijoDer;
                                if (nodoPadre == null)
                                {
                                    Raiz = nodoMenor;
                                }
                                else
                                {
                                    switch (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos))
                                    {
                                        case 1: nodoPadre.HijoIzq = nodoMenor; break;
                                        case -1: nodoPadre.HijoDer = nodoMenor; break;
                                    }
                                }
                            }
                        }
                        return objetoEliminado;
                    }
                    if (objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
                    {
                        nodoPadre = nodoActual;
                        nodoActual = nodoActual.HijoDer;
                    }
                    else if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        nodoPadre = nodoActual;
                        nodoActual = nodoActual.HijoIzq;
                    }
                } while (nodoActual != null);
                throw new Exception("Nodo no encontrado");
            }
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacio)
            {
                throw new Exception("Arbol sin nodos");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Raiz;
                do
                {
                    ClaseNodo<Tipo> nodoPadre = new ClaseNodo<Tipo>();
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        nodoPadre = nodoActual;
                        nodoActual = nodoActual.HijoIzq;
                    }
                    else
                    {
                        nodoPadre = nodoActual;
                        nodoActual = nodoActual.HijoDer;
                    }
                } while (nodoActual != null);
                throw new Exception("Nodo no encontrado");
            }
        }

        public void Vaciar()
        {
            RecorrerYBorrar(Raiz);
            Raiz = null;
        }

        public IEnumerable<Tipo> RecorrerPreOrden()
        {
            return RecorrerPreOrden(Raiz);
        }
        private IEnumerable<Tipo> RecorrerPreOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                yield return (nodoActual.ObjetoConDatos);

                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoIzq))
                    yield return miNodo;

                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoDer))
                    yield return miNodo;
            }
        }

        public IEnumerable<Tipo> RecorrerInOrden()
        {
            return RecorrerInOrden(Raiz);
        }
        private IEnumerable<Tipo> RecorrerInOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {

                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoIzq))
                    yield return miNodo;

                yield return nodoActual.ObjetoConDatos;

                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoDer))
                    yield return miNodo;
            }
        }

        public IEnumerable<Tipo> RecorrerPostOrden()
        {
            return RecorrerPostOrden(Raiz);
        }
        private IEnumerable<Tipo> RecorrerPostOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoIzq))
                    yield return miNodo;

                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoDer))
                    yield return miNodo;
                yield return nodoActual.ObjetoConDatos;
            }
        }

        private void RecorrerYBorrar(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                RecorrerYBorrar(nodoActual.HijoIzq);
                RecorrerYBorrar(nodoActual.HijoDer);
                EliminarNodo(nodoActual.ObjetoConDatos);
            }
        }

        public void CrearArchivoDot(ref string strResultado)
        {
            if (!Vacio)
            {
                strResultado = strResultado + "digraph Figura{";
                strResultado = strResultado + "\nRaíz->" + Raiz.ObjetoConDatos.ToString() + ";";
                RecorrerNodos(Raiz, ref strResultado);
                strResultado = strResultado + "\n}";
            }
        }

        private void RecorrerNodos(ClaseNodo<Tipo> nodoActual, ref string strResultado)
        {
            if (nodoActual != null)
            {
                if (nodoActual.HijoIzq != null)
                    strResultado = strResultado + "\n" + nodoActual.ObjetoConDatos.ToString() + "->" + nodoActual.HijoIzq.ObjetoConDatos.ToString() + ";";
                if (nodoActual.HijoDer != null)
                    strResultado = strResultado + "\n" + nodoActual.ObjetoConDatos.ToString() + "->" + nodoActual.HijoDer.ObjetoConDatos.ToString() + ";";
                RecorrerNodos(nodoActual.HijoIzq, ref strResultado);
                RecorrerNodos(nodoActual.HijoDer, ref strResultado);
            }
        }

        ~ClaseABB()
        {
            if (!Vacio)
            {
                Vaciar();
            }
        }
    }
}
