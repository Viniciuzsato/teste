using Microsoft.AspNetCore.Mvc;
using TesteTecnico.Service.Interface;

namespace TesteTecnico.Controllers
{
    public class ProdutoController: Controller
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
