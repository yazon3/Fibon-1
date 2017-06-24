using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibon.Service
{
    public interface ICalculator
    {
        int CalculateFibonacci(int number);
    }

    public class SlowOne : ICalculator
    {
        public int CalculateFibonacci(int number)
        {
            switch (number)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return CalculateFibonacci(number - 2) + CalculateFibonacci(number - 1);
            }
        }
    }
}
