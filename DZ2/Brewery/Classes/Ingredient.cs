namespace Brewery.Classes
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UnitMeasurement { get; set; }

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
    }
}
