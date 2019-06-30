using PlanetDDS.Models;

namespace PlanetDDS.Interfaces
{
    public interface IPatientsService
    {
        Patient GetById(int id);
    }
}
