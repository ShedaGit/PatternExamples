﻿using Strategy.Infrastructure.Interfaces;

namespace Strategy.Infrastructure.Strategies
{
    internal class SimpleDisplayStrategy : IDisplayStrategy
    {
        readonly string _displayName;

        public SimpleDisplayStrategy(string displayName)
        {
            _displayName = displayName;
        }

        public void Display()
        {
            Console.WriteLine(_displayName);
        }
    }
}
