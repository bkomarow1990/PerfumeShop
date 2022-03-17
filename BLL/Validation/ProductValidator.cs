using BLL.DTOS;
using FluentValidation;

namespace BLL.Validation
{
    public class ProductValidator : AbstractValidator<ProductDTO>
    {
        public ProductValidator()
        {
            RuleFor(g=> g.Name).NotNull().NotEmpty();
        }
    }
}
