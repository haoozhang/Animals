﻿using System;
using BabyStroller.SDK;

namespace Animals1.Lib
{
    public class Cat : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Miao~");
            }
        }
    }
}