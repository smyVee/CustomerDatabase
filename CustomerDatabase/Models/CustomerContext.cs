using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerDatabase.Models
{
    /* Written by Paul Smyth
     * Date 31/01/2018
     * Version 1.0
     */
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
    }
}
