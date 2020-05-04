using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    class Kort
    {
        public string fråga;
        public string svar;

        public Kort(string fråga, string svar)
        {
            this.fråga = fråga;
            this.svar = svar;
        }
    }
}
