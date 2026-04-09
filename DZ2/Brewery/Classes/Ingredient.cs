using System.ComponentModel;

namespace Brewery.Classes
{
    public class Ingredient
    {
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Единица измерения")]
        public string UnitMeasurement { get; set; }

        [DisplayName("Дата производства")]
        public DateTime Date { get; set; }

        [DisplayName("Страна производства")]
        public string CountryManufacture {  get; set; }

        public Ingredient() { }

        public Ingredient(string name, string unitMeasurement)
        {
            Id = Guid.NewGuid();
            Name = name;
            UnitMeasurement = unitMeasurement;
        }

        public Ingredient(Guid id, string name, string unitMeasurement)
        {
            Id = id;
            Name = name;
            UnitMeasurement = unitMeasurement;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
