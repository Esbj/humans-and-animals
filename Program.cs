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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Day loop
            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 50;
            int day = 0;
            while (true)
            {
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

                // LÄGG TILL DIN NYA KOD HÄR

                // Wait for the next day
                Console.ReadKey();
            }
        }
    }
}