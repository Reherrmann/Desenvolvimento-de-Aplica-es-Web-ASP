using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Base.Domain.Entities;
using Amigos.services.interfaces;



namespace Am.Web.Controllers
{
    public class ListController : Controller
    {
        private readonly IAmigosService _amigoService;
        public ListController(IAmigosService amigosService)
        {
            _amigoService = amigosService;
        }

        [Route("/List/ListaDeAmigos")]
        public IActionResult ListaDeAmigos()
        {

            var listaDeAmigos = _amigoService.GetAmigos();
            return View(listaDeAmigos);
        }

        [HttpPost]
        [Route("list/selecionar")]
        public IActionResult Selecionar()
        {
            return View();
        }


    }
}
