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
            var Session = _context.Sessions.Where(d => d.IsActive).ToList();
            return Ok(Session);
            //Logica para obter sessoes de um usuario, usando serviço de sessoes
            //Retorna as sessoes como resultado
        }
        [HttpPost]
        public async Task<IActionResult> CreateSessionAsync([FromBody] CreateSessionRequest request)
        {
            //lógica para criar uma nova sessão usando o serviço de sessão.
            // Retorna os detalhes da sessão recém-criada.
        }

        // Outros endpoints para atualização, exclusão, etc.

    }
}
