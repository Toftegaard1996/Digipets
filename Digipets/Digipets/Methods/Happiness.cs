using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Methods
{
    class Happiness
    {
        public static string HowHappy(int happiness)
        {

            if (happiness <= 100 && happiness > 75)
            {
                return "Dit kæledyr er virkelig glad lige nu";
            }

            if (happiness <= 75 && happiness > 50)
            {
                return ("Dit kæledyr rimelig glad, men en leg hjælper altid på humøret");
            }

            if (happiness <= 50 && happiness > 25)
            {
                return ("Dit kæledyr føler sig lidt ensom, en leg ville nok hjælpe");
            }

            if (happiness <= 25 && happiness > 0)
            {
                return ("Dit kæledyr føler sig rimelig ensom, du burde overveje at lege med det");
            }

            if (happiness == 0)
            {
                return ("Dit kæledyr er virkelig trist, I burde lege sammen");
            }

            return "Øfferen";
        }
        
    }
}
