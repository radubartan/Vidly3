using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly3.Models;
using Vidly3.ViewModels;


namespace Vidly3.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        // line below was: 'private' CustomersController() - I changed it to 'public' because I was getting this error: 'No parameterless constructor defined for this object.'
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Shrek!" };

            // the list of customers
            var customers = new List<Customer>
            {
                // this is for the sake of the first commit
                new Customer { Name = "John Smith", Id = 1 },
                new Customer { Name = "Mary Williams", Id = 2 }
            };

            var viewModel = new RandomMovieViewModel();
            viewModel.Movie = movie;
            viewModel.Customers = customers;

            // part of the code from Vidly2
            //return View(viewModel);

            var customers2 = _context.Customers.ToList();
            return View(customers2);

            
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        public ActionResult DisplayCustomer(int id)
        {
            if (id == 1)
            {
                var customer = new List<Customer>
                {
                    new Customer { Name = "John Smith", Id = 1 }
                };

                var viewModel = new RandomMovieViewModel();
                viewModel.Customers = customer;
                return View(viewModel);
            }
            else if (id == 2)
            {
                var customer = new List<Customer>
                {
                    new Customer { Name = "Mary Williams", Id = 2 }
                };

                var viewModel = new RandomMovieViewModel();
                viewModel.Customers = customer;
                return View(viewModel);
            }
            else
            {
                //Response.StatusCode = 404;
                throw new HttpException(404, "Not found");
                return View();
            }
        }
    }
}