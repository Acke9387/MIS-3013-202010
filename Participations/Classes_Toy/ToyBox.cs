using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Toy
{
    class ToyBox
    {

        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
        }

        public Toy GetRandomToy ( )
        {

            //1. Generate a random number between 0 and the # of toys in the Toys property
            Random rand = new Random();
            int index = rand.Next(0, Toys.Count);

            //2. Get the Toy object at the index of the random # you generated
            Toy rToy = Toys[index];
            //3. Return the toy from #2
            return rToy;
        }

    }
}
