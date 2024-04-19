using HomeTask18._04.Models;
using System.Reflection;

namespace HomeTask18._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Apple apple = new Apple(1.2m, "qizilehmedi", 8.2f, 7.8f);
            //Pineapple pineapple = new Pineapple(3.5m, "Uzun ananas", 9.3f, 6.7f);
            //Orange orange = new Orange(2.7m, "sulu portagal", 12.8f);
            //Fruit[] Baskets = new Fruit[] { apple, orange, pineapple };
            //foreach (var fruit in Baskets)
            //{
            //    Type type = fruit.GetType();
            //    Console.WriteLine(type.Name);

            //    PropertyInfo[] properties = type.GetProperties();
            //    foreach (var property in properties)
            //    {
            //        object value = property.GetValue(fruit);
            //        Console.WriteLine($"{property.Name}: {value}");
            //    }

            //    Console.WriteLine();
            //}
            Cow vorInek = new Cow("disi");
            Leon sir=new Leon("kisi",false);
            Leon peleng=new Leon("oglan",true);
            Meat meat = new Meat(123.3f,"TOYUQ");
            Grass ot= new Grass(78.4f,"saman");

            Animal[] animals = {vorInek,sir,peleng };
           foreach (var animal in animals)
            {
                if (animal is Cow)
                {
                    Cow cow = (Cow)animal;
                    cow.EatFood(ot);

                }
                else if (animal is Leon)
                {
                   Leon leon = (Leon)animal;
                    leon.EatFood(meat);
                   
                }
                else if (animal is Leon)
                {
                    Leon leo = (Leon)animal;
                    leo.EatFood(ot);
                }

            }






        }
    }
}
