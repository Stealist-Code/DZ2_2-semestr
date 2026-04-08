namespace Brewery.Classes
{
    public class StockIngredient
    {
        public Ingredient Ingredient { get; set; }
        public long Quantity { get; set; }

        public StockIngredient() { }

        public StockIngredient(Ingredient ingredient, long quantity)
        {
            Ingredient = ingredient;
            Quantity = quantity;
        }
    }
}
