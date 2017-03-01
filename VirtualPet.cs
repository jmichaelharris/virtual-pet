using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualPet
{
   public class VirtualPet
    {
        public string name = "Godzooky";
        private int hungerLevel;
        private int thirstLevel;
        private int boredomLevel;

    public VirtualPet()
        {
            
        }

        public string Name
        {
            get { return this.name; }
            
        }
        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = 20; }
        }
        public int ThirstLevel
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = 20; }
        }
        public int BoredomLevel
        {
            get { return this.boredomLevel; }
            set { this.boredomLevel = 20; }
        }
         
        public void Eat (string food)
        {
          
             food += 2;
        }

        public void Drink (string water)
        {
            water += 2;
        }

        public void Boredom (string play)
        {
             play += 2;
        }


        public void Speak( )
        {
            if (hungerLevel == 15 && hungerLevel <= 20)
            {
                Console.WriteLine(name, " {0} dances with joy, I'm stuffed that was good food ");
            }
            else if (hungerLevel == 10 && hungerLevel <= 14)
            {
                Console.WriteLine(name, "{0} looks around with a sheepish grin, what can we do now ?");
            }
            else if (hungerLevel == 5 && hungerLevel <= 9)
            {
                Console.WriteLine(name, "{0} looks sad, hey I'm getting hungry");
            }
            else
            {
                Console.WriteLine(name, "{0} stomach grumbles loud, momma, momma");
            }

            if (thirstLevel == 15 && thirstLevel <= 20)
            {
                Console.WriteLine("/(h)wō/ {0} whoa that hit the hot spot ");
            }
            else if (thirstLevel == 10 && thirstLevel <= 14)
            {
                Console.WriteLine("{0} looks directly at you, what can we do for fun ?");
            }
            else if (thirstLevel == 5 && thirstLevel <= 9)
            {
                Console.WriteLine(name, "{0} looks at you with dry lips, hey I'm parched");
            }
            else
            {
                Console.WriteLine(name, "{0} oh lawd, loud grumbling , momma, momma, they're a terrible pet owner ");
            }

            if (boredomLevel == 15 && boredomLevel <= 20)
            {
                Console.WriteLine(" OMG where is {0}, ", name, " at, ");
                Console.WriteLine(" you see people running past you terrified & the building on fire  ");
                Console.WriteLine(" ENTER PLAY, #4 QUICK, before he burns up your neighborhood");
            }
            else if (boredomLevel == 10 && boredomLevel <= 14)
            {
                Console.WriteLine(name, " {0} looks down at the ground, you look up,");
                Console.WriteLine( " and see the neighbors trash can on fire ");
            }
            else if (boredomLevel == 5 && boredomLevel <= 9)
            {
                Console.WriteLine(name,  "{0} come on, lets go on a run");
            }
            else
            {
                Console.WriteLine(name,  "{0} looks at you & says, lets have some fun ");
            }
        }
        
    }
    
}
