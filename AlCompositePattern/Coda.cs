using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Coda : Componente
    {
        //attributi
        private double _lunghezza;

        //proprietà
        public double Lunghezza { get { return _lunghezza; } set { _lunghezza = value; } }

        //costruttori
        public Coda()
        {
            Lunghezza = 0;
        }
        public Coda(double lun, double apr)
        {
            Lunghezza = lun;
        }
        public Coda(Coda coda)
        {
            Lunghezza = coda.Lunghezza;
        }

        //metodo equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Coda))
            {
                return false;
            }
            else
            {
                Coda coda = (Coda)obj;
                return coda != null
                    && Lunghezza == coda.Lunghezza;
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
            return Lunghezza.ToString();
        }

        //metodi
        public override string Descrizione()
        {
            return "La lunghezza della coda è " + Lunghezza.ToString() + ".";
        }

        public override double CalcoloCosto()
        {
            return Lunghezza * 5;
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
