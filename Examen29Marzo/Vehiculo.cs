using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen29Marzo
{
    internal class Vehiculo : IComparable<Vehiculo>, IEquatable<Vehiculo>
    {
        private string _strPlacas;

        public string Placas
        {
            get { return _strPlacas; }
            set { _strPlacas = value; }
        }

        private int _intModelo;

        public int Modelo
        {
            get { return _intModelo; }
            set { _intModelo = value; }
        }

        private string _strTipo;

        public string Tipo
        {
            get { return _strTipo; }
            set { _strTipo = value; }
        }

        private int _intCapacidadPasajeros;

        public int CapacidadPasajeros
        {
            get { return _intCapacidadPasajeros; }
            set { _intCapacidadPasajeros = value; }
        }

        private string _strNombrePropietario;

        public string NombrePropietario
        {
            get { return _strNombrePropietario; }
            set { _strNombrePropietario = value; }
        }

        private DateTime _dtmHoraIngreso;

        public DateTime HoraIngreso
        {
            get { return _dtmHoraIngreso; }
            set { _dtmHoraIngreso = value; }
        }

        public bool Equals(Vehiculo otroVehiculo)
        {
            return this.Placas == otroVehiculo.Placas;
        }

        public int CompareTo(Vehiculo otroVehiculo)
        {
            if (this.Modelo > otroVehiculo.Modelo)
            {
                return 1;
            }
            else if (this.Modelo < otroVehiculo.Modelo)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public double CalcularTiempo()
        {
            TimeSpan intervalo = DateTime.Now - this.HoraIngreso;
            return intervalo.TotalMilliseconds;
        }
        public override string ToString()
        {
            return ($"Datos del vehiculo con placas {Placas}: \nModelo: {Modelo} \nTipo: {Tipo} \nCapacidad de Pasajeros: {CapacidadPasajeros} \nNombre del propietario: {NombrePropietario} \nHora de ingreso: {HoraIngreso}");
        }
    }
}
