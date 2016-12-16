using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Audi1 : Car
    {
        
        public int vitezometru(int acceleratie)
        {
            if (acceleratie == 50)
                    return 2;
            else if (acceleratie == 30)
                    return 1;
            else
                    return 0;
        }
    }
}
