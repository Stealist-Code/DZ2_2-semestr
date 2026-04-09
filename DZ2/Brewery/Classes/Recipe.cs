using Brewery.Enums;
using System.ComponentModel;

namespace Brewery.Classes
{
    public class Recipe
    {
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Название рецепта")]
        public string Name { get; set; }

        [DisplayName("Название пива")]
        public string NameBeer { get; set; }

        [DisplayName("Сорт пива")]
        public BeerType BeerType { get; set; }

        [DisplayName("Содержание алкоголя (%)")]
        public double AlcoholPercentage { get; set; }

        [DisplayName("Ингредиенты")]
        public Dictionary<Ingredient, long> Ingredients { get; set; } = new Dictionary<Ingredient, long>();

        public Recipe() { }

        public Recipe(string name, string nameBeer, BeerType beerType, double AlcoholResentage)
        {
            Id = Guid.NewGuid();
            Name = name;
            NameBeer = nameBeer;
            BeerType = beerType;
            AlcoholPercentage = AlcoholResentage;
        }

        public Beer Brew()
        {
            return new Beer(NameBeer, AlcoholPercentage, BeerType, this);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
