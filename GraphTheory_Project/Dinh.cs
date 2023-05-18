using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory_Project
{
    public class Dinh
    {
        string giatri = "";
        int toadoX = 0;
        int toadoY = 0;

        public Dinh()
        {
        }

        public Dinh(string giatri, int toadoX, int toadoY)
        {
            this.Giatri = giatri;
            this.ToadoX = toadoX;
            this.ToadoY = toadoY;
        }

        public string Giatri { get; set; }
        public int ToadoX { get; set; }
        public int ToadoY { get; set; }
    }
}
