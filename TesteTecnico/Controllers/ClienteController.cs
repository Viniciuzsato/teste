using Microsoft.AspNetCore.Mvc;
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
    }
}
