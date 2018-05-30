using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Moviely2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // /movie/ramdon (to go to the route .../movie/random we need to create an controller called movie and an action or fuction called random() )
}