using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3Mayo
{
    internal class Cliente : IComparable<Cliente>, IEquatable<Cliente>
    {
        private int _intIDCliente;

        public int IDCliente
        {
            get { return _intIDCliente; }
            set { _intIDCliente = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private double _dblAltura;

        public double Altura
        {
            get { return _dblAltura; }
            set { _dblAltura = value; }
        }


        public bool Equals(Cliente otroCliente)
        {
            return this.Nombre == otroCliente.Nombre;
        }

        public int CompareTo(Cliente otroCliente)
        {
            if (Nombre != null)
            {
                if (Nombre.CompareTo(otroCliente.Nombre) == 1)
                {
                    return 1;
                }
                else if (Nombre.CompareTo(otroCliente.Nombre) == -1)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return Nombre.ToString();
        }
        public string ToString(string strResultado)
        {
            if (strResultado == "Datos")
            {
                return ($"Altura del cliente {Nombre} con ID {IDCliente}: {Altura}m");
            }
            else
            {
                throw new Exception("Error en metodo ToString");
            }
        }
    }
}
