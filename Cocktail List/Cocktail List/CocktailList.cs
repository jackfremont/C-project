using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Cocktail_List
{
    static class CocktailList
    {
        private static readonly List<Cocktail> cocktails = new List<Cocktail>();





        public static void CreateCocktail(string cocktailName, List<Ingredient> ingredients, int rating)
        {

            var cocktail = new Cocktail
            { 
                Name = cocktailName,
                IngredientList = ingredients,
                Rating = rating
            };


            cocktails.Add(cocktail);
       
        }

        public static void findCocktailbyName(string cocktailName)
        {
            foreach (var cocktail in cocktails)
            {
                if (cocktail.Name == cocktailName)
                {
                    printOutCocktail(cocktail);
                }
            }
        }

        private static void printOutCocktail(Cocktail cocktail)
        {
            Console.WriteLine(cocktail.Name);
            foreach (var ingredient in cocktail.IngredientList)
            {
                Console.WriteLine(ingredient.IngredientName + ":" + ingredient.amount);
            }
            Console.WriteLine("Rating: " + cocktail.Rating + "out of 5");
        }

        public static void findCocktailbyIngredient(string ingredient)
        {
            List<Cocktail> foundCocktails = new List<Cocktail>();
            foreach (var cocktail in cocktails)
            {
                foreach (var cocktailIngredient in cocktail.IngredientList)
                {
                    if (cocktailIngredient.IngredientName == ingredient)
                    {
                        foundCocktails.Add(cocktail);
                        break;
                    }
                }
            }

            foreach (var cocktail in foundCocktails)
            {
                printOutCocktail(cocktail);
            }
        }
        

    }

   
}
