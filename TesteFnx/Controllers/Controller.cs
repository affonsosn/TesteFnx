using System.Data.SqlClient; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteFnx.Repositories;
using TesteFnx.Model;
using System.Collections.Generic;
using System;


namespace TesteFnx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly VeiculoRepositorio _veiculoRepositorio;
        public Controller()
        {
            _veiculoRepositorio = new VeiculoRepositorio();
        }
        // GET api/Values
        [HttpGet]
        public ActionResult <IEnumerable<Veiculo>> Get() 
        {
            return _veiculoRepositorio.GetVeiculos;
        }

        // GET api/Values
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
