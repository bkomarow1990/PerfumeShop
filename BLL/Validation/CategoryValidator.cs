using FluentValidation;
using BLL.DTOS;

namespace BLL.Validation
{
    public class CategoryValidator : AbstractValidator<CategoryDTO>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().NotNull();
        }
    }
}
