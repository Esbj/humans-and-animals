using System;
using System.Collections.Generic;
namespace humans_and_animals{
    public class giraffe : Vegan{
        public giraffe(){
            Species = "Giraff";
            maxHunger = 7;
        }
    }
    public class elephant : Vegan{
        public elephant(){
            maxHunger = 10;
            Species = "Elefant";
        }
    }
    public class cyotee : Predator{
        public cyotee(){
            maxHunger = 15;
            Species = "Prärievarg";
        }
    }
    public class seal : Predator{
        public seal(){
            maxHunger = 13;
            Species = "Säl";
        }

    }
    public class bear : Eater{
        public bear(){
            maxHunger = 3;
            Species = "Björn";
        }

    }
}