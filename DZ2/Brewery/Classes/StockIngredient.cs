using System.ComponentModel;

namespace Brewery.Classes
{
    public class StockIngredient
    {
        [DisplayName("Ингредиент")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Ingredient Ingredient { get; set; }

        [DisplayName("Количество")]
        public long Quantity { get; set; }

        public StockIngredient() { }

        public StockIngredient(Ingredient ingredient, long quantity)
        {
            Ingredient = ingredient;
            Quantity = quantity;
        }
    }
}
