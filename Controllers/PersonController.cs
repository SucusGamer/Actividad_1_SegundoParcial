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
        [Route("Problema 1")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Problema 2")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Problema 3")]
        public IActionResult GetByGender(char genero)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(genero);
            return Ok(persons);
        }
        [HttpGet]
        [Route("Problema 4")]
        public IActionResult GetRangeAge(int EdadMin, int EdadMax)
        {
            var repository = new PersonRepository();
            var persons = repository.GetRangeAge(EdadMin, EdadMax);
            return Ok(persons);
        }
        [HttpGet]
        [Route("Problema 5")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Problema 6")]
        public IActionResult GetContent(string Nombre)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContent(Nombre);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Problema 7")]
        public IActionResult GetAges(int Edad1, int Edad2, int Edad3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetAges(Edad1, Edad2, Edad3);
            return Ok(persons);
        }
        [HttpGet]
        [Route("Problema 8")]
        public IActionResult GetPersonOrdered(int edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonOrdered(edad);
            return Ok(persons);
        }
        [HttpGet]
        [Route("Problema 9")]
        public IActionResult GetAgeandGender(int EdadMin, int EdadMax, char genero)
        {
            var repository = new PersonRepository();
            var persons = repository.GetAgeandGender(EdadMin, EdadMax,genero);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Problema 10")]
        public IActionResult CountGender(char genero)
        {
            var repository = new PersonRepository();
            var persons = repository.CountGender(genero);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Problema 11")]
        public IActionResult PersonExistLastName(string Apellido)
        {
            var repository = new PersonRepository();
            var persons = repository.PersonExistLastName(Apellido);
            return Ok(persons);
        }
        [HttpGet]
        [Route("Problema 12")]
        public IActionResult GetJobWithPersonAndAge(string trabajo, int edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobWithPersonAndAge(trabajo, edad);
            return Ok(persons);
        }
        [HttpGet]
        [Route("Problema 13")]
        public IActionResult TakePerson(string trabajo, int tomar)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(trabajo, tomar);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Problema 14")]
        public IActionResult TakeLastPerson(string trabajo, int tomarUltimo)
        {
            var repository = new PersonRepository();
            var persons = repository.TakeLastPerson(trabajo, tomarUltimo);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Problema 15")]
        public IActionResult SkipAndTakePerson(string trabajo, int saltar, int tomar)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipAndTakePerson(trabajo, saltar, tomar);
            return Ok(persons);
        }                
    }
}