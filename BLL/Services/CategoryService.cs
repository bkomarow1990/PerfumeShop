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

        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
