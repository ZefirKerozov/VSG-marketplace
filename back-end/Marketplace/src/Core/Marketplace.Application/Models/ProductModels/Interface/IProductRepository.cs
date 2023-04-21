﻿using System.Reflection;
using Markerplace.Domain.Entities;
using Marketplace.Application.Models.GenericRepository;
using Marketplace.Application.Models.ProductModels.Dtos;

namespace Marketplace.Application.Models.ProductModels.Interface;

public interface IProductRepository :IGenericRepository<Products>
{
    Task<List<GetProductsDto>> GetAllProductForSale();
    Task<ProductDetailsDto> GetProductById(int productId);
    
}