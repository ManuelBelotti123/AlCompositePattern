using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCompositePattern
{
    internal interface IComponente
    {
        string Descrizione();
        double CalcoloCosto();
        void Add(IComponente cmp);
        void Remove(int ind);
        string GetChild(int ind);
    }
}
