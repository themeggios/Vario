using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ColazioneTask.Pancake;

namespace ColazioneTask
{
    internal class Cameriere
    {
        private Piatto piatto;

        public Cameriere(Piatto piatto)
        {
            this.piatto = piatto;
        }

        public void Prepara()
        {
            while (true)
            {
                Random rand = new Random();
                int randomIndex = rand.Next(7);
                Gusti gusto = (Gusti)randomIndex;
                Pancake pancake = new(gusto.ToString());
                piatto.Put(pancake);
                Console.WriteLine($"Cameriere: Pancake {pancake.Gusto} preparato.");
                Task.Delay(5000).Wait();
            }
        }
    }
}
