﻿using System;

namespace CSOOPPatterns.FactoryMethod
{
    public class Cargo : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine($"{GetType().Name}: *доставляет по грузовически*");
        }
    }
}