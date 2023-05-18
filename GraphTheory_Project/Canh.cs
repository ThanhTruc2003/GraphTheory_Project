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

        public Canh(int trongso, Dinh dinhdau, Dinh dinhcuoi)
        {
            Trongso1 = trongso;
            Dinhdau1 = dinhdau;
            Dinhcuoi1 = dinhcuoi;
        }

        public int Trongso1 { get; set; }
        public Dinh Dinhdau1 { get; set; }
        public Dinh Dinhcuoi1 { get; set; }
    }
}
