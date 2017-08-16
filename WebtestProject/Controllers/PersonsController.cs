using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebtestProject.Controllers
{
     [RoutePrefix("v1/persons")]
    public class PersonsController : ApiController
    {


        private string Name { get; set; }
        private static IList<Person> _persons = new List<Person>();


        [Route("{id}/name")]
        [HttpGet]
        public string GetNamer(int id)
        {
            Name = "tiago";
            return Name;

        }

        [Route("{id}/old")]
        [HttpGet]
        public int Getold(int id)
        {
           
            return id;

        }
        [Route("{id}/surname")]
        [HttpGet]
        public string Getsurname(int id)
        {
            return "costa";
        }

        [Route("{id}")]
        [HttpGet]
        public object Getpersons(int id)
        {
            return _persons[id];
        }

        [Route]
        [HttpGet]
        public IList<Person> Getpersons()
        {

            return _persons;

        }

        [Route]
        [HttpPost]
        public Person PostPersons(Person person)
        {
            _persons.Add(person);
            person.id = _persons.Count;
            return person;
        }



































    }


}
