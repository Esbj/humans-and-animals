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
        static List <SactuaryResidents> animals = new List<SactuaryResidents>();
        static void printAnimals(){
            Console.WriteLine("I djur helgedomen finns det:");
            
            foreach(SactuaryResidents Resident in animals){
                Console.WriteLine("En "+Resident.Species+" som heter "+Resident.name);
 
            }
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
            giraffe BrittMarie = new giraffe();
            BrittMarie.name = "Britt-Marie";
            animals.Add(BrittMarie);

            elephant Bella = new elephant();
            Bella.name = "Bella";
            animals.Add(Bella);
            elephant Olle = new elephant();
            Olle.name = "Olle";
            animals.Add(Olle);
            elephant Theodor = new elephant();
            Theodor.name = "Theodor";
            animals.Add(Theodor);

            cyotee Lisa = new cyotee();
            Lisa.name = "Lisa";
            animals.Add(Lisa);
            cyotee Åke = new cyotee();
            Åke.name = "Åke";
            animals.Add(Åke);
            cyotee Göran = new cyotee();
            Göran.name = "Göran";
            animals.Add(Göran);

            seal Gösta = new seal();
            Gösta.name = "Gösta";
            animals.Add(Gösta);
            Gösta.hungerLevel = 10;
            seal Erika = new seal();
            Erika.name = "Erika";
            Erika.hungerLevel = 5;
            animals.Add(Erika);

            bear Ola = new bear();
            Ola.name = "Ola";
            Ola.hungerLevel = 2;
            animals.Add(Ola);
            bear Ulla = new bear();
            Ulla.name = "Ulla";
            Ulla.hungerLevel = 1;
            animals.Add(Ulla);
            bear Felix = new bear();
            Felix.name = "Felix";
            animals.Add(Felix);
            bear Konrad = new bear();
            Konrad.name = "Konrad";
            animals.Add(Konrad);

            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 50;
            int food = nrOfMeatLeft + nrOfVeggiesLeft;
            int day = 0;
            // Day loop
            while (food > 0){
                day++;
                Console.WriteLine("-------");
                Console.WriteLine("Dag " + day + ":");
                Console.WriteLine("-------");

                // LÄGG TILL DIN NYA KOD HÄR

                // Wait for the next day
                Console.ReadKey();
            }
            Console.WriteLine("Maten är slut! ");
        }
    }
}