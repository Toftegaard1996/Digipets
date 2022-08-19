using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Classes
{
    class Pet
    {
        public string Breed;
        public string Name;
        public int Age;
        public string Owner;
        public int Dirt;
        public int Happiness;
        public int Hunger;

        public Pet( string name, string owner) 
        {
            Breed = Methods.Breed.BreedOfPet();
            Name = name;
            Age = Methods.Age.petAge();
            Owner = owner;
            Dirt = 0;
            Happiness = 75;
            Hunger = 50;
        }
        public void Tick() 
        {
            Dirt++;
            Happiness--;
            Hunger--;
        }
        public override string ToString()
        {
            return Breed + " " + Name + " " + Age + " " + Owner + " " + Dirt + " " + Happiness + " " + Hunger;
        }
    }
}
