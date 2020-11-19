using System;

namespace Classes_Toy
{
    public class Toy
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Notes;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }

        public Toy(string notes, double x)
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = notes;

        }

        public Toy(string man, string name, double price, string notes)
        {
            Manufacturer = man;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int number = rand.Next(1, 25);

            return Manufacturer[0] + "" + number;
        }

        public override string ToString()
        {
            return $"{Manufacturer} makes {Name} and sells it for {Price.ToString("C")}\n" +
            Notes    ;
        }

    }
}