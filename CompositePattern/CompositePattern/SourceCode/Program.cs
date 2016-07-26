using System;

namespace CompositePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Composite Pattern !\n\n");

            FoodRecipeMenu pizzaRecipe = new FoodRecipeMenu("피자", 15);
            {
                pizzaRecipe.Add(new FoodRecipeIngredient("햄", 10));
                pizzaRecipe.Add(new FoodRecipeIngredient("밀가루", 1));
                pizzaRecipe.Add(new FoodRecipeIngredient("치즈", 5));
            }

            FoodRecipeMenu boiledEggsRecipe = new FoodRecipeMenu("삶은 계란", 10);
            {
                boiledEggsRecipe.Add(new FoodRecipeIngredient("계란", 5));
                boiledEggsRecipe.Add(new FoodRecipeIngredient("소금", 1));
            }

            FoodRecipeMenu vegetableSoupRecipe = new FoodRecipeMenu("야채 수프", 5);
            {
                vegetableSoupRecipe.Add(new FoodRecipeIngredient("야채", 5));
                vegetableSoupRecipe.Add(new FoodRecipeIngredient("수프 가루", 1));
            }

            FoodRecipeBook recipeBook = new FoodRecipeBook();
            recipeBook.Add(pizzaRecipe);
            recipeBook.Add(boiledEggsRecipe);
            recipeBook.Add(vegetableSoupRecipe);

            recipeBook.Print();
        }
    }
}
