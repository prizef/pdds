using Microsoft.AspNetCore.Mvc;
using PlanetDDS.Interfaces;
using PlanetDDS.Models;
using System.Collections.Generic;

namespace PlanetDDS.Controllers
{
    [ApiController]
    public class DentistsController : ControllerBase
    {
        readonly IDentistsService dentistsService;

        public DentistsController(IDentistsService dentistsService)
        {
            this.dentistsService = dentistsService;
        }

        [Route("api/dentists"), HttpGet]
        public ActionResult<List<Dentist>> GetAll()
        {
            List<Dentist> dentists = dentistsService.GetAll();
            return dentists;
        }
    }
}