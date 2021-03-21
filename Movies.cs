using System;
using System.Collections.Generic;

namespace CRUD_Operations.Models
{
    public partial class Movies
    {
        public Movies()
        {
            Movies = new HashSet<Movies>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string YearOfCreation { get; set; }
        public string Genre { get; set; }
        public string Producer { get; set; }
        public int Cast { get; set; }
        public DateTimeOffset Created { get; set; }

        public virtual ICollection<Movies> Movies { get; set; }
    }
} 