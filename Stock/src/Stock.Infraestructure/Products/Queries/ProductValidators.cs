using FluentValidation;
using Stock.Application.Products.Commands;

namespace Stock.Infrastructure.Products.Queries
{
    /// <summary>
    /// Valida el comando
    /// </summary>
    public class ProductValidators : AbstractValidator<CreateProductWithReturnCommand>
    {
    }
}
