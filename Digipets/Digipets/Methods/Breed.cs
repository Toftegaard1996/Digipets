using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Methods
{
    class Breed
    {
        public static string BreedOfPet() 
        {
            Random rnd = new Random();
            string finalBreed = "";
            int whichBreed = rnd.Next(1, 5);
            switch (whichBreed)
            {
                case 1: 
                    finalBreed = "Tiger";
                break;
                case 2:
                    finalBreed = "Unicorn";
                    break;
                case 3:
                    finalBreed = "Pixie";
                    break;
                case 4:
                    finalBreed = "Puffball";
                    break;
                case 5:
                    finalBreed = "Raven";
                    break;
                default:
                    break;
            }
            return finalBreed;
        }
    }
}
