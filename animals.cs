using System;
using System.Collections.Generic;
namespace humans_and_animals
{
    public class SactuaryResidents{
        int hungerLevel;
        string name;
        public SactuaryResidents(){
            hungerLevel = 0;
        }
    }
    public class Eater{
        //ingen check, just eat
    }
    public class Vegans : SactuaryResidents{
        //kontroll så de endast kan äta växter?
    }
    public class Predators : SactuaryResidents{
        //Check only eat meat?
    }
}