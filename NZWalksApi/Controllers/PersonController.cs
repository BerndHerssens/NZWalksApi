using Microsoft.AspNetCore.Mvc;

namespace NZWalksApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
       public string GetName()
        {
            return "Bernd";
        }
    }
}
