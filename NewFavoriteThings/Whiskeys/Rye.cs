using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Whiskeys
{
    class Rye : Whiskey
    {
        public string OriginState { get; }

        public Rye(string brand, string name, string proof, string origin)
            : base(brand, name, proof)
        {
            OriginState = origin;
        }
    }
}
