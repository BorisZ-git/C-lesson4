using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Doubler
    {
        int current = 1;
        int finish;        
        public Doubler(int finish)
        {
            this.finish = finish;            
        }
        public void Increase()
        {
            current += 1;
        }
        public void Multi()
        {
            current *= 2;
        }
        public void Reset()
        {
            current = 1;
        }
    }
}
