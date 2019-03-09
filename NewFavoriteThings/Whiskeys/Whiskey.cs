
using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Whiskeys
{
    abstract class Whiskey
    {
        public string Brand { get; }
        public string Name { get; }
        public string Proof { get; }

        public Whiskey(string brand, string name, string proof)
        {
            Brand = brand;
            Name = name;
            Proof = proof;
        }

        public virtual string Buzz()

        {
            return "Wine is fine, but liquor's quicker.";
        }
    }
}