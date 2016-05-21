using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_05_21
{
    class wyscigowka
    {
        public wyscigowka(double WagaBez, double maxPred)
        {
            WagaBezSilnika = WagaBez;
            WagaZSilnikiem = WagaBez + ZamontowanySilnik.Waga;
            opony = new opona[4];
            MaxPredkosc = maxPred;
            CzyGotowa = false;
            //foreach (opona opona in opony)
            //{
            //    opony = new opona();
            //}

        }

        private Silnik ZamontowanySilnik { get; set; }
        private opona[] opony { get; set; }
        private double WagaBezSilnika { get; set; }
        private double WagaZSilnikiem { get; set; }
        private double MaxPredkosc { get; set; }
        private bool CzyGotowa { get; set; }
    }
}
