﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal class Aliante : Componente
    {
        //attributi
        private List<Componente> _componenti;
        private int _numcomponenti;

        //proprietà
        public List<Componente> Componenti { get { return _componenti; } set { _componenti = value; } }
        public int Numcomponenti { get { return _numcomponenti; } set { _numcomponenti = value; } }

        //costruttori
        public Aliante()
        {
            Componenti = new List<Componente>();
            Numcomponenti = 0;
        }
        public Aliante(Ala al, Fusoliera fus, Coda coda, Ruota rt)
        {
            Componenti = new List<Componente>();
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
