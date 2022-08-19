using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Methods
{
    class Hunger
    {
        public static string HowHungry(int hunger)
        {
            if (hunger <= 100 && hunger > 75)
            {
                return "Dit kæledyr er helt mæt, der er ikke plads til mere";
            }

            if (hunger <= 75 && hunger > 50)
            {
                return "Dit kæledyr ville ikke have noget imod en snack, men er ellers rimelig mæt";
            }

            if (hunger <= 50 && hunger > 25)
            {
                return "Dit kæledyr kunne godt bruge noget at spise";
            }

            if (hunger <= 25 && hunger > 0)
            {
                return "Dit kæledyr er virkelig sulten, hvis du ikke snart giver det mad, vil det dø";
            }

            if (hunger == 0)
            {
                return "Dit kæledyr er nu død af sult, du skulle have passet bedre på det";
            }

            return "Øfferen";
        }
    }
}
