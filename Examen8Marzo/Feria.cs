using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen8Marzo
{
    internal class Feria : IComparable<Feria>, IEquatable<Feria>
    {
        private int _intVisitantesDiarios;

        public int VisitantesDiarios
        {
            get { return _intVisitantesDiarios; }
            set { _intVisitantesDiarios = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private int _intIDFeria;

        public int IDFeria
        {
            get { return _intIDFeria; }
            set { _intIDFeria = value; }
        }

        private char _chrNivelSeguridadJuegos;

        public char NivelSeguridadJuegos
        {
            get { return _chrNivelSeguridadJuegos; }
            set { _chrNivelSeguridadJuegos = value; }
        }

        private double _dblPrecioEntrada;

        public double PrecioEntrada
        {
            get { return _dblPrecioEntrada; }
            set { _dblPrecioEntrada = value; }
        }

        private DateTime _dtmFechaApertura;

        public DateTime FechaApertura
        {
            get { return _dtmFechaApertura; }
            set { _dtmFechaApertura = value; }
        }

        private bool _blnTodasEdades;

        public bool TodasEdades
        {
            get { return _blnTodasEdades; }
            set { _blnTodasEdades = value; }
        }

        private string _strAtraccionPrincipal;

        public string AtraccionPrincipal
        {
            get { return _strAtraccionPrincipal; }
            set { _strAtraccionPrincipal = value; }
        }

        public bool Equals(Feria otraFeria)
        {
            return this.IDFeria == otraFeria.IDFeria;
        }
        public int CompareTo(Feria otraFeria)
        {
            if (this.IDFeria > otraFeria.IDFeria)
            {
                return 1;
            }
            else if (this.IDFeria < otraFeria.IDFeria)
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
            string strTodasEdades = TodasEdades ? "Si" : "No"; 
            return ($"Datos de la feria {Nombre} con ID {IDFeria}: \nVisitantes Diarios: {VisitantesDiarios} \nSexo de la Mayoria de Visitantes: {NivelSeguridadJuegos} \nPrecio de Entrada: {PrecioEntrada} \nFecha de Apertura: {FechaApertura.ToShortDateString()} \n¿Es para todas las edades?: {strTodasEdades} \nAtracción Principal: {AtraccionPrincipal}");
        }
    }
}
