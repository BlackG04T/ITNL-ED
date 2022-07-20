using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionColaOrdenada
{
    internal class ClaseColaOrdenada<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        private ClaseNodo<Tipo> _frente;

        private ClaseNodo<Tipo> Frente
        {
            get { return _frente; }
            set { _frente = value; }
        }

        private ClaseNodo<Tipo> _final;

        private ClaseNodo<Tipo> Final
        {
            get { return _final; }
            set { _final = value; }
        }

        public ClaseColaOrdenada()
        {
            Frente = null;
            Final = null;
        }

        public bool Vacia
        {
            get{
                return Final == null && Frente == null ? true : false;
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Frente;
            do
            {
                yield return nodoActual.ObjetoConDatos;
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);
            yield break;
        }

        public void Encolar(Tipo objeto)
        {
            if (Vacia)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                Frente = nodoNuevo;
                Final = nodoNuevo;
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = Frente;
                nodoPrevio = Frente;
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Objetos duplicados");
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoPrevio.Siguiente = nodoNuevo;
                nodoNuevo.Siguiente = null;
                Final = nodoNuevo;
                return;
            }
        }

        public Tipo Desencolar()
        {
            if (Vacia)
            {
                throw new Exception("Cola vacía");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                nodoActual = Frente;
                if (nodoActual.Equals(Final) && nodoActual.Equals(Frente))
                {
                    nodoEliminado = nodoActual;
                    nodoActual = null;
                    Frente = null;
                    Final = null;
                    return nodoEliminado.ObjetoConDatos;
                }
                else
                {
                    nodoEliminado = nodoActual;
                    Frente = nodoActual.Siguiente;
                    nodoActual = null;
                    return nodoEliminado.ObjetoConDatos;
                }
            }
        }

        public Tipo Desencolar(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Cola vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                nodoActual = Frente;
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        if (nodoActual.Equals(Final) && nodoActual.Equals(Frente))
                        {
                            nodoEliminado = nodoActual;
                            nodoActual = null;
                            Frente = null;
                            Final = null;
                            return nodoEliminado.ObjetoConDatos;
                        }
                        else if (nodoActual.Equals(Frente))
                        {
                            nodoEliminado = nodoActual;
                            Frente = nodoActual.Siguiente;
                            nodoActual = null;
                            return nodoEliminado.ObjetoConDatos;
                        }
                        else if (nodoActual.Equals(Final))
                        {
                            nodoEliminado = nodoActual;
                            Final = nodoActual.Siguiente;
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
                throw new Exception("Cola vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Frente;
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
                throw new Exception("Cola vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio= new ClaseNodo<Tipo>();
                nodoActual = Frente;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                } while (nodoActual != null);
                Frente = null;
                Final = null;
                return;
            }
        }

        ~ClaseColaOrdenada()
        {
            if (!Vacia)
            {
                this.Vaciar();
            }
        }
    }
}
