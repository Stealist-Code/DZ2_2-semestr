using Brewery.Enums;

namespace Brewery.Classes
{
    public class Beer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double AlcoholPercentage { get; set; }
        public BeerType BeerType { get; set; }

        public Beer() { }

        public Beer (string name, double alcoholPercentage, BeerType beerType)
        {
            Id = Guid.NewGuid();
            Name = name;
            AlcoholPercentage = alcoholPercentage;
            BeerType = beerType;
        }
    }
}
