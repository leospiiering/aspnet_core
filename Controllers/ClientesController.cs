using aspnet_core___Copia.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core___Copia.Controllers
{
    public class ClientesController : HomeController
    {
        private readonly IClienteRepository _repository;

        public ClientesController(IClienteRepository ClienteRepository)
        {
            _repository = ClienteRepository;
        }

        public IActionResult index()
        {
            var cliente = _repository.GetAll();

            return View(cliente);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {

            _repository.Create(cliente);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente) {
            _repository.Update(cliente);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
