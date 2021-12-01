using System;
using BabyStroller.SDK;

namespace Animal2.Lib
{
    [Unfinished]
    public class Sheep : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Maaa~");
            }
        }
    }
}