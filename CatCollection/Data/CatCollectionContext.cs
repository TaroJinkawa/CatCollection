using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatCollection.Models;

namespace CatCollection.Data
{
    public class CatCollectionContext : DbContext
    {
        public CatCollectionContext (DbContextOptions<CatCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<CatCollection.Models.Cat> Cat { get; set; } = default!;
    }
}
