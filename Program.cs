using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quete_EntityFrameworkLINQ
{
    class Program
    {
        static void Main()
        {
            using (var context = new AnimalContext())
            {

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var species1 = new Species
                {
                    Name = "Cougars"
                };

                species1.Animal = new List<Animal>
                {
                    new Animal { Name = "Cougar Blancs", Number = 3},
                 };

                context.Add(species1);


                var species2 = new Species
                {
                    Name = "Tigres"
                };

                species2.Animal = new List<Animal>
                {
                    new Animal { Name = "Tigres Blancs", Number = 100},
                };

                context.Add(species2);


                var species3 = new Species
                {
                    Name = "Tortue"
                };

                species3.Animal = new List<Animal>
                {
                    new Animal { Name = "Tortue Albinos", Number = 15},
                };

                context.Add(species3);

                context.SaveChanges();

                foreach (Species species in context.Species.Include(s => s.Animal))
                {
                    Console.WriteLine(species.Name + " :");
                    foreach (Animal animal in species.Animal)
                    {
                        Console.WriteLine("\t Il reste " + animal.Number + " " + animal.Name);
                    }
                }
            }
        }
    }
}
