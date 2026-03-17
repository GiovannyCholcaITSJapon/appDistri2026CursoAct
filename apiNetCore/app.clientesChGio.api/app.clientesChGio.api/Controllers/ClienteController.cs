using Microsoft.AspNetCore.Mvc;

namespace app.clientesChGio.api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {

        public ClienteController() {
        
        }


        [HttpGet]
        public IActionResult GetHolaMundo()
        {
            return Ok("Hola Mundo -- ClienteController");
        }

    }
}
