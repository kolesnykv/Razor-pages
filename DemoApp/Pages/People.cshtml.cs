using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages
{
	public class PeopleModel : PageModel
    {
        private readonly MyDbContext _context;

        [BindProperty]
        public Person person { get; set; }

        public List<Person> People { get; set; } = new List<Person>(); 

        public PeopleModel(MyDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            People = _context.People.ToList();
        }
        public IActionResult OnPost() {
            _context.People.Add(person);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}
