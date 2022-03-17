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
using BLL.Exceptions;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

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
        public async Task AddCategory(CategoryDTO category)
        {
            if (category == null)
                throw new HttpException($"Error with create new category!", System.Net.HttpStatusCode.BadRequest);
            await _unitOfWork.CategoryRepository.InsertAsync(_mapper.Map<Category>(category));
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            return _mapper.Map<IEnumerable<CategoryDTO>>(await _unitOfWork.CategoryRepository.GetAsync());
        }

        public async Task<CategoryDTO> GetCategoryById(int id) => _mapper.Map<CategoryDTO>(await _unitOfWork.CategoryRepository.GetByIdAsync(id));

        public async Task EditCategory(CategoryDTO category)
        {
            await _unitOfWork.CategoryRepository.UpdateAsync(_mapper.Map<Category>(category));
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteCategoryById(int id)
        {
            await _unitOfWork.CategoryRepository.DeleteAsync(await _unitOfWork.CategoryRepository.GetByIdAsync(id));
            await _unitOfWork.SaveChangesAsync();
        }

    }
}
