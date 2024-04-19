using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal class Cow : Animal
    {
        public Cow(string breed) : base(breed)
        {

        }

        public override void Breed()
        {
            Console.WriteLine(BReed);
        }

        public override void EatFood(Food food)
        {
            if (food is Grass) { Console.WriteLine("inek ot yeye bilir"); }
            else { Console.WriteLine("inekotdan basqa yemek yeye bilmir"); }
        }

        public override void MakeSound()
        {
            Console.WriteLine(" MMMMMMMooooooooooooooooooouuuuuuuuu");
        }
        public void ProduceMilk()
        {
            Console.WriteLine("inekden sud cixirrr...");
        }
    }
}
