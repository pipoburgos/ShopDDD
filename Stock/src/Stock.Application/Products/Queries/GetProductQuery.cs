﻿using System;
using SharedKernel.Application.Cqrs.Queries;

namespace Stock.Application.Products.Queries
{
    /// <summary>
    /// This is a contract with the API, similar to Dto, this can be write with new feature RECORD
    /// </summary>
    public class GetProductQuery : IQueryRequest<Guid> // Esto es lo que retorna (Un dto cuando tenga)
    {
        public GetProductQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

    }
}
