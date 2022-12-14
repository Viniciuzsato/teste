using Microsoft.AspNetCore.Mvc;
using TesteTecnico.Entity;
using TesteTecnico.Models;
using TesteTecnico.Service.Interface;

namespace TesteTecnico.Controllers
{
    public class ClienteController: Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo()
        //public ActionResult Post(ClienteModel model)
        {
            try
            {
                var model = new ClienteModel
                {
                    Codigo = 10,
                    Nome = "joao da silva",
                    Fantasia = "aaa",
                    Endereco = "rua teste",
                    Documento = "1548"
                };

                _clienteService.Adicionar(new Cliente(model));
                return Json(new { Message = "Adicionado com sucesso" });
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        void Alterar(ClienteModel model)
        {

        }

        List<Cliente> Lista()
        {
            return null;
        }

        Cliente Visualizar (int clienteId)
        {
            return null;
        }
        void Deletar (int clienteId)
        {

        }
    }
}
