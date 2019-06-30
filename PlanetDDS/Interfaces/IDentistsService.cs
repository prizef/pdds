using PlanetDDS.Models;
using System.Collections.Generic;

namespace PlanetDDS.Interfaces
{
    public interface IDentistsService
    {
        List<Dentist> GetAll();
    }
}
