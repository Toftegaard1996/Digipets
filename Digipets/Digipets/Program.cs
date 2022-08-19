using System;
using Digipets.Classes;
using Digipets.Methods;
using System.IO;

namespace Digipets
{
    class Program
    {

        public static void Save(Pet pet)
        {
            string separtor = ",";
            string createText = pet.Breed + separtor + pet.Name + separtor + pet.Age + separtor + pet.Owner + separtor + pet.Dirt + separtor + pet.Happiness + separtor + pet.Hunger;
            File.WriteAllText("pet.csv", createText);
        }
        public static void Load()
        {
           

        }

        static void Main(string[] args)
        {
            //string directory = Directory.GetCurrentDirectory();
            //string path = System.IO.Path.Combine(directory + "\\pet.");
            //string[] Kasseliste = File.ReadAllLines(path);
            //string[] petInfo = path.Split(',');
            //string[] SplittetText = Kasseliste[0].Split(',');
            //string savedBreed = Kasseliste[0];
            //string savedName = Kasseliste[1];
            //string savedAge = Kasseliste[2];
            //string savedOwner = Kasseliste[3];
            //string savedDirt = Kasseliste[4];
            //string savedHappiness = Kasseliste[5];
            //string savedHunger = Kasseliste[6];
            //Console.ReadKey();
            string owner;
            string name;
            Pet PetOverview = new Pet("Default","Default");

            //if (!File.Exists(path))
            //{

            //}
            //else 
            //{
            //    Console.WriteLine("Du har allerede et gemt kæledyr");
            //    Console.WriteLine("Race: " + savedBreed + "\nNavn: " + savedName + "\nAlder: " + savedAge + "\nEjer: " + savedOwner + "\nSnavs: " + savedDirt + "\nGlæde: " + savedHappiness + "\nSult: " + savedHunger);
            //    Console.WriteLine("1: Ja");
            //    Console.WriteLine("2. Nej");
            //    int optionSave = int.Parse(Console.ReadLine());
            //    switch (optionSave)
            //    {
            //        case 1: 
            //        default:
            //            break;
            //    }
            //}
                Console.WriteLine("Introducing your new pet!");
                Console.WriteLine("Men først, hvad hedder du?");
                owner = Console.ReadLine();
                Console.WriteLine("Hvad hedder din nye ven?");
                name = Console.ReadLine();
                PetOverview = new Pet(name, owner);
                Save(PetOverview);

                int age = PetOverview.Age;
                string breed = PetOverview.Breed;

                Console.Clear();
                Console.WriteLine("Din nye ven har nu fået et navn");
                Console.WriteLine("Her er et overblik over dit kæledyr");
                Console.WriteLine("Race: " + PetOverview.Breed + "\nNavn: " + PetOverview.Name + "\nAlder: " + PetOverview.Age + "\nEjer: " + PetOverview.Owner);

            while (PetOverview.Hunger > 0)
            {
                Console.WriteLine("\nHvad vil du foretage dig nu?");
                Console.WriteLine("1: Se info");
                Console.WriteLine("2: Se hvor sulten dit kæledyr er");
                Console.WriteLine("3: Se hvor beskidt dit kæledyr er");
                Console.WriteLine("4: Se hvor glad dit kæledyr er");
                Console.WriteLine("5: Leg med dit kæledyr");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Race " + PetOverview.Breed + "\nNavn " + PetOverview.Name + "\nAlder " + PetOverview.Age + "\nEjer " + PetOverview.Owner);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(Hunger.HowHungry(PetOverview.Hunger));
                        Console.WriteLine("\nVil du fodre " + PetOverview.Name + "?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2. Nej");
                        int optionHunger = int.Parse(Console.ReadLine());
                        switch (optionHunger)
                        {
                            case 1: 
                                PetOverview.Hunger = PetOverview.Hunger + 25;
                                Console.WriteLine("Du giver " + PetOverview.Name + " mad. Mæthed steget med 25");
                                break;
                            case 2: Console.WriteLine("Modtaget, bare ikke vent for længe");
                                break;
                            default:
                                break;
                        }
                        PetOverview.Tick();
                        break; ;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(Dirty.HowDirty(PetOverview.Dirt));
                        Console.WriteLine("\nVil du vaske " + PetOverview.Name + "?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2. Nej");
                        int optionDirt = int.Parse(Console.ReadLine());
                        switch (optionDirt)
                        {
                            case 1:
                                PetOverview.Dirt = PetOverview.Dirt - 25;
                                Console.WriteLine("Du giver " + PetOverview.Name + " et bad. Snavs fjernet 25");
                                break;
                            case 2:
                                Console.WriteLine("Modtaget, bare ikke vent for længe");
                                break;
                            default:
                                break;
                        }
                        PetOverview.Tick();
                        break; ;
                    case 4:
                        Console.Clear();
                            

                        Console.WriteLine(Happiness.HowHappy(PetOverview.Happiness));
                        Console.WriteLine("\nVil du lege " + PetOverview.Name + "?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2. Nej");
                        int optionHappy = int.Parse(Console.ReadLine());
                        switch (optionHappy)
                        {
                            case 1:
                                PetOverview.Happiness = PetOverview.Happiness + 25;
                                Console.WriteLine("Du leger " + PetOverview.Name + ". Glæde stiger med 25");
                                break;
                            case 2:
                                Console.WriteLine("Modtaget, bare ikke vent for længe");
                                break;
                            default:
                                break;
                        }
                        PetOverview.Tick();
                        break; ;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\nVil du lege med " + PetOverview.Name + "?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2. Nej");
                        int optionGame = int.Parse(Console.ReadLine());
                        switch (optionGame)
                        {
                            case 1:
                                PetOverview.Happiness = PetOverview.Happiness + 25;
                                Console.WriteLine("Du leger med " + PetOverview.Name + ". Glæde stiger med 25");
                                break;
                            case 2:
                                Console.WriteLine("Modtaget, bare ikke vent for længe");
                                break;
                            default:
                                break;
                        }
                        break; ;
                    default:
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Dit kæledyr er død af sult, du skulle have fodret det noget mere...");
        }
    }
}
