using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPilaOrdenada
{
    internal class Personaje : IComparable<Personaje>, IEquatable<Personaje>
    {
        private string _strCriatura;

        public string Criatura
        {
            get { return _strCriatura; }
            set { _strCriatura = value; }
        }

        private int _intIDPersonaje;

        public int IDPersonaje
        {
            get { return _intIDPersonaje; }
            set { _intIDPersonaje = value; }
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