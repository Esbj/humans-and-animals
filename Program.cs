using System;
using System.Collections.Generic;
/*
    Skapa en lista med olika djur som finns i djurparken, minst ett av varje typ av djur.
    När man kör programmet ska alla djur, deras typ och deras namn skrivas ut på skärmen.
*/
namespace humans_and_animals
{
    class Program
    {
        static List<SactuaryResidents> animals = new List<SactuaryResidents>();
        static void printAnimals()
        {
            Console.WriteLine("I djur helgedomen finns det:");

            // foreach(SactuaryResidents Resident in animals){
            //     Console.WriteLine("En "+Resident.Species+" som heter "+Resident.name);

            // }
        }
        static void Main(string[] args)
        {


            //Deklarerar djur, ger dom namn och lägger till i listan
            giraffe Amanda = new giraffe();
            Amanda.name = "Amanda";
            animals.Add(Amanda);
            giraffe Veronica = new giraffe();
            Veronica.name = "Veronica";
            animals.Add(Veronica);
            giraffe Jimmy = new giraffe();
            Jimmy.name = "Jimmy";
            animals.Add(Jimmy);

            Elephant Berit = new Elephant();
            Berit.name = "Bella";
            animals.Add(Berit);
            Elephant Olle = new Elephant();
            Olle.name = "Olle";
            animals.Add(Olle);
            Elephant Theodor = new Elephant();
            Theodor.name = "Theodor";
            animals.Add(Theodor);

            Cyotee Lisa = new Cyotee();
            Lisa.name = "Lisa";
            animals.Add(Lisa);
            Cyotee Åke = new Cyotee();
            Åke.name = "Åke";
            animals.Add(Åke);
            Cyotee Göran = new Cyotee();
            Göran.name = "Göran";
            animals.Add(Göran);

            Seal Gösta = new Seal();
            Gösta.name = "Gösta";
            animals.Add(Gösta);
            Gösta.hungerLevel = 10;
            Seal Erika = new Seal();
            Erika.name = "Erika";
            Erika.hungerLevel = 5;
            animals.Add(Erika);

            Bear Ola = new Bear();
            Ola.name = "Ola";
            Ola.hungerLevel = 2;
            animals.Add(Ola);
            Bear Ulla = new Bear();
            Ulla.name = "Ulla";
            Ulla.hungerLevel = 1;
            animals.Add(Ulla);
            Bear Felix = new Bear();
            Felix.name = "Felix";
            animals.Add(Felix);
            Bear Konrad = new Bear();
            Konrad.name = "Konrad";
            animals.Add(Konrad);


            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 50;
            int food = nrOfMeatLeft + nrOfVeggiesLeft;
            int day = 0;
            // Day loop
            while (food > 0)
            {
                day++;
                Console.WriteLine("-------");
                Console.WriteLine("Dag " + day + ":");
                Console.WriteLine("-------");

                //loopa igenom alla djur och mata dom med rätt mat 
                foreach (SactuaryResidents Resident in animals)
                {
                    if (Resident.IsHungry)
                    {
                        if (Resident.FoodType == "grass")
                        {
                            nrOfVeggiesLeft = Resident.Eat(nrOfVeggiesLeft);
                        }
                        else if (Resident.FoodType == "meat")
                        {
                            //mata med kött
                            nrOfMeatLeft = Resident.Eat(nrOfMeatLeft);
                        }
                        else
                        {
                            if (nrOfMeatLeft > nrOfVeggiesLeft)
                            {
                                //mata med kött
                                nrOfMeatLeft = Resident.Eat(nrOfMeatLeft);
                            }
                            else
                            {
                                //mata med växt
                                nrOfVeggiesLeft = Resident.Eat(nrOfVeggiesLeft);
                            }
                        }
                    }
                Resident.hungerLevel++;                    
                }
                    // Wait for the next day
                    Console.WriteLine("Tryck för att gå vidare till nästa dag");
                    Console.ReadKey();
                }
                Console.WriteLine("Maten är slut! ");
            }
        }
    }