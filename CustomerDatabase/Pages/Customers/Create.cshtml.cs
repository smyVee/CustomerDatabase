using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CustomerDatabase.Models;

namespace CustomerDatabase.Pages.Customers
{
    /* Written by Paul Smyth
     * Date 31/01/2018
     * Version 1.0
     */
    public class CreateModel : PageModel
    {
        private readonly CustomerDatabase.Models.CustomerContext _context;
       

        public CreateModel(CustomerDatabase.Models.CustomerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        

// Create Button
public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Perform validation routines on data entered

            
            

            if (Customer.FullName == "")
            {
                // Go back to page with an error message
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}