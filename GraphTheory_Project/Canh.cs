using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory_Project
{
    public class Canh
    {
        int Trongso = 0;
        Dinh Dinhdau = new Dinh();
        Dinh Dinhcuoi = new Dinh();

        public Canh()
        {
        }

        public Canh(int Trongso, Dinh Dinhdau, Dinh Dinhcuoi)
        {
            this.Trongso = Trongso;
            this.Dinhdau = Dinhdau;
            this.Dinhcuoi = Dinhcuoi;
        }

        public int Trongso1 { get; set; }
        public Dinh Dinhdau1 { get; set; }
        public Dinh Dinhcuoi1 { get; set; }
    }
}
