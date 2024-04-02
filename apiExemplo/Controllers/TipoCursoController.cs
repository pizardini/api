using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TipoCursoController : ControllerBase
{
    [HttpGet]
        public ActionResult<IEnumerable<TipoCurso>> Get() {
        return Ok(new List<TipoCurso>());
    }

    [HttpPost]
        public ActionResult Post(TipoCurso curso) {
            return Ok("Sucesso.");
        }
}