using Application.Interface;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LauncheController : ControllerBase
    {
        private readonly ILaunchesRepository _launchesRepository;
        public LauncheController(ILaunchesRepository launchesRepository)
        {
            _launchesRepository = launchesRepository;
        }
        [HttpGet]
        public ActionResult<List<Launche>> GetAll()
        {
            return _launchesRepository.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<Launche> GetById(int id)
        {
            return _launchesRepository.GetById(id);
        }
    }
}
