using System;
using System.Collections.Generic;
namespace humans_and_animals
{
    public class SactuaryResidents
    {

        public string name;
        public int hungerLevel;
        public int maxHunger;
        public string Species;
        public bool IsHungry;
        public string FoodType;
        public SactuaryResidents()
        {
            hungerLevel = 0;
        }
        public int Eat(int food)
        {
            hungerLevel = 0;
            return food--;
        }
    }
    public class Eater : SactuaryResidents
    {
        //kolla vilken mat som är mest utav. Then eat it
    }
    public class Vegan : SactuaryResidents
    {
        //kontroll så de endast kan äta växter?
        public Vegan()
        {
            FoodType = "grass";
        }
    }
    public class Predator : SactuaryResidents
    {
        //Check only eat meat?
        public Predator()
        {
            FoodType = "meat";
        }
    }
}
