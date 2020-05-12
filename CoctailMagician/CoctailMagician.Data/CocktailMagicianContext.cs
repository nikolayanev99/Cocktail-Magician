using System;
using Microsoft.EntityFrameworkCore;

namespace CoctailMagician.Data
{
    public class CocktailMagicianContext : DbContext
    {

        public CocktailMagicianContext(DbContextOptions<CocktailMagicianContext> options)
              : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
