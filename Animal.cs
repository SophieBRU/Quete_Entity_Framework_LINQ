using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quete_EntityFrameworkLINQ
{
    class Animal
    {
        public Guid AnimalId { get; set; }
        public String Name { get; set; }
        public Int32 Number { get; set; }
    }
}