﻿using Microsoft.AspNetCore.Mvc;
using SharedKernel.Application.Cqrs.Commands;
using Stock.Application.Products.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace Stock.Api.Products
{
    public partial class ProductsController
    {
        /// <summary>
        /// Create a product
        /// </summary>
        [HttpPost("api/createProduct")]
        public async Task<IActionResult> CreateProductWithReturn([FromServices] ICommandBus commandBus, [FromBody] CreateProductCommand command, CancellationToken cancellationToken)
        {
            await commandBus.Dispatch(command, cancellationToken);
            return Ok();
        }

    }
}
