using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Ruota : IComponente
    {
        //attributi
        private Cerchione _cerchione;
        private Gomma _gomma;

        //proprietà
        public Cerchione Cerchione { get { return _cerchione; } set { _cerchione = value; } }
        public Gomma Gomma { get { return _gomma; } set { _gomma = value; } }

        //costruttori
        public Ruota()
        {
            Cerchione = new Cerchione();
            Gomma = new Gomma();
        }
        public Ruota(Cerchione cer, Gomma gm)
        {
            Cerchione = cer;
            Gomma = gm;
        }
        public Ruota(Ruota rt)
        {
            Cerchione = rt.Cerchione;
            Gomma = rt.Gomma;
        }

        //metodo equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Ruota))
            {
                return false;
            }
            else
            {
                Ruota rt = (Ruota)obj;
                return rt != null
                    && Cerchione == rt.Cerchione
                    && Gomma == rt.Gomma;
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
            return Gomma + ";" + Cerchione.ToString();
        }

        //metodi
        public string Descrizione()
        {
            return Cerchione.Descrizione() + " " + Gomma.Descrizione();
        }

        public double CalcoloCosto()
        {
            return Cerchione.CalcoloCosto() + Gomma.CalcoloCosto();
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
