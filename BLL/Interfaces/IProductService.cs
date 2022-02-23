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
        void AddProduct(ProductDTO category);
        IEnumerable<ProductDTO> GetAllProducts();
        ProductDTO GetProductById(int id);
        void EditProduct(ProductDTO category);
        void DeleteProductById(int id);
    }
}
