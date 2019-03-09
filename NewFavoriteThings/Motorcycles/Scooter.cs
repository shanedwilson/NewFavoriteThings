using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Motorcycles
{
    class Scooter : Motorcycle
    {
        public bool IsTwoStroke { get; }

        public Scooter(string make, string model, int year, bool isTwoStroke)
                        : base(make, model, year)
        {
            IsTwoStroke = isTwoStroke;
        }
    }
}
