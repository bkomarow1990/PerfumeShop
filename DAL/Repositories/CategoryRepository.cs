using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DAL.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(BrilliantDbContext context)
            :base(context)
        {
            
        }
        
    }
}
