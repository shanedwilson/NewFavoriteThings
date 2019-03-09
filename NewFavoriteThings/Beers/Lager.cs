using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Beers
{
    class Lager : Beer
    {
        public bool IsCraft { get; }

        public Lager(string brand, string name, double abv, bool isCraft)
            : base(brand, name, abv)
        {
            IsCraft = isCraft;
        }
    }
}
