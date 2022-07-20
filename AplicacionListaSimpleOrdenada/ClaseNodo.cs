namespace AplicacionListaSimpleOrdenada
{
    internal class ClaseNodo<Tipo>
    {
        private Tipo _objetoConDatos;

        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        private ClaseNodo<Tipo> _siguiente;

        public ClaseNodo<Tipo> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        ~ClaseNodo()
        {
            this.ObjetoConDatos = default(Tipo);
            this.Siguiente = null;
        }
    }
}
