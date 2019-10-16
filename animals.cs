using System;
using System.Collections.Generic;
namespace humans_and_animals{
    public class giraffe : Vegan{
        public giraffe(){
            Species = "Giraff";
            maxHunger = 7;
        }
    }
    public class Elephant : Vegan{
        public Elephant(){
            maxHunger = 10;
            Species = "Elefant";
        }
    }
    public class Cyotee : Predator{
        public Cyotee(){
            maxHunger = 15;
            Species = "Prärievarg";
        }
    }
    public class Seal : Predator{
        public Seal(){
            maxHunger = 13;
            Species = "Säl";
        }

    }
    public class Bear : Eater{
        public Bear(){
            maxHunger = 3;
            Species = "Björn";
        }

    }
}