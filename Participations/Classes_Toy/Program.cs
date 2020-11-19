using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox livingRoomToyBox = new ToyBox();
            ToyBox playRoomToyBox = new ToyBox();

            Toy teddybear = new Toy();
            teddybear.Manufacturer = "Hasbro";
            teddybear.Name = "Teddy Ruxpin";
            teddybear.Price = 49.99;
            //teddybear.Notes  !!!! **** THIS IS PRIVATE so we cannot access it from this class

            Toy lego1 = new Toy("Lego", "Star wars ship", 39.99, "Not for kids under 5 because they might eat them");
            Toy lego2 = new Toy("Lego", "Star wars ship", 39.99, "Not for kids under 5 because they might eat them");
            Toy lego3 = new Toy("Lego", "Star wars ship", 39.99, "Not for kids under 5 because they might eat them");

            livingRoomToyBox.Toys.Add(teddybear);
            livingRoomToyBox.Toys.Add(lego1);

            playRoomToyBox.Toys.Add(lego2);
            playRoomToyBox.Toys.Add(lego3);

            Toy rando = livingRoomToyBox.GetRandomToy();
            Console.WriteLine($"{rando.Manufacturer} makes {rando.Name} and sells it for {rando.Price.ToString("C")}");
            rando = playRoomToyBox.GetRandomToy();
            Console.WriteLine(rando);

            Console.ReadKey();
        }
    }
}
