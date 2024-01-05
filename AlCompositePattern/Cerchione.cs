using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Cerchione : IComponente
    {
        //attributi
        private double _pollici;
        private string _materiale;

        //proprietà
        public double Pollici { get { return _pollici; } set { _pollici = value; } }
        public string Materiale { get { return _materiale; } set { _materiale = value; } }

        //costruttori
        public Cerchione()
        {
            Pollici = 0;
            Materiale = "";
        }
        public Cerchione(double pol, string mat)
        {
            Pollici = pol;
            Materiale = mat;
        }
        public Cerchione(Cerchione cer)
        {
            Pollici = cer.Pollici;
            Materiale = cer.Materiale;
        }

        //metodo equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Cerchione))
            {
                return false;
            }
            else
            {
                Cerchione cer = (Cerchione)obj;
                return cer != null
                    && Pollici == cer.Pollici
                    && Materiale == cer.Materiale;
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
            return Materiale + ";" + Pollici.ToString();
        }

        //metodi
        public string Descrizione()
        {
            return "Il materiale del cerchione è " + Materiale + " e i suoi pollici sono " + Pollici.ToString() + ".";
        }

        public double CalcoloCosto()
        {
            return Pollici * 2;
        }

        public void Add(IComponente cpm)
        {
            throw new NotImplementedException();
        }

        public void Remove(int ind)
        {
            throw new NotImplementedException();
        }

        public string GetChild(int ind)
        {
            throw new NotImplementedException();
        }
    }
}
