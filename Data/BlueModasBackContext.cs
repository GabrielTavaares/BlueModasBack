using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlueModasBack.Models;

namespace BlueModasBack.Data
{
    public class BlueModasBackContext : DbContext
    {
        public BlueModasBackContext (DbContextOptions<BlueModasBackContext> options)
            : base(options)
        {
        }

        public DbSet<BlueModasBack.Models.Produtos> Produtos { get; set; }
    }
}
