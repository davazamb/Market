namespace Market.Backend.Models
{
    using Market.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Market.Common.Models.Product> Products { get; set; }
    }
}