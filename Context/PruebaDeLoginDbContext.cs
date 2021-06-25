using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruebaDeLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDeLogin.Context
{
    public class PruebaDeLoginDbContext : IdentityDbContext
    {

        public DbSet<ApplicationUser> ApplicationUsers { get; set; } //De esta manera tienen que poner todas las clases que quieran que tengan una tabla

        public PruebaDeLoginDbContext()
        {
        }

        public PruebaDeLoginDbContext(DbContextOptions<PruebaDeLoginDbContext> options)
            : base(options)
        {
        }
    }
}
