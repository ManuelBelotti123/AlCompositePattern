using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    abstract class Componente
    {
        public abstract string Descrizione();
        public abstract double CalcoloCosto();
        public abstract void Add(IComponente cmp);
        public abstract void Remove(int ind);
        public abstract string GetChild(int ind);
    }
}