using API.Modals;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet("GetMovieById")]
        public IActionResult GetMovieById(int MovieId)
        {
            Movies movie1 = new Movies { MovieName ="Interstaller", MovieId=1,watchingNo=50, KategoriName="Sci-Fi", kategoriId=001};
            Movies movie2 = new Movies { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            List<Movies> movieList  = new List<Movies>();
            movieList.Add(movie1);
            movieList.Add(movie2);
            var model1=movieList.Where(x=> x.MovieId==MovieId).ToList();
            return  Ok(model1) ;
        }
        [HttpGet("GetAllMovie")]
        public IActionResult GetAllMovie(int movieId)
        {
            Movies movie1 = new Movies { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, KategoriName = "Sci-Fi", kategoriId = 001 };
            Movies movie2 = new Movies { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            List<Movies> movieList = new List<Movies>();
            movieList.Add(movie1);
            movieList.Add(movie2);
            return Ok(movieList);

        }
        [HttpGet("GetWatchingNo")]
        public IActionResult GetWatchingNo(int watchingNo) 
        {
            Movies movie1 = new Movies { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, KategoriName = "Sci-Fi", kategoriId = 001 };
            Movies movie2 = new Movies { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            List<Movies> movieList = new List<Movies>();
            movieList.Add(movie1);
            movieList.Add(movie2);
            var model2= movieList.Where(x=> x.watchingNo == watchingNo).OrderByDescending(x=> x.watchingNo).ToList();
            return Ok(model2);
        }
        [HttpGet("GetCategoryId")]
        public IActionResult GetCategoryId(int kategoryId)
        {

            Movies movie1 = new Movies { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, KategoriName = "Sci-Fi", kategoriId = 001 };
            Movies movie2 = new Movies { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            List<Movies> movieList = new List<Movies>();
            movieList.Add(movie1);
            movieList.Add(movie2);
            var model3 = movieList.Where(x=> x.kategoriId==kategoryId).ToList();

            return Ok(model3);


        }
        [HttpGet("GetMovieName")]
        public IActionResult GetMovieName(string MovieName)
        {

            Movies movie1 = new Movies { MovieName = "Interstaller", MovieId = 1, watchingNo = 50, KategoriName = "Sci-Fi", kategoriId = 001 };
            Movies movie2 = new Movies { MovieName = "Seven", MovieId = 2, watchingNo = 30, KategoriName = "Thriller", kategoriId = 002 };
            List<Movies> movieList = new List<Movies>();
            movieList.Add(movie1);
            movieList.Add(movie2);
            var model4 = movieList.Where(x=> x.MovieName==MovieName).ToList();
            return Ok(model4);

        }

    }
}
