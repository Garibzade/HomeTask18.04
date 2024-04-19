using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal class Meat:Food
    {
		private string _name;

        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
        public Meat(float calorie,string name) : base(calorie)
        {
            Name = name;
        }

       
    }
}
