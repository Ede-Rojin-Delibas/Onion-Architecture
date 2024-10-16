    using API.Modals;

namespace API.Repository
{
    public class MovieRepository
    {
        public Movies GetMovieById(int MovieId)
        {
            List<Movies> movieList= new List<Movies>();
            Movies movie1 = new Movies() { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, KategoriName = "Sci-Fi", kategoriId = 001 };
            Movies movie2 = new Movies() { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            movieList.Add(movie1);
            movieList.Add(movie2);
            var model = movieList.Where(x=> x.MovieId == MovieId).FirstOrDefault();
            return model;

        }
        public List<Movies> GetAllMovies()
        { 
            List<Movies> movieList = new List<Movies>();
            Movies movie1 = new Movies() { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, KategoriName = "Sci-Fi", kategoriId = 001 };
            Movies movie2 = new Movies() { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            movieList.Add(movie1);
            movieList.Add(movie2);
            return movieList;

        }
        public List<Movies> GetWatchingNo(int watchingNo)
        {
            List<Movies> movieList = new List<Movies>();
            Movies movie1 = new Movies() { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, KategoriName = "Sci-Fi", kategoriId = 001 };
            Movies movie2 = new Movies() { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            movieList.Add(movie1);
            movieList.Add(movie2);
            var model1 = movieList.Where(x => x.watchingNo == watchingNo).OrderByDescending(x=> x.watchingNo).ToList();
            return model1;
        }
        public List<Movies> GetCategoryId(int kategoriId)
        {
            List<Movies> movieList = new List<Movies>();
            Movies movie1 = new Movies() { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, kategoriId = 001 };
            Movies movie2 = new Movies() { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            movieList.Add(movie1);
            movieList.Add(movie2);
            return movieList;
        }
        public List<Movies> GetMovieName(string MovieName)
        {
            List<Movies> movieList = new List<Movies>();
            Movies movie1 = new Movies() { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, kategoriId = 001 };
            Movies movie2 = new Movies() { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            movieList.Add(movie1);
            movieList.Add(movie2);
            return movieList;

        }

    }
}
