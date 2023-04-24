namespace Restaurante.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MesaControllers : ControllerBase
    {
        [HttpGet]
        [Route("/")]

        public string Get(){
            return "Olá mundo";
        }
    }
}