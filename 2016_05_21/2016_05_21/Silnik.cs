using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_05_21
{
    class Silnik
    {
        public Silnik (string model, double moc, double waga)
        {
            model = Model;
            Moc = moc;
            Waga = waga;
        }
        public string Model { get; private set; }
        public double Moc { get; private set; }
        public double Waga { get; private set; }
    }
}
