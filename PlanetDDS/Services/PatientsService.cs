using PlanetDDS.Interfaces;
using PlanetDDS.Models;

namespace PlanetDDS.Services
{
    public class PatientsService : IPatientsService
    {
        private IDataProvider dataProvider;
        public PatientsService(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        public Patient GetById(int id)
        {
            Patient result = new Patient();
            dataProvider.ExecuteProcedure(
                "patient_getById",
                inputParamMapper: (parameters) =>
                {
                    parameters.AddWithValue("@patientId", id);
                },
                rowMapper: (reader) =>
                {
                    result.FirstName = (string)reader["firstName"];
                    result.LastName = (string)reader["lastName"];
                    result.Email = (string)reader["email"];
                    result.FirstTimePatient = (bool)reader["firstTimePatient"];
                });
            return result;
        }
    }
}
