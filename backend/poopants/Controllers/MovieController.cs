using Microsoft.AspNetCore.Mvc;
using poopants.Data;

namespace poopants.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private movieDBContext context;
        public MovieController(movieDBContext temp)
        {
            context = temp;
        }

        public IEnumerable<Movies> Get ()
        {
            //making sure that movies are only the edited and it is ordered alphabetically
            var x = context.Movies.ToArray().Where(m => m.edited=="Yes").OrderBy(m => m.title);

            return x;

        }

    }
}
