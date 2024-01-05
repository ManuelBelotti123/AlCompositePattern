using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Aliante : IComponente
    {
        //attributi
        private List<IComponente> _componenti;
        private int _numcomponenti;

        //proprietà
        public List<IComponente> Componenti { get { return _componenti; } set { _componenti = value; } }
        public int Numcomponenti { get { return _numcomponenti; } set { _numcomponenti = value; } }

        //costruttori
        public Aliante()
        {
            Componenti = new List<IComponente>();
            Numcomponenti = 0;
        }
        public Aliante(Ala al, Fusoliera fus, Coda coda, Ruota rt)
        {
            Componenti = new List<IComponente>();
            Componenti.Add(al);
            Componenti.Add(al);
            Componenti.Add(fus);
            Componenti.Add(coda);
            Componenti.Add(rt);
            Componenti.Add(rt);
            Numcomponenti = 6;
        }
        public Aliante(Aliante aln)
        {
            Componenti = aln.Componenti;
            Numcomponenti = aln.Numcomponenti;
        }

        //metodo equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Aliante))
            {
                return false;
            }
            else
            {
                Aliante aln = (Aliante)obj;
                return aln != null
                    && Componenti == aln.Componenti
                    && Numcomponenti == aln.Numcomponenti;
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
        public void Add(IComponente cmp)
        {
            Componenti.Add(cmp);
            Numcomponenti++;
        }

        public void Remove(int ind)
        {
            Componenti.RemoveAt(ind);
            Numcomponenti--;
        }

        public string GetChild(int ind)
        {
            return Componenti[ind].ToString();
        }

        public string Descrizione()
        {
            string tot = "";
            for (int i = 0; i < Numcomponenti; i++)
            {
                if (Componenti[i].Descrizione() == Componenti[i + 1].Descrizione())
                {
                    i++;
                }
                tot += Componenti[i].Descrizione();
                if (i != Numcomponenti - 1)
                {
                    tot += "\n";
                }
            }
            return tot;
        }

        public double CalcoloCosto()
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
