using API.Modals;

namespace API.Abstraction
{
    public interface IMoviesRepo
    {
        Movies GetMovieById(int MovieId);
        List<Movies> GetAllMovies();
        List<Movies> GetWatchingNo(int watchingNo);
        List<Movies> GetCategoryId(int kategoriId);
        List<Movies> GetMovieName(string MovieName);

        

    }
}
