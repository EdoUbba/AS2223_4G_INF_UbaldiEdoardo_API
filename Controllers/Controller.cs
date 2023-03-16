using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_UbaldiEdoardo_API.Controllers
{

    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/")]
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet("GetPariDispari")]
        public JsonResult GetPariDispari(int n1)
        {
            if (n1 % 2 == 0) {
                return Json(new { output = "Pari", status = "OK" });
            }
            return Json(new { output = "Dispari", status = "OK" });
        }

        [HttpGet("GetFattoriale")]
        public JsonResult GetFattoriale(int n1)
        {
            int output = 1;
            for (int i = 1; i <= n1; i++) {
                output = output * i;
            }
            return Json(new { output = output, status = "OK" });
        }

        [HttpGet("GetParabola")]
        public JsonResult GetParabola(int n1, int n2, int n3)
        {
            int delta;      //ax^2 + bx + c = 0
            

        }

        [HttpGet("GetTasse")]
        public JsonResult GetTasse(int n1)
        {
            if(n1 > 35000)
            {
                n1 = (n1 * 28) / 100;
                return Json(new { output = n1, status = "OK" });
            }
            else
            {
                n1 = (n1 * 12) / 100;
                return Json(new { output = n1, status = "OK" });
            }
        }

    }
}
