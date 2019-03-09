using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Beers
{
    class IPA : Beer
    {
        public string Hop { get; }

        public IPA(string brand, string name, double abv, string hop)
            : base(brand, name, abv)
        {
            Hop = hop;
        }
    }
}
