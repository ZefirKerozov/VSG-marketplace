﻿using System.Reflection;
using Markerplace.Domain.Entities;
using Marketplace.Application.Models.ProductModels.Dtos;

namespace Marketplace.Application.Models.ProductModels.Interface;

public interface IProductRepository
{
    List<GetProductsDto> GetAllProduct();
    ProductDetailsDto GetProductById(int productId);
}