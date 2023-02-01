using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaDelta.Core.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public Genre() { }

        public Genre(int id, int name)
        {
            Id = id;    
            Name = name;
        }
    }
}
