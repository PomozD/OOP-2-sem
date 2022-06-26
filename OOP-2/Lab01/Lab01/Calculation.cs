using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Calculation: InterfaceCalculation
    {
        private double memory = 0;

        public void Memory_Clear()
        { 
            memory = 0.0;
        }
        public double MemoryShow()
        {
            return memory;
        }
        public void M_Sum(double b)
        {
            memory += b;
        }
        public void M_Sub(double b)
        {
            memory -= b;
        }
    }
}
