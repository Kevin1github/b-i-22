using Microsoft.AspNetCore.Mvc;

namespace vidu2.Controllers
{
    [ApiController]
    [Route("api/Circle")]
    public class CircleController : ControllerBase
    {
        [HttpGet("cv_dt")]
        public IActionResult GetCircleInfo(double rr)
        {
            if (rr <= 0)
            {
                return BadRequest("Bán kính phải lớn hơn 0");
            }

            var result = new
            {
                dien_tich = Math.PI * rr * rr,
                chu_vi = 2 * Math.PI * rr,
                duong_kinh = 2 * rr
            };

            return Ok(result);
        }
    }
}
