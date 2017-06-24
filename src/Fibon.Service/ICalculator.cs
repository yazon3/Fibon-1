using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibon.Service
{
    public interface ICalculator
    {
        int DoYourJob(int number);
    }

    public class SlowOne : ICalculator
    {
        public int DoYourJob(int number)
        {
            return int.MaxValue;
        }
    }
}
