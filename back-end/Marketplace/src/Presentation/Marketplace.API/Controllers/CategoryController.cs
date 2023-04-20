﻿using Markerplace.Domain.Entities;
using Marketplace.Application.Models.CategorieModels.Dtos;
using Marketplace.Application.Models.CategorieModels.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.API.Controllers;

[Route("api/Category")]
[ApiController]
public class CategoryController: ControllerBase
{
    private readonly ICategorieService _categorieService;

    public CategoryController(ICategorieService categorieService)
    {
        _categorieService = categorieService;
    }
    [HttpGet]
    [Route("All")]
    public List<Categories> GetAllCategories()
    {
        return _categorieService.GetCategories();
    }
}