using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class FoodRecipeBook : FoodRecipeComponent
    {
        public override void Print()
        {
            Console.WriteLine("[ 요리 레시피 ] ");

            List<FoodRecipeComponent>.Enumerator enumerator = GetListEnumerator();

            while (enumerator.MoveNext() == true)
            {
                enumerator.Current.Print();
            }
        }
    }
}

