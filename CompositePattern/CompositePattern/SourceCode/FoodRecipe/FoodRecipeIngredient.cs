using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class FoodRecipeIngredient : FoodRecipeComponent
    {
        int _count = 0;
        string _ingredientName = "";

        public FoodRecipeIngredient(string ingredientName, int count)
        {
            _count = count;
            _ingredientName = ingredientName;
        }

        public override void Print()
        {
            Console.WriteLine("Ingredient name : " + _ingredientName + " / Count : " + _count.ToString());

            List<FoodRecipeComponent>.Enumerator enumerator = GetListEnumerator();

            while (enumerator.MoveNext() == true)
            {
                enumerator.Current.Print();
            }
        }
    }
}

