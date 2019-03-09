using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Beers
{
    class Stout : Beer
    {
        public bool HasAdjunct { get; }

        public Stout(string brand, string name, double abv, bool hasAdjunct)
            : base(brand, name, abv)
        {
            HasAdjunct = hasAdjunct;
        }
    }
}
