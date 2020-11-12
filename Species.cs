using System;
using System.Collections.Generic;
using System.Text;

namespace Quete_EntityFrameworkLINQ
{
    class Species
    {
        public Guid SpeciesId { get; set; }
        public String Name { get; set; }
        public ICollection<Animal> Animal { get; set; }
    }
}
