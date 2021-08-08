using AutoMapper;
using EntrantAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntrantAPI.Services
{
    public class EntrantRepository :  IEntrantRepository
    {
        private List<Entrant> _entrants;
        
        public EntrantRepository(IMapper mapper)
        {
            
            _entrants = new List<Entrant>()
            {
                new Entrant(){Id = 1, FirstName = "Aiden", LastName="Butler"},
                new Entrant(){Id = 2,FirstName = "Alice", LastName = "Patterson"},
                new Entrant(){Id = 3, FirstName = "Alan", LastName = "Paul" },
                new Entrant(){Id = 4, FirstName = "Alwin", LastName = "Paul" },
                new Entrant(){Id = 5, FirstName = "Connor", LastName = "Byrne" },
                new Entrant(){Id = 6, FirstName = "Donna", LastName = "Murphy" },
                new Entrant(){Id = 7, FirstName = "Carolina", LastName = "Tucker" },
                new Entrant(){Id = 8, FirstName = "John", LastName = "Thomas" },
                new Entrant(){Id = 9, FirstName = "Martin", LastName = "Treacy" },
                new Entrant() {Id = 10, FirstName = "Jim", LastName = "Brown" },
            };
        }
        public List<Entrant> GetAllEntrants()
        {
            return _entrants;
        }

        public Entrant GetEntrantById(int Id)
        {
            return _entrants.FirstOrDefault(x => x.Id == Id);
        }

        public void AddEntrant(Entrant entrant)
        {
            entrant.Id = _entrants.Max(x => x.Id) + 1;
            _entrants.Add(entrant);
        }

        public void DeleteEntrantById(int Id)
        {
            var itemtoRemove =  _entrants.FirstOrDefault(x => x.Id == Id);
            _entrants.Remove(itemtoRemove);
             
        }
    }
}
