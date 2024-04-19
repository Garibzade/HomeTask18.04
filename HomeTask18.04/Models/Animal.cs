using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal abstract class Animal
    {
        private string _breed;

        public string BReed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        protected Animal(string breed)
        {
           BReed = breed;
            
        }
        public abstract void Breed();
        public abstract void MakeSound( );

        public abstract void EatFood(Food food);
        
    }
}
