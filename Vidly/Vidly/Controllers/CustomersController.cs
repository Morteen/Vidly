﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        /// <summary>
        /// Vi må bruke em konstruktør  for å initaliere dbcontexten
        /// </summary>
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: Customers
        public ActionResult Index()
        {

            //Lager en viewModel for å send ut i Index viewet
            /*var viewModel = new RandomViewModel();
            


            ViewBag.Message = "Customer";
            List<Customer>customer = _context.Customers.ToList();
            viewModel.Customers = customer;*/
            List<Customer> customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}