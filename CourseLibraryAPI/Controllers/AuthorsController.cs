using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibraryAPI.Controllers
{
    [ApiController]
    [Route("api/authors")]
    //[Route("api/[controller]")] - not recommending by author but if it is suite for our case we can use it
    public class AuthorsController: ControllerBase
    {
        private readonly ICourseLibraryRepository courseLibraryRepository;

        public AuthorsController(ICourseLibraryRepository courseLibraryRepository)
        {
            this.courseLibraryRepository = courseLibraryRepository ?? 
                                           throw new ArgumentNullException(nameof(courseLibraryRepository));
        }

        //[Route("api/authors")]
        //[HttpGet("api/authors")]
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = courseLibraryRepository.GetAuthors();
            return new JsonResult(authors);
        }

        [HttpGet("{authorId}")]
        //[HttpGet("{authorId}:guid")] - this is for guid resource tyupe of author id
        public IActionResult GetAuthor(Guid authorId)
        {
            var author = courseLibraryRepository.GetAuthor(authorId);
            return new JsonResult(author);
        }
    }
}
