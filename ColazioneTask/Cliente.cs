using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColazioneTask
{
    internal class Cliente
    {
        private Piatto piatto;

        public Cliente(Piatto piatto)
        {
            this.piatto = piatto;
        }

        public async void  Mangia()
        {
            while (true)
            {
                Pancake pancake = piatto.Get();
                Console.WriteLine($"Cliente: Mangiato pancake {pancake.Gusto}.");
                Task.Delay(1000).Wait();
            }
        }
    }
}
