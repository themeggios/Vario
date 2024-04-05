using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColazioneTask
{
    internal class Piatto
    {
        private object _lock = new();
        private Queue<Pancake> pancakes = new();
        private const int capacity = 5;

        public int Count { get { lock (_lock) return pancakes.Count; } }

        public void Put(Pancake pancake)
        {
            lock (_lock)
            {
                while (pancakes.Count >= capacity)
                    Monitor.Wait(_lock);

                pancakes.Enqueue(pancake);
                Monitor.Pulse(_lock);
            }
        }

        public Pancake Get()
        {
            lock (_lock)
            {
                while (pancakes.Count == 0)
                    Monitor.Wait(_lock);

                Pancake pancake = pancakes.Dequeue();
                Monitor.Pulse(_lock);
                return pancake;
            }
        }
    }
}
