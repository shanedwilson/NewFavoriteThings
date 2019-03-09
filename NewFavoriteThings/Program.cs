using System;
using NewFavoriteThings.Whiskeys;
using NewFavoriteThings.Motorcycles;
using NewFavoriteThings.Beers;
using NewFavoriteThings.Comedians;

namespace NewFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmw = new Modern("BMW", "R1150-RT", 2005);

            var honda = new Vintage("Honda", "Nighthawk 700SC", 1986);

            var grassroots = new IPA("Calfkiller", "Grassroots", 5.7, "unknown");

            var getUpGetDown = new Stout("Wiseacre", "Gotta Get Up To Get Down", 5, true);

            var elijah = new Bourbon("Elijah Craig", "Small Batch", "94", "Kentucky");

            var balcones = new Bourbon("Balcones", "True Blue", "100", "Texas");

            var sarah = new Female("Sarah", "Silverman", "Jesus Is Magic");

            var cross = new Male("David", "Cross", "Mr. Show");


            Console.WriteLine("These are my current favorite motorcycles:");
            Console.WriteLine(bmw.Year + " " + bmw.Make + " " + bmw.Model);
            Console.WriteLine(honda.Year + " " + honda.Make + " " + honda.Model);
            Console.WriteLine("");
            Console.WriteLine("These are some of my favorite beers:");
            Console.WriteLine(grassroots.Brand + " " + grassroots.Name + " is " + grassroots.Abv + "%");
            Console.WriteLine(getUpGetDown.Brand + " " + getUpGetDown.Name + " is a " + getUpGetDown.Abv + "%");
            Console.WriteLine("");
            Console.WriteLine("These are some of my favorite whiskeys:");
            Console.WriteLine(elijah.Brand + " " + elijah.Name + " is " + elijah.Proof + " proof");
            Console.WriteLine(balcones.Brand + " " + balcones.Name + " is " + balcones.Proof + " proof");
            Console.WriteLine("");
            Console.WriteLine("These are some of my favorite comedians:");
            Console.WriteLine(sarah.FirstName + " " + sarah.LastName + " was awesome in '" + sarah.BestWork + "'");
            Console.WriteLine(cross.FirstName + " " + cross.LastName + " was awesome in '" + cross.BestWork + "'");

            Console.ReadKey();

        }
    }
}