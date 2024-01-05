using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Gomma : Componente
    {
        //attributi
        private double _altezza;
        private double _larghezza;
        private double _raggio;

        //proprietà
        public double Altezza { get { return _altezza; } set { _altezza = value; } }
        public double Larghezza { get { return _larghezza; } set { _larghezza = value; } }
        public double Raggio { get { return _raggio; } set { _raggio = value; } }

        //costruttori
        public Gomma()
        {
            Altezza = 0;
            Larghezza = 0;
            Raggio = 0;
        }
        public Gomma(double alt, double lrg, double rag)
        {
            Altezza = alt;
            Larghezza = lrg;
            Raggio = rag;
        }
        public Gomma(Gomma gm)
        {
            Altezza = gm.Altezza;
            Larghezza = gm.Larghezza;
            Raggio = gm.Raggio;
        }

        //metodo equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Gomma))
            {
                return false;
            }
            else
            {
                Gomma gm = (Gomma)obj;
                return gm != null
                    && Altezza == gm.Altezza
                    && Larghezza == gm.Larghezza
                    && Raggio == gm.Raggio;
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
            return Altezza.ToString() + ";" + Larghezza.ToString() + ";" + Raggio.ToString();
        }

        //metodi
        public override string Descrizione()
        {
            return "L'altezza della gomma è " + Altezza.ToString() + ", la sua larghezza è " + Larghezza.ToString() + " e il suo raggio è " + Raggio.ToString() + ".";
        }

        public override double CalcoloCosto()
        {
            return Altezza * Larghezza * Raggio;
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
