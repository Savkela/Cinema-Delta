namespace CinemaDelta.Infrastructure.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public string Lenth { get; set; }

        public string State { get; set; }

        public string Director { get; set; }

        public string Distributor { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public List<Genre>? Genres { get; set; }

        public List<Actor>? Actors { get; set; }


        //Constructors
        public Movie(int id, string name, DateTime startDate, string lenth, string state, string director, string distributor, string description, string photoUrl, List<Genre> genres, List<Actor> actors)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            Lenth = lenth;
            State = state;
            Director = director;
            Distributor = distributor;
            Description = description;
            PhotoUrl = photoUrl;
            Genres = genres;
            Actors = actors;
        }
    }
}
