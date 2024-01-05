using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Fusoliera : Componente
    {
        //attributi
        private string _materiale;
        private double _lunghezza;

        //proprietà
        public string Materiale { get { return _materiale; } set { _materiale = value; } }
        public double Lunghezza { get { return _lunghezza; } set { _lunghezza = value; } }

        //costruttori
        public Fusoliera()
        {
            Materiale = "";
            Lunghezza = 0;
        }
        public Fusoliera(string mat, double lun)
        {
            Materiale = mat;
            Lunghezza = lun;
        }
        public Fusoliera(Fusoliera fus)
        {
            Materiale = fus.Materiale;
            Lunghezza = fus.Lunghezza;
        }

        //metodo equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fusoliera))
            {
                return false;
            }
            else
            {
                Fusoliera fus = (Fusoliera)obj;
                return fus != null
                    && Materiale == fus.Materiale
                    && Lunghezza == fus.Lunghezza;
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
            return Materiale + ";" + Lunghezza.ToString();
        }

        //metodi
        public override string Descrizione()
        {
            return "Il materiale della fusoliera è " + Materiale + " e la sua lunghezza è " + Lunghezza.ToString() + ".";
        }

        public override double CalcoloCosto()
        {
            return Lunghezza * 3;
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
