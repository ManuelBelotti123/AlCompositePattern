using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Ruota : Componente
    {
        //attributi
        private List<Componente> _componenti;
        private int _numcomponenti;

        //proprietà
        public List<Componente> Componenti { get { return _componenti; } set { _componenti = value; } }
        public int Numcomponenti { get { return _numcomponenti; } set { _numcomponenti = value; } }

        //costruttori
        public Ruota()
        {
            Componenti = new List<Componente>();
            Numcomponenti = 0;
        }
        public Ruota(Cerchione cer, Gomma gm)
        {
            Componenti = new List<Componente>();
            Componenti.Add(cer);
            Componenti.Add(gm);
            Numcomponenti = 2;
        }
        public Ruota(Ruota rt)
        {
            Componenti = new List<Componente>();
            Componenti = rt.Componenti;
            Numcomponenti = rt.Numcomponenti;
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
                    && Componenti == rt.Componenti
                    && Numcomponenti == rt.Numcomponenti;
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
            string tot = "";
            for (int i = 0; i < Numcomponenti; i++)
            {
                tot += Componenti[i].ToString();
                if (i != Numcomponenti - 1)
                {
                    tot += ";";
                }
            }
            return tot;
        }

        //metodi
        public override void Add(Componente cmp)
        {
            Componenti.Add(cmp);
            Numcomponenti++;
        }

        public override void Remove(int ind)
        {
            Componenti.RemoveAt(ind);
            Numcomponenti--;
        }

        public override string GetChild(int ind)
        {
            return Componenti[ind].ToString();
        }

        public override string Descrizione()
        {
            string tot = "";
            for (int i = 0; i < Numcomponenti; i++)
            {
                tot += Componenti[i].Descrizione();
                if (i != Numcomponenti - 1)
                {
                    tot += "\n";
                }
            }
            return tot;
        }

        public override double CalcoloCosto()
        {
            double tot = 0;
            for (int i = 0; i < Numcomponenti; i++)
            {
                tot += Componenti[i].CalcoloCosto();
            }
            return tot;
        }
    }
}
