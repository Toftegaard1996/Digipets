using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Methods
{
    class Age
    {
        public static int petAge() 
        {
            Random rnd = new Random();
            return rnd.Next(0, 5);
        }
    }
}
