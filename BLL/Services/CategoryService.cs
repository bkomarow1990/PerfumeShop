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
using DAL.Interfaces;

namespace BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async void AddCategory(CategoryDTO category)
        {
            await _unitOfWork.CategoryRepository.Add(_mapper.Map<Category>(category));
            await _unitOfWork.CompleteAsync();
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
            return _mapper.Map<IEnumerable<CategoryDTO>>(await _unitOfWork.CategoryRepository.All());
        }

        public CategoryDTO GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        Task ICategoryService.AddCategory(CategoryDTO category)
        {
            throw new NotImplementedException();
        }
    }
}
