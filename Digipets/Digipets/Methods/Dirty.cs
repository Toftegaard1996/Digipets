using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Methods
{
    class Dirty
    {
        public static string HowDirty(int dirt) 
        {
            if (dirt >= 0)
                
            {
                return "Dit kæledyr er helt rent";
            }

            if (dirt >= 25 && dirt < 50)
            {
                return "Dit kæledyr er en smule beskidt, men kan godt vente med badet";
            }

            if (dirt >= 50 && dirt < 75)
            {
                return "Dit kæledyr er godt snavset, du burde overveje et bad";
            }

            if (dirt >= 75 && dirt < 100)
            {
                return "Dit kæledyr er rimelig beskedt, du burde virkelig overveje et give det et bad";
            }

            if (dirt == 100)
            {
                return "Dit kæledyr er mega beskidt, du burde give det et bad!";
            }

            return "Øfferen";
        }
    }
}
