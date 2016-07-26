using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class FoodRecipeMenu : FoodRecipeComponent
    {
        int _cookTime = 0;
        string _recipeName = "";

        public FoodRecipeMenu(string recipeName, int cookTime)
        {
            _cookTime = cookTime;
            _recipeName = recipeName;
        }

        public override void Print()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Recipe name : " + _recipeName);
            Console.WriteLine("Cook time : " + _cookTime.ToString() + " Minute");
            Console.WriteLine("\n< 재료 >");

            List<FoodRecipeComponent>.Enumerator enumerator = GetListEnumerator();

            while (enumerator.MoveNext() == true)
            {
                enumerator.Current.Print();
            }
        }
    }
}

