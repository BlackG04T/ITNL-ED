using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionABB
{
    internal class ClaseNodo<Tipo>
    {
        private Tipo _objetoConDatos;
        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        private ClaseNodo<Tipo> _hijoIzq;
        public ClaseNodo<Tipo> HijoIzq
        {
            get { return _hijoIzq; }
            set { _hijoIzq = value; }
        }

        private ClaseNodo<Tipo> _hijoDer;
        public ClaseNodo<Tipo> HijoDer
        {
            get { return _hijoDer; }
            set { _hijoDer = value; }
        }

        ~ClaseNodo()
        {
            ObjetoConDatos = default(Tipo);
        }
    }
}
