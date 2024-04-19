using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal class Leon : Animal
    {
        private bool _leder;

        public bool Leder
        {
            get { return _leder; }
            set { _leder = value; }
        }



        public Leon(string breed,bool leder) : base(breed)
        {
            Leder = leder;
        }

      

        public override void Breed()
        {
            Console.WriteLine(BReed);
        }

        public override void EatFood(Food food)
        {
            if (food is Meat) { Console.WriteLine("sir bu gunde doydu sukur Yarebimize"); }
            else { Console.WriteLine("heyff, sir bu gun ac qaldi"); }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miaooooo");
        }
       
    }
}
