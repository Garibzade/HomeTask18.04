using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal class Apple : Fruit
    {
        private float _vitaminA;
        private float _vitaminB;

        public float VitaminA
        {
            get { return _vitaminA; }
            set { _vitaminA = value; }
        }

        public float VitaminB
        {
            get { return _vitaminB; }
            set { _vitaminB = value; }
        }

        public Apple(decimal price, string sort, float vitamina, float vitaminb) : base(price, sort)
        {
            VitaminA = vitamina;
            VitaminB = vitaminb;
        }

        public override void Taste()
        {
            Console.WriteLine("alma dadir");
        }
    }
}


      

