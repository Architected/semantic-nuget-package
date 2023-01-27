﻿using Useful.Implementation.Shared.Behaviours;

namespace Useful.Implementation
{
    public class MathOperations : IMathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
