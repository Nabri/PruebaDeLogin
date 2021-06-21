using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDeLogin.Context
{
    public class PruebaDeLoginDbContext : IdentityDbContext
    {
        public PruebaDeLoginDbContext()
        {
        }

        public PruebaDeLoginDbContext(DbContextOptions<PruebaDeLoginDbContext> options)
            : base(options)
        {
        }
    }
}
