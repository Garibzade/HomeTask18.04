using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal class Orange : Fruit
    {
        private float _vitaminC;
        public float VitaminC
        {
            get { return _vitaminC; }
            set { _vitaminC = value; }
        }
        public override void Taste()
        {
            Console.WriteLine("portagal dadi");
        }

        public Orange(decimal price, string sort,float vitaminc) : base(price, sort)
        {
            _vitaminC = vitaminc;
        }


    }
}
