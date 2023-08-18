using Microsoft.AspNetCore.Mvc;
using TherapEasy.WebApi.Data;

namespace TherapEasy.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SessionController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            //TODO
            var session = _context.Sessions.Where(d => d.IsActive).ToList();
            return Ok(session);
            //Logica para obter sessoes de um usuario, usando serviço de sessoes
            //Retorna as sessoes como resultado
        }
    }
}
