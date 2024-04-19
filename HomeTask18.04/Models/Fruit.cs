using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal abstract class Fruit
    {
        private decimal _price;
        private string _sort;
     

       
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value>0)
                {
                _price = value;

                } 
            }
        }

        public string Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
        protected Fruit(decimal price,string sort)
        {
            Sort = sort;
            Price = price;
        }

        public abstract void Taste();







    }
}
