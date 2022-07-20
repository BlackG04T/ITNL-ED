using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionABB
{
    internal class Personaje : IComparable<Personaje>, IEquatable<Personaje>
    {
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

        private int _intEdad;

        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }

        public bool Equals(Personaje otroPersonaje)
        {
            return this.Nombre == otroPersonaje.Nombre;
        }

        public int CompareTo(Personaje otroPersonaje)
        {
            if (this.Edad > otroPersonaje.Edad)
            {
                return 1;
            }
            else if (this.Edad < otroPersonaje.Edad)
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
            return Edad.ToString();
        }
        public string ToString(string strReturn)
        {
            if (strReturn == "Datos")
            {
                return ($"Datos de {Nombre}: \nAltura: {Altura} \nEdad: {Edad}");
            }
            else
            {
                throw new Exception("Error en método ToString");
            }
        }
    }
}
