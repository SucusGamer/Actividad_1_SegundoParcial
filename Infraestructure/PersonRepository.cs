using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // retornar todos los valores

        public IEnumerable<Person> GetAll()
        {
            return _persons;
        }

        // retornar campos especificos

        public IEnumerable<Object> GetField()
        {
            var query = _persons.Select(person => new {

                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age * -1).Year,
                CorreoElcetronico = person.Email 
            });
            
            return query;
        }


        public IEnumerable<Person> GetByGender (char genero)
        {
            var query = _persons.Where(person => person.Gender == genero);
            return query;
        }

        // retornar valores entre un rango
        
        public IEnumerable<Person> GetRangeAge (int EdadMin, int EdadMax)
        {
            var query = _persons.Where(person => person.Age > EdadMin && person.Age < EdadMax);
            return query;
        }
        
        public IEnumerable<string> GetJobs()
        {
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        } 

        // retornar valores que contengan
        
        public IEnumerable<Person> GetContent(string Nombre)
        {
            var query = _persons.Where(person => person.FirstName.Contains(Nombre));
            return query;
        }

        public IEnumerable<Person> GetAges (int Edad1, int Edad2, int Edad3)
        {
            var edades = new List<int>{Edad1,Edad2,Edad3};
            var query = _persons.Where(person => edades.Contains(person.Age));
            return query;
        }

        // retornar elementos ordenados
        
        public IEnumerable<Person> GetPersonOrdered (int edad)
        {
            var query = _persons.Where(person => person.Age > edad).OrderBy(person => person.Age);
            return query;
        }

        public IEnumerable<Person> GetAgeandGender (int EdadMin, int EdadMax, char genero)
        {
            var query = _persons.Where(person => person.Age > EdadMin && person.Age < EdadMax &&  person.Gender ==  genero).OrderByDescending(person =>  person.Gender);
            return query;
        }

        
        public IEnumerable<Person> CountGender (char genero)
        {
            var query = _persons.Where(person => person.Gender == genero);
            return query;
        }

        // Evalua si un elemento existe

        public bool PersonExistLastName (string Apellido)
        {
            var query = _persons.Any(p => p.LastName == Apellido);

            return query;
        }

        public IEnumerable<Person> GetJobWithPersonAndAge (string trabajo, int edad)
        {
            var query = _persons.Where(person => person.Job == trabajo && person.Age == edad);
            return query;
        }

        // retornar solamente unos elementos
        
        public IEnumerable<Person> TakePerson (string trabajo, int tomar)
        {
            var query = _persons.Where(person => person.Job == trabajo).Take(tomar);
            return query;
        }

        public IEnumerable<Person> TakeLastPerson(string trabajo, int tomarUltimo)
        {

            var query = _persons.Where(person => person.Job == trabajo).TakeLast(tomarUltimo);
            return query;
        }


        public IEnumerable<Person> SkipAndTakePerson(string trabajo, int saltar, int tomar)
        {
            var query = _persons.Where(person => person.Job == trabajo).Skip(saltar).Take(tomar);
            return query;
        }
    }
}