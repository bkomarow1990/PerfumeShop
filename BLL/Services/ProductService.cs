using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOS;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;


namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddProduct(ProductDTO product)
        {
            await _unitOfWork.ProductRepository.InsertAsync( _mapper.Map<Product>(product));
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts() => _mapper.Map<IEnumerable<ProductDTO>>(await _unitOfWork.ProductRepository.GetAsync());
        

        public async Task<ProductDTO> GetProductById(int id) => _mapper.Map<ProductDTO>(await _unitOfWork.ProductRepository.GetByIdAsync(id));

        public async Task EditProduct(ProductDTO product)
        {
            await _unitOfWork.ProductRepository.UpdateAsync(_mapper.Map<Product>(product));
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteProductById(int id)
        {
            await _unitOfWork.ProductRepository.DeleteAsync(id);
        }
    }
}
