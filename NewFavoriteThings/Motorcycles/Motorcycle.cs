using System;

namespace NewFavoriteThings.Motorcycles
{
    abstract class Motorcycle
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public Motorcycle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}