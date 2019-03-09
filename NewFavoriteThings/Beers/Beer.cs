
using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Beers
{
    abstract class Beer
    {
        public string Brand { get; }
        public string Name { get; }
        public double Abv { get; }

        public Beer(string brand, string name, double abv)
        {
            Brand = brand;
            Name = name;
            Abv = abv;
        }
    }
}