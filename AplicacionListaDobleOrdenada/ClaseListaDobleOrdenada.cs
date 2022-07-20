using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionListaDobleOrdenada
{
    internal class ClaseListaDobleOrdenada<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        private ClaseNodo<Tipo> _nodoInicial;
        public ClaseNodo<Tipo> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }

        private ClaseNodo<Tipo> _nodoFinal;
        public ClaseNodo<Tipo> NodoFinal
        {
            get { return _nodoFinal; }
            set { _nodoFinal = value; }
        }

        public ClaseListaDobleOrdenada()
        {
            NodoInicial = null;
            NodoFinal = null;
        }

        ~ClaseListaDobleOrdenada()
        {
            if (!Vacia)
            {
                Vaciar();
            }
        }
        public bool Vacia
        {
            get
            {
                if (NodoInicial == null && NodoFinal == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IEnumerable<Tipo> HaciaAdelante
        {
            get
            {
                if (Vacia)
                {
                    yield break;
                }
                else
                {
                    ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                    nodoActual = NodoInicial;
                    do
                    {
                        yield return nodoActual.ObjetoConDatos;
                        nodoActual = nodoActual.Siguiente;
                    } while (nodoActual != null);
                    yield break;
                }
            }
        }

        public IEnumerable<Tipo> HaciaAtras
        {
            get
            {
                if (Vacia)
                {
                    yield break;
                }
                else
                {
                    ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                    nodoActual = NodoFinal;
                    do
                    {
                        yield return nodoActual.ObjetoConDatos;
                        nodoActual = nodoActual.Anterior;
                    } while (nodoActual != null);
                    yield break;
                }
            }
        }

        public void AgregarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                nodoNuevo.Anterior = null;
                NodoInicial = nodoNuevo;
                NodoFinal = nodoNuevo;
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoNuevo;
                nodoActual = NodoFinal;
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Objetos duplicados");
                    }
                    else
                    {
                        if (nodoActual.ObjetoConDatos.CompareTo(objeto) < 0)
                        {
                            if (objeto.CompareTo(NodoFinal.ObjetoConDatos) > 0)
                            {
                                nodoNuevo = new ClaseNodo<Tipo>();
                                nodoNuevo.ObjetoConDatos = objeto;
                                nodoNuevo.Siguiente = null;
                                nodoPrevio.Siguiente = nodoNuevo;
                                nodoNuevo.Anterior = NodoFinal;
                                NodoFinal.Siguiente = nodoNuevo;
                                NodoFinal = nodoNuevo;
                                return;
                            }
                            else
                            {
                                nodoNuevo = new ClaseNodo<Tipo>();
                                nodoNuevo.ObjetoConDatos = objeto;
                                nodoNuevo.Anterior = nodoPrevio.Anterior;
                                nodoNuevo.Siguiente = nodoPrevio;
                                nodoPrevio.Anterior.Siguiente = nodoNuevo;
                                nodoPrevio.Anterior = nodoNuevo;
                                return;
                            }
                        }
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Anterior;
                    }
                } while (nodoActual != null);
                nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoPrevio.Anterior = nodoNuevo;
                nodoNuevo.Siguiente = nodoPrevio;
                nodoNuevo.Anterior = null;
                NodoInicial = nodoNuevo;
                return;
            }
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Lista vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = NodoFinal;
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    else
                    {
                        nodoActual = nodoActual.Anterior;
                    }
                } while (nodoActual != null);
                throw new Exception("El objeto no existe");
            }
        }

        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Lista vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                nodoActual = NodoFinal;
                nodoPrevio = NodoFinal;

                do
                {
                    if (NodoInicial.ObjetoConDatos.Equals(objeto) && NodoFinal.ObjetoConDatos.Equals(objeto))
                    {
                        nodoEliminado = nodoActual;
                        NodoInicial = null;
                        NodoFinal = null;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    else if (NodoInicial.ObjetoConDatos.Equals(objeto))
                    {
                        nodoEliminado = nodoActual;
                        NodoInicial = NodoInicial.Siguiente;
                        NodoInicial.Anterior = null;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    else if (NodoFinal.ObjetoConDatos.Equals(objeto))
                    {
                        nodoEliminado = nodoActual;
                        NodoFinal = NodoFinal.Anterior;
                        NodoFinal.Siguiente = null;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    else if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        nodoEliminado = nodoActual;
                        nodoActual.Anterior.Siguiente = nodoPrevio;
                        nodoPrevio.Anterior = nodoActual.Anterior;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Anterior;
                    }
                } while (nodoActual != null);
                throw new Exception("No se encontró el elemento para eliminar");
            }
        }

        public void Vaciar()
        {
            if (Vacia)
            {
                throw new Exception("Lista vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio= new ClaseNodo<Tipo>();
                nodoActual = NodoFinal;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Anterior;
                    nodoPrevio = null;
                } while (nodoActual != null);
                NodoInicial = null;
                NodoFinal = null;
                return;
            }
        }


    }
}
