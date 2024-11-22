using Dominio._01_Core.Entidades;
using Dominio._01_Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaminhaoController : ControllerBase
    {
        private readonly ICaminhaoService _service;
        public CaminhaoController(IConfiguration config, ICaminhaoService CaminhaoService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = CaminhaoService;
        }
        [HttpPost("adicionar-Caminhao")]
        public void AdicionarCaminhao(Caminhao Caminhao)
        {
            _service.Adicionar(Caminhao);
        }
        [HttpGet("listar-Caminhao")]
        public List<Caminhao> ListarCaminhao()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Caminhao")]
        public void EditarCaminhao(Caminhao p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-Caminhao")]
        public void DeletarCaminhao(int id)
        {
            _service.Remover(id);
        }
    }
}
