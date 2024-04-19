using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18._04.Models
{
    internal abstract class Food
    {
		private float _calorie;

		public float Calorie
		{
			get { return _calorie; }
			set { _calorie = value; }
		}
        protected Food(float calorie)
        {
            Calorie = calorie;
        }

    }
}
