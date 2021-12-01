using System;
using BabyStroller.SDK;

namespace Animal2.Lib
{
    public class Dog : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Wang!");
            }
        }
    }
}