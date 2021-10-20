using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("InfAllPerson")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Name-Email-Birth:Person")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        }

        [HttpGet]
        [Route("GenderFemale")]
        public IActionResult GetByGender(char genero)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(genero);
            return Ok(persons);
        }
        [HttpGet]
        [Route("RangeAge")]
        public IActionResult GetRangeAge(int EdadMin, int EdadMax)
        {
            var repository = new PersonRepository();
            var persons = repository.GetRangeAge(EdadMin, EdadMax);
            return Ok(persons);
        }
        [HttpGet]
        [Route("MatchJob")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("GetContent")]
        public IActionResult GetContent(string Nombre)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContent(Nombre);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetAges")]
        public IActionResult GetAges(int Edad1, int Edad2, int Edad3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetAges(Edad1, Edad2, Edad3);
            return Ok(persons);
        }
        [HttpGet]
        [Route("GetPersonOrdered")]
        public IActionResult GetPersonOrdered(int edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonOrdered(edad);
            return Ok(persons);
        }
        [HttpGet]
        [Route("GetAgeAndGender")]
        public IActionResult GetAgeandGender(int EdadMin, int EdadMax, char genero)
        {
            var repository = new PersonRepository();
            var persons = repository.GetAgeandGender(EdadMin, EdadMax,genero);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("GenderCount")]
        public IActionResult CountGender(char genero)
        {
            var repository = new PersonRepository();
            var persons = repository.CountGender(genero);
            return Ok(persons);
        }

        [HttpGet]
        [Route("LastNamePersonExist")]
        public IActionResult PersonExistLastName(string Apellido)
        {
            var repository = new PersonRepository();
            var persons = repository.PersonExistLastName(Apellido);
            return Ok(persons);
        }
        [HttpGet]
        [Route("GetJobWithPersonAndAge")]
        public IActionResult GetJobWithPersonAndAge(string trabajo, int edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobWithPersonAndAge(trabajo, edad);
            return Ok(persons);
        }
        [HttpGet]
        [Route("TakePerson")]
        public IActionResult TakePerson(string trabajo, int tomar)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(trabajo, tomar);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("TakeLastPerson")]
        public IActionResult TakeLastPerson(string trabajo, int tomarUltimo)
        {
            var repository = new PersonRepository();
            var persons = repository.TakeLastPerson(trabajo, tomarUltimo);
            return Ok(persons);
        }

        [HttpGet]
        [Route("SkipAndTakePerson")]
        public IActionResult SkipAndTakePerson(string trabajo, int saltar, int tomar)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipAndTakePerson(trabajo, saltar, tomar);
            return Ok(persons);
        }                
    }
}