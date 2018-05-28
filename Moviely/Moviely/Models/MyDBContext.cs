using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace Moviely.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() { }
    }
}