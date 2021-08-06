using EntrantAPI.Entities;
using System.Collections.Generic;

namespace EntrantAPI.Services
{
    public interface IEntrantRepository
    {
        void AddEntrant(Entrant entrant);
        List<Entrant> GetAllEntrants();
        Entrant GetEntrantById(int Id);
        void DeleteEntrantById(int Id);
    }
}