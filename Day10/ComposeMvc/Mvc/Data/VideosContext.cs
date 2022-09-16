using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mvc.Models;

    public class VideosContext : DbContext
    {
        public VideosContext (DbContextOptions<VideosContext> options)
            : base(options)
        {
        }

        public DbSet<Mvc.Models.Videostats> Videostats { get; set; } = default!;
    }
