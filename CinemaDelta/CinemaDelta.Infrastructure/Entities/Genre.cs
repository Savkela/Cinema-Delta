using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaDelta.Infrastructure.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Movie
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie? Movie { get; set; }

        //Constructors
        public Genre(int id, string name)
        {
            Id = id;    
            Name = name;
        }
    }
}
