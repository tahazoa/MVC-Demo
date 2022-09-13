using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Demo.Models
{
    public class MyContext:DbContext
    {
        public MyContext( DbContextOptions Options) :base(Options)
        {

        }

        public DbSet<Demo> DemoFirst { get; set; }
    }
}
