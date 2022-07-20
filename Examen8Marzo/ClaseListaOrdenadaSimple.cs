using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen8Marzo
{
    internal class ClaseListaOrdenadaSimple<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        private ClaseNodo<Tipo> _nodoInicial;

        public ClaseNodo<Tipo> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }

        public ClaseListaOrdenadaSimple()
        {
            NodoInicial = null;
        }

        public bool Vacia
        {
            get
            {
                if (NodoInicial == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
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

        public void AgregarNodo(Tipo objeto) //Nota: Sentencia "return" importante para evitar errores al agregar individualmente cada nodo
        {
            if (Vacia)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                NodoInicial = nodoNuevo;
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoNuevo;
                nodoActual = NodoInicial;
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Objetos duplicados");
                    }
                    else
                    {
                        if (nodoActual.ObjetoConDatos.CompareTo(objeto) > 0)
                        {
                            if (objeto.CompareTo(NodoInicial.ObjetoConDatos) < 0)
                            {
                                nodoNuevo = new ClaseNodo<Tipo>();
                                nodoNuevo.ObjetoConDatos = objeto;
                                nodoNuevo.Siguiente = NodoInicial;
                                NodoInicial = nodoNuevo;
                                return;
                            }
                            else
                            {
                                nodoNuevo = new ClaseNodo<Tipo>();
                                nodoNuevo.ObjetoConDatos = objeto;
                                nodoNuevo.Siguiente = nodoPrevio.Siguiente;
                                nodoPrevio.Siguiente = nodoNuevo;
                                return;
                            }
                        }
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoPrevio.Siguiente = nodoNuevo;
                nodoNuevo.Siguiente = null;
                return;
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
                nodoActual = NodoInicial;
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        if (nodoActual.Equals(NodoInicial))
                        {
                            NodoInicial = nodoActual.Siguiente;
                            nodoEliminado = nodoActual;
                            nodoActual = null;
                            return nodoEliminado.ObjetoConDatos;
                        }
                        else
                        {
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            nodoEliminado = nodoActual;
                            nodoActual = null;
                            return nodoEliminado.ObjetoConDatos;
                        }
                    }
                    else
                    {
                        if (objeto.CompareTo(nodoActual.ObjetoConDatos) < 0)
                        {
                            throw new Exception("No existe el objeto");
                        }
                        else
                        {
                            nodoPrevio = nodoActual;
                            nodoActual = nodoActual.Siguiente;
                        }
                    }
                } while (nodoActual != null);
                throw new Exception("Objeto no encontrado");
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
                nodoActual = NodoInicial;
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);
                throw new Exception("No se encontro el objeto");
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
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                } while (nodoActual != null);
                NodoInicial = null;
            }
        }

        ~ClaseListaOrdenadaSimple()
        {
            if (!Vacia)
            {
                Vaciar();
            }
        }
    }
}
