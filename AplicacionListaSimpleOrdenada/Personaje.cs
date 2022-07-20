using System;

namespace AplicacionListaSimpleOrdenada
{
    internal class Personaje : IComparable<Personaje>, IEquatable<Personaje>
    {
        private string _intCriatura;

        public string Criatura
        {
            get { return _intCriatura; }
            set { _intCriatura = value; }
        }

        private int _IDPersonaje;

        public int IDPersonaje
        {
            get { return _IDPersonaje; }
            set { _IDPersonaje = value; }
        }

        private double _dblAltura;

        public double Altura
        {
            get { return _dblAltura; }
            set { _dblAltura = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private char _chrSexo;

        public char Sexo
        {
            get { return _chrSexo; }
            set { _chrSexo = value; }
        }

        private bool _blnOlimpo;

        public bool Olimpo
        {
            get { return _blnOlimpo; }
            set { _blnOlimpo = value; }
        }

        private DateTime _dtmFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        private string _strRutaFoto;

        public string RutaFoto
        {
            get { return _strRutaFoto; }
            set { _strRutaFoto = value; }
        }

        public bool Equals(Personaje otroPersonaje)
        {
            return this.IDPersonaje == otroPersonaje.IDPersonaje;
        }

        public int CompareTo(Personaje otroPersonaje)
        {
            if (this.IDPersonaje > otroPersonaje.IDPersonaje)
            {
                return 1;
            }
            else if (this.IDPersonaje < otroPersonaje.IDPersonaje)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            string strOlimpoUserSide = Olimpo == true ? "Si" : "No";
            return ($"Datos de {Nombre} con identificador {IDPersonaje}: \nAltura: {Altura} \nSexo: {Sexo} \nTipo de Criatura: {Criatura} \n¿Pertenece al Olimpo?: {strOlimpoUserSide} \nFecha de nacimiento: {FechaNacimiento.ToShortDateString()}");
        }
    }
}
