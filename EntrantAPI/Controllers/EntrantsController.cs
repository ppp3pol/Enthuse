using EntrantAPI.Entities;
using EntrantAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntrantAPI.Controllers
{
    [Route("api/entrants")]
    [ApiController]
    public class EntrantsController : ControllerBase
    {
        private readonly IEntrantRepository repository;

        public EntrantsController(IEntrantRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public ActionResult<List<Entrant>> Get()
        {
            try
            {
                var entrants = repository.GetAllEntrants();
                return Ok(entrants);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the Repository");
            }
        }

        [HttpGet("{id:int}", Name = "getEntrant")]
        public ActionResult<Entrant> Get(int id)
        {
            try
            {
                var entrant = repository.GetEntrantById(id);

                if (entrant == null)
                {
                    return NotFound(string.Format("No Entrant found with Id = {0}", id));
                }
                return Ok(entrant);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the Repository");
            }
          
        }

        [HttpPost]
        public ActionResult Post([FromBody] Entrant entrant)
        {
            try
            {
                repository.AddEntrant(entrant);
                return new CreatedAtRouteResult("getEntrant", new { Id = entrant.Id }, entrant);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
            }
           
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int Id)
        {
            try
            {
                var entrant = repository.GetEntrantById(Id);

                if (entrant == null)
                {
                    return NotFound(string.Format("No Entrant found with Id = {0}", Id));
                }
                repository.DeleteEntrantById(Id);
                return Ok(string.Format("Entrant Details has been  deleted  with Id = {0}", Id));

            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
            }
           

        }

    }
}
