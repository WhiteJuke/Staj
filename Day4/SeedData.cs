using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mvc.Models;
using MvcMovie.Controllers;
using Mvc.Migrations;
using System;
using System.Linq;

namespace Videos.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideosContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VideosContext>>()))
            {
                // Look for any movies.
                if (context.Videostats.Any())
                {
                    return;   // DB has been seeded
                }

                context.Videostats.AddRange(
                    new Videostats
                    {
                        Title = "When Harry Met Sally",
                        Link = "Romantic Comedy",
                    },

                    new Videostats
                    {
                        Title = "Ghostbusters ",
                        Link = "Comedy",
                    },

                    new Videostats
                    {
                        Title = "Ghostbusters 2",
                        Link = "Comedy",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}