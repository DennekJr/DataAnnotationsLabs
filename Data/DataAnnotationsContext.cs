#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAnnotations.Models;

namespace DataAnnotations.Data
{
    public class DataAnnotationsContext : DbContext
    {
        public DataAnnotationsContext (DbContextOptions<DataAnnotationsContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Room> Rooom { get; set; }
        public DbSet<Client> Client { get; set; }

    }
}
