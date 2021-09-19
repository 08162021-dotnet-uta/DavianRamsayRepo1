using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplicationWebAppAPI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepo _customerRepo;
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(ICustomerRepo cr, ILogger<CustomerController> logger)
        {
            _customerRepo = cr;
            _logger = logger;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerController/Details/5
        [HttpGet("customerlist")]
        public async Task<List<ViewModelCustomer>> Details()
        {
            Task<List<ViewModelCustomer>> customers = _customerRepo.CustomerListAsync();
            List<ViewModelCustomer> customers1 = await customers;
            return customers1;
        }

        // GET: CustomerController/Create
        [HttpPost("register")]
        public async Task<ActionResult<ViewModelCustomer>> Create(ViewModelCustomer vc)
        {
            if (!ModelState.IsValid) return BadRequest();
            ViewModelCustomer c1 = await _customerRepo.RegisterCustomerAsync(vc);
            if (c1 == null)
            {
                return NotFound();
            }
            //////////////////////////////////////////////////////////////RECHECK THE F.NAME///////////////////////////////////////////////////////////////
            return Created($"~customer/{c1.Fname}", c1);
        }

        // POST: CustomerController/Create
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

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
        [HttpGet("login/{fname}/{lname}")]
        public async Task<ActionResult<ViewModelCustomer>> Login(string fname, string lname)
        {
            if (!ModelState.IsValid) return BadRequest();
            ViewModelCustomer c = new ViewModelCustomer() { Fname = fname, Lname = lname };
            ViewModelCustomer c1 = await _customerRepo.LoginCustomerAsync(c);
            if (c1 == null)
            {
                return NotFound();
            }
            return Ok(c1);
        }
    }
}
