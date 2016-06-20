using Paging.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Paging.DataAccessLayer
{
    public class DataAccessContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}