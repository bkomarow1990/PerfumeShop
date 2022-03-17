using BLL.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProductService
    {
        Task AddProduct(ProductDTO product);
        Task<IEnumerable<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task EditProduct(ProductDTO product);
        Task DeleteProductById(int id);
    }
}
