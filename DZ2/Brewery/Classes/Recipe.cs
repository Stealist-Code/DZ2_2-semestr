using Brewery.Enums;

namespace Brewery.Classes
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameBeer { get; set; }
        public BeerType BeerType { get; set; }
        public double AlcoholPercentage { get; set; }
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
            return new Beer(NameBeer, AlcoholPercentage, BeerType);
        }
    }
}
