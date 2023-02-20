using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amigos.services.interfaces;
using Base.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Am.Web.Controllers
{
    public class AmigoController : Controller
    {
        private readonly IAmigosService _amigoService;

        public AmigoController(IAmigosService amigosService)
        {
            _amigoService = amigosService;
        }

        public IActionResult Index()
        {
             // var amigos = amigosService.GetAmigos();

         return View(_amigoService.GetAmigos());
            //  return View(amigos);
        }
    }
}