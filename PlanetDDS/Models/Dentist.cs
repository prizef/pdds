namespace PlanetDDS.Models
{
    public class Dentist
    {
        public int DentistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public bool AcceptingNewPatients { get; set; }
    }
}
