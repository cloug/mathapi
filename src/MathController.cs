using Microsoft.AspNet.Mvc;

namespace MathAPI
{
    [Route("api/[controller]")]
    public class MathController : Controller
    {
        [HttpGet("Ajouter")]
        public int GetAddition(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
