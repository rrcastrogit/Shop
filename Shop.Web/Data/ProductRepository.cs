using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Web.Data.Entities;

namespace Shop.Web.Data
{
    using Entities;

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }

}

