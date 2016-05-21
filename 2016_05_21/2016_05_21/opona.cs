using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_05_21
{
    class opona
    {
        public opona ()
        {
            CzySprawna = true;
        }
        private bool CzySprawna { get; set; }

        bool Sprawdz ()
        {
            return CzySprawna;
        }

        void Napraw()
        {
            if(CzySprawna==false)
            {
                CzySprawna = true;
                Console.WriteLine("Opóna sprawna");
            }
        }

        void Uzyj ()
        {
            double rnd = 0;
            Random random = new Random();
            rnd = random.Next(0, 30)/100;  
        }
    }
}
