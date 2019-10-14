using System;
using System.Collections.Generic;
namespace humans_and_animals
{
    public class SactuaryResidents{
        public int hungerLevel;
        public string name;
        public int age;
        public int maxHunger;
        public string Species;
        public SactuaryResidents(){
            hungerLevel = 0;
            age = 0;
            Species = "Unknown";
        }
    }
    public class Eater : SactuaryResidents{
        //ingen check, just eat
    }
    public class Vegan : SactuaryResidents{
        //kontroll så de endast kan äta växter?
    }
    public class Predator : SactuaryResidents{
        //Check only eat meat?
    }
}