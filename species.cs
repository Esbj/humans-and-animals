using System;
using System.Collections.Generic;
namespace humans_and_animals
{
    public class SactuaryResidents{
        public int hungerLevel;
        public string name;
        public int maxHunger;
        public SactuaryResidents(){
            hungerLevel = 0;
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