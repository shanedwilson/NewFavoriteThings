using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteThings.Comedians
{
    abstract class Comedian
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string BestWork { get; }

        public Comedian(string firstname, string lastname, string bestwork)
        {
            FirstName = firstname;
            LastName = lastname;
            BestWork = bestwork;
        }

    }
}