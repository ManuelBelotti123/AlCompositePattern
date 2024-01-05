using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Ala : Componente
    {
        //attributi
        private double _lunghezza;
        private double _apertura;

        //proprietà
        public double Lunghezza { get { return _lunghezza;} set { _lunghezza = value;} }
        public double Apertura { get { return _apertura;} set { _apertura = value;} }

        //costruttori
        public Ala()
        {
            Lunghezza = 0;
            Apertura = 0;
        }
        public Ala(double lun, double apr)
        {
            Lunghezza = lun;
            Apertura = apr;
        }
        public Ala(Ala ala)
        {
            Lunghezza = ala.Lunghezza;
            Apertura = ala.Apertura;
        }

        //metodo equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Ala))
            {
                return false;
            }
            else
            {
                Ala ala = (Ala)obj;
                return ala != null
                    && Lunghezza == ala.Lunghezza
                    && Apertura == ala.Apertura;
            }
        }

        //metodo GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //metodo ToString
        public override string ToString()
        {
            return Lunghezza.ToString() + ";" + Apertura.ToString();
        }

        //metodi
        public override string Descrizione()
        {
            return "La lunghezza dell'ala è " + Lunghezza.ToString() + " e la sua apertura è " + Apertura.ToString() + ".";
        }

        public override double CalcoloCosto()
        {
            return Lunghezza * Apertura;
        }

        public override void Add(Componente cpm)
        {
            throw new NotImplementedException();
        }

        public override void Remove(int ind)
        {
            throw new NotImplementedException();
        }

        public override string GetChild(int ind)
        {
            throw new NotImplementedException();
        }
    }
}
