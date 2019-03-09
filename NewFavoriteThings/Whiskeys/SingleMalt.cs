using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Whiskeys
{
    class SingleMalt : Whiskey
    {
        public string OriginCountry { get; }

        public SingleMalt(string brand, string name, string proof, string origin)
            : base(brand, name, proof)
        {
            OriginCountry = origin;
        }
    }
}
