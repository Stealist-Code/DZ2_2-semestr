using Brewery.Enums;
using System.ComponentModel;

namespace Brewery.Classes
{
    public class Beer
    {
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Содержание алкоголя (%)")]
        public double AlcoholPercentage { get; set; }

        [DisplayName("Сорт пива")]
        public BeerType BeerType { get; set; }

        [DisplayName("Дата производства")]
        public DateTime Time { get; set; }

        [DisplayName("Рецепт")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Recipe Recipe { get; set; }

        public Beer() { }

        public Beer(string name, double alcoholPercentage, BeerType beerType)
        {
            Id = Guid.NewGuid();
            Name = name;
            AlcoholPercentage = alcoholPercentage;
            BeerType = beerType;
            Time = DateTime.Now;
        }

        public Beer (string name, double alcoholPercentage, BeerType beerType, Recipe recipe)
        {
            Id = Guid.NewGuid();
            Name = name;
            AlcoholPercentage = alcoholPercentage;
            BeerType = beerType;
            Time = DateTime.Now;
            Recipe = recipe;
        }
    }
}
