using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszamjatekGUI
{
    class Jatekos
    {
        public string nev;
        public List<int> tippek;
        public int fordulokSzama { get { return tippek.Count; } }
        public Jatekos(string sor)
        {
            string[] t = sor.Split();
            nev = t[0];
            tippek = new List<int>();
            foreach (var i in t.Skip(1))
            {
                tippek.Add(int.Parse(i));
                }
        }
    }
}
