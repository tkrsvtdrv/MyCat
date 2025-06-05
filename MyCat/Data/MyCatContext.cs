using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatPetWebsite.Models;

namespace MyCat.Data
{
    public class MyCatContext : DbContext
    {
        public MyCatContext (DbContextOptions<MyCatContext> options)
            : base(options)
        {
        }

        public DbSet<CatPetWebsite.Models.Cat> Cat { get; set; } = default!;
    }
}
