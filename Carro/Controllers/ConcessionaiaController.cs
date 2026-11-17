using Carro.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConcessionaiaController : ControllerBase
    {

        private readonly IConcessionariaReposity _concessionariaRepository;

        public ConcessionaiaController(IConcessionariaReposity concessionariaRepository)
        {
            _concessionariaRepository = concessionariaRepository;
        }


        //get
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_concessionariaRepository.ListarTodos());
        }
    }
}