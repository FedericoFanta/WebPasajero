using EntityFrameworkExample.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using WebPasajero.Models;

namespace WebPasajero.Controllers
{
    public class PasajeroController : Controller
    {
        private readonly PasajeroContext _context;

        public PasajeroController(PasajeroContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Pasajeros.ToList());
        }


        //GET: /Pasajero/Create
        public IActionResult Create()
        {
            Pasajero pasajero = new Pasajero();
            return View("Create", pasajero);
        }

        //POST: /Pasajero/Create
        [HttpPost]
        public IActionResult Create(Pasajero pasajero)
        {
            _context.Add(pasajero);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet("/pasajero/fecha/{fecha}")]
        // GET: 
        public IActionResult ListaPorFecha(DateTime fecha)
        {
            List<Pasajero> lista = (from p in _context.Pasajeros
                                  where p.FechaDeNacimiento == fecha
                                  select p).ToList();
            return View("Index", lista);
        }



        [HttpGet("/pasajero/ciudad/{city}")]
        // GET: 
        public IActionResult ListaPorCiudad(string city)
        {
            List<Pasajero> lista = (from p in _context.Pasajeros
                                    where p.Ciudad == city
                                    select p).ToList();
            return View("Index", lista);
        }


    }
}
