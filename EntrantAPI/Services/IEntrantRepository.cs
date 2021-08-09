using EntrantAPI.Entities;
using System.Collections.Generic;

namespace EntrantAPI.Services
{
    public interface IEntrantRepository
    {
        List<Entrant> GetAllEntrants();
        Entrant GetEntrantById(int Id);
        void AddEntrant(Entrant entrant);
        void DeleteEntrantById(int Id);
        void UpdateEntrant(int id,Entrant entrant);
    }
}