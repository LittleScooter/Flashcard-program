using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    class Deck
    {
        public string namn;

        public Deck (string namn)
        {
            this.namn = namn;
        }

        public string Namn
        {
            get { return namn; }
        }

        public override string ToString()
        {
            return namn;
        }
    }
}
