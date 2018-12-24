using FluentValidation;
using TODOList.Entities;

namespace TODOList.Repositories.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(property => property.Description)
                .NotEmpty()
                .MaximumLength(57);
        } 
    }
}
