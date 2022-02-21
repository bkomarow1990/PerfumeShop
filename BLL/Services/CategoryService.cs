using AutoMapper;
using BLL.DTOS;
using BLL.Interfaces;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly BrilliantDbContext _context;
        private readonly IMapper _mapper;
        public CategoryService(BrilliantDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddCategory(CategoryDTO category)
        {
            _context.Categories.Add(_mapper.Map<Category>(category));
            _context.SaveChanges();
        }

        public void DeleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCategory(CategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            return _mapper.Map<IEnumerable<CategoryDTO>>(await _context.Categories.ToListAsync());
        }

        public CategoryDTO GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
