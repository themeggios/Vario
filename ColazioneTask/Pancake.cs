using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColazioneTask
{
    internal class Pancake
    {
        public string Gusto { get; set; }

        public Pancake(string gusto)
        {
            this.Gusto = gusto;
        }

        public enum Gusti
        {
            Acero,
            Miele,
            Fragola,
            Mirtillo,
            Nutella,
            Arachidi
        }
    }
}
