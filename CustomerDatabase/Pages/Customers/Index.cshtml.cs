using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CustomerDatabase.Models;

namespace CustomerDatabase.Pages.Customers
{
    /* Written by Paul Smyth
     * Date 31/01/2018
     * Version 1.0
     */
    public class IndexModel : PageModel
    {
        private readonly CustomerDatabase.Models.CustomerContext _context;

        public IndexModel(CustomerDatabase.Models.CustomerContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
