using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        List<movies> moviesList = new List<movies>()
        {
            new movies(){movie_id=1,movie_name="Godfather",language="English",genre="Thrill and Crime" },
            new movies(){movie_id=2,movie_name="Beautiful Mind",language="Spanish", genre="Biography"},
            new movies(){movie_id=3,movie_name="The Pursuit of Happyness",language="English", genre="Drama" },
            new movies(){movie_id=4,movie_name="The Theory of Everything",language="French" ,genre="Romance and Drama"},
            new movies(){movie_id=5,movie_name="Godfather",language="English" ,genre="Crime"},
            new movies(){movie_id=6,movie_name="Beautiful Mind",language="Spanish" ,genre="Drama"}
        };

        // GET: api/Movie
        [HttpGet]
        public IEnumerable<movies> GetMovies()
        {
            return moviesList;
        }

        // GET: api/Movie/2
        [HttpGet("{movie_id}")]
        [Route("api/Movie/{movie_id}")]
        public movies GetMovie(int movie_id)
        {
            return moviesList.Find(a => a.movie_id == movie_id);
        }
    }
}
