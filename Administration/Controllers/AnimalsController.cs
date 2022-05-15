using Administration.Models;
using Administration.Services;
using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    [ApiController]
    [Route("/")]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalService _service;

        public AnimalsController(AnimalService service)
        {
            _service = service;
        }
        [HttpGet("/cat")]
        public ActionResult<Cat> CatVoice()
        {
            Cat cat = new Cat("Simon");
            return Ok(_service.Voice(cat));
        }
        [HttpGet("/dog")]
        public ActionResult<Dog> DogVoice()
        {
            Dog dog = new Dog("Jack");
            
            return Ok(_service.Voice(dog));
        }
    }    
}


