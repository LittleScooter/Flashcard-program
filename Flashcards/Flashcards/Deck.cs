using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    [Serializable]
    class Deck
    {
        public List<Kort> kort = new List<Kort>();

        public string namn;

        public Queue<Kort> kortKö;

        public void Start()
        {
            kortKö = new Queue<Kort>(kort);
        }

        public void Next(bool answer)
        {
            if (answer)
            {
                kortKö.Dequeue();
            }
            else
            {
                kortKö.Enqueue(kortKö.Dequeue());
            }
        }

        public Deck(string namn)
        {
            this.namn = namn;
        }

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public override string ToString()
        {
            return namn;
        }
    }
}
