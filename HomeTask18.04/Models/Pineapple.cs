using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal class Pineapple : Fruit
    {
        private float _vitaminE;
        private float _vitaminD;

        public float VitaminE
        {
            get { return _vitaminE; }
            set { _vitaminE = value; }
        }


        public Pineapple(decimal price, string sort ,float vitamine, float vitamind) : base(price, sort)
        {
            VitaminE = vitamine;
            VitanimD = vitamind;
        }

        public float VitanimD
        {
            get { return _vitaminD; }
            set { _vitaminD = value; }
        }
       

        public override void Taste()
        {
            Console.WriteLine("anans dadir");
        }
    }
}
