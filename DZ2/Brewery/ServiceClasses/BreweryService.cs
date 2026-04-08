using Brewery.Classes;
using Brewery.ContextDataBase;

namespace Brewery.ServiceClasses
{
    public class BreweryService
    {
        List<Recipe> recipes;
        List<Ingredient> ingredients;
        List<StockIngredient> stockIngredients;
        List<Beer> beers;

        public BreweryService()
        {
            recipes = Data.Recipes;
            ingredients = Data.Ingredients;
            stockIngredients = Data.StockIngredients;
            beers = Data.Beers;
        }

        public bool CanBrew(Dictionary<Ingredient, long> ingredientsFromRecipe, out StockIngredient[] arrayStock)
        {
            var count = 0;
            arrayStock = new StockIngredient[ingredientsFromRecipe.Count()];
            foreach (var ingredientFromRecipe in ingredientsFromRecipe)
            {
                var ingredientOrNull = stockIngredients.FirstOrDefault(i => i.Ingredient.Id == ingredientFromRecipe.Key.Id && i.Quantity >= ingredientFromRecipe.Value);
                if (ingredientOrNull is not null)
                {
                    try
                    {
                        arrayStock[count] = ingredientOrNull;
                        count += 1;
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        return false;
                    }
                }
            }

            if (count == ingredientsFromRecipe.Count())
            {
                return true;
            }
            return false;
        }

        public bool Brew(Recipe recipe)
        {
            var count = 0;
            var arrayStock = new StockIngredient[recipe.Ingredients.Count()];
            if (CanBrew(recipe.Ingredients, out arrayStock))
            {
                foreach (var ingredientFromStock in arrayStock)
                {
                    var existIngredient = recipe.Ingredients.FirstOrDefault(i => i.Key.Id == ingredientFromStock.Ingredient.Id && i.Key.Name == ingredientFromStock.Ingredient.Name);
                    if (existIngredient.Key is not null)
                    {
                        ingredientFromStock.Quantity -= recipe.Ingredients[existIngredient.Key];
                        count += 1;
                    }
                }

                if (count == recipe.Ingredients.Count())
                {
                    var beer = recipe.Brew();
                    beers.Add(beer);
                    return true;
                }
            }
            return false;
        }
    }
}
