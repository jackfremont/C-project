using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Cocktail_List
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Making a drink?");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Enter a new cocktail");
                Console.WriteLine("2. Find a cocktail by name");
                Console.WriteLine("3. Find a cocktail by ingredient");
                Console.Write("Select an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Enter the name of your cocktail");
                        var cocktailName = Console.ReadLine();
                        Console.WriteLine("How many ingredients are in your cocktail?");
                        var numOfIngredients = Convert.ToInt32(Console.ReadLine());
                        List<Ingredient> ingredientList = new List<Ingredient>();
                        for (int i = 1; i <= numOfIngredients; i++)
                        {
                            Ingredient ingredient = new Ingredient();
                            Console.WriteLine("Ingredient #" + i);
                            Console.WriteLine("What is the name of the ingredient?");
                            ingredient.IngredientName = Console.ReadLine();
                            Console.WriteLine("How much of the ingredient?");
                            ingredient.amount = Console.ReadLine();
                            ingredientList.Add(ingredient);

                        }
                        Console.WriteLine("Out of 5, how tasty is this cocktail?");
                        var rating = Convert.ToInt32(Console.ReadLine());
                        CocktailList.CreateCocktail(cocktailName, ingredientList, rating);
                        Console.WriteLine("Your cocktail has been added to the list!");
                        break;
                    case "2":
                        Console.WriteLine("Enter the name of the Cocktail you're trying to find: ");
                        cocktailName = Console.ReadLine();
                        CocktailList.findCocktailbyName(cocktailName);
                        break;
                    case "3":
                        Console.WriteLine("What ingredient do you want to look up cocktails for? ");
                        var ingredientName = Console.ReadLine();
                        CocktailList.findCocktailbyIngredient(ingredientName);
                        break;
                }
            }
        }
    }
}
