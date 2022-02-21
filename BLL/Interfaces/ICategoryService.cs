using BLL.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICategoryService
    {
        void AddCategory(CategoryDTO category);
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
        CategoryDTO GetCategoryById(int id);
        void EditCategory(CategoryDTO category);
        void DeleteCategoryById(int id);
    }
}
