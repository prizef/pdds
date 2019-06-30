using PlanetDDS.Interfaces;
using PlanetDDS.Models;
using System.Collections.Generic;

namespace PlanetDDS.Services
{
    public class DentistsService : IDentistsService
    {
        private IDataProvider dataProvider;
        public DentistsService(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        public List<Dentist> GetAll()
        {
            List<Dentist> results = new List<Dentist>();
            dataProvider.ExecuteProcedure(
                "dentists_getAll",
                rowMapper: (parameters) =>
                {
                    Dentist dentist = new Dentist();
                    dentist.DentistId = (int)parameters["dentistId"];
                    dentist.FirstName = (string)parameters["firstName"];
                    dentist.LastName = (string)parameters["lastName"];
                    dentist.City = (string)parameters["city"];
                    dentist.AcceptingNewPatients = (bool)parameters["acceptingNewPatients"];
                    results.Add(dentist);
                });
            return results;
        }
    }
}
