using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen29Marzo
{
    internal class ClasePila<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        private ClaseNodo<Tipo> _top;

        private ClaseNodo<Tipo> Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public bool Vacia
        {
            get
            {
                return Top == null ? true : false;
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            ClaseNodo<Tipo> nodoActual = Top;
            do
            {
                yield return nodoActual.ObjetoConDatos;
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);
            yield break;
        }

        public void Push(Tipo objeto)
        {
            if (Vacia)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                Top = nodoNuevo;
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoNuevo;
                nodoActual = Top;
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Objetos duplicados");
                    }
                    else if (nodoActual.ObjetoConDatos.CompareTo(objeto) > 0)
                    {
                        if (objeto.CompareTo(Top.ObjetoConDatos) < 0)
                        {
                            nodoNuevo = new ClaseNodo<Tipo>();
                            nodoNuevo.ObjetoConDatos = objeto;
                            nodoNuevo.Siguiente = Top;
                            Top = nodoNuevo;
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
                } while (nodoActual != null);
                nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoPrevio.Siguiente = nodoNuevo;
                nodoNuevo.Siguiente = null;
                return;
            }
        }

        public Tipo Pop() 
        {
            if (Vacia)
            {
                throw new Exception("Pila vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                nodoActual = Top;
                nodoEliminado = nodoActual;
                Top = Top.Siguiente;
                nodoActual = null;
                return nodoEliminado.ObjetoConDatos;
            }
        }

        public Tipo Pop(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Pila vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                nodoActual = Top;
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        if (nodoActual.Equals(Top))
                        {
                            nodoEliminado = nodoActual;
                            Top = nodoActual.Siguiente;
                            nodoActual = null;
                            return nodoEliminado.ObjetoConDatos;
                        }
                        else
                        {
                            nodoEliminado = nodoActual;
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            nodoActual = null;
                            return nodoEliminado.ObjetoConDatos;
                        }
                    }
                    else if (objeto.CompareTo(nodoActual.ObjetoConDatos) > 0)
                    {
                        throw new Exception("No existe el objeto");
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                throw new Exception("Objeto no encontrado");
            }
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Pila vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Top;
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
                throw new Exception("Pila vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = Top;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                } while (nodoActual != null);
                Top = null;
            }
        }

        ~ClasePila()
        {
            if (!Vacia)
            {
                Vaciar();
            }
        }
    }
}
