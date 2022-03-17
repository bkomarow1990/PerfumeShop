using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(BrilliantDbContext context)
            :base(context)
        {
            
        }
    }
}
