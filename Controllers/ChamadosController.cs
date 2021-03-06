using System;
using aspnet_core___Copia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace aspnet_core___Copia.Controllers
{
     public class ChamadosController : Controller
    {

        private readonly IChamadoRepository _repository;

        public ChamadosController(IChamadoRepository ChamadoRepository)
        {
            _repository = ChamadoRepository;
        }

        public IActionResult index()
        {
            var chamados = _repository.GetAll();

            return View(chamados);
        }

        [HttpGet]
        public IActionResult ListaOrder() {

            var chamados = _repository.GetAll().OrderByDescending(s => s.horaInicio);;

            return View(chamados);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Chamado chamado)
        {

            _repository.Create(chamado);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Chamado chamado) {
            _repository.Update(chamado);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}