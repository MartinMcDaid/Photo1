using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Photo1.Models
{
    public class Photo1Context : DbContext
    {
        public Photo1Context (DbContextOptions<Photo1Context> options)
            : base(options)
        {
        }

        public DbSet<Photo1.Models.Photo> Photo { get; set; }
    }
}
