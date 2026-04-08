using Brewery.Classes;

namespace Brewery.ContextDataBase
{
    public static class Data
    {
        public static List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public static List<Recipe> Recipes { get; set; } = new List<Recipe>();
        public static List<Beer> Beers { get; set; } = new List<Beer>();
        public static List<StockIngredient> StockIngredients { get; set; } = new List<StockIngredient>();
    }
}
