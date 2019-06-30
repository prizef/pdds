using Microsoft.AspNetCore.Mvc;
using PlanetDDS.Interfaces;
using PlanetDDS.Models;

namespace PlanetDDS.Controllers
{
    [ApiController]
    public class PatientsController : ControllerBase
    {
        readonly IPatientsService patientsService;

        public PatientsController(IPatientsService patientsService)
        {
            this.patientsService = patientsService;
        }

        [Route("api/patient/{id?}"), HttpGet]
        public ActionResult<Patient> GetById(int id)
        {
            Patient patient = patientsService.GetById(id);
            return patient;
        }
    }
}