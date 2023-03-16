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
            string tipoPar = "";
            double delta = -n2 + Math.Sqrt(n2^2-4*n1*n2)/2*n1;
            //ax^2 + bx + c = 0
            if (n1 > 0)
            {
                tipoPar = "Convessa";
            }
            if (n1 < 0)
            {
                tipoPar = "Concava";
            }
            return Json(new { output = delta, output2 = tipoPar, status = "OK" });
        }

        [HttpGet("GetTasse")]
        public JsonResult GetTasse(double n1)
        {
            if(n1 <= 35000)
            {
                n1 = n1 * 12 / 100;
                return Json(new { output = n1, status = "OK" });
            }
            else
            {
                n1 = n1 * 28 / 100;
                return Json(new { output = n1, status = "OK" });
            }
        }

    }
}
