﻿using System;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases;

public class ViewProductsByCategoryId : IViewProductsByCategoryId
{
    private readonly IProductRepository _productRepository;

    public ViewProductsByCategoryId(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> Execute(int categoryId)
    {
        return _productRepository.GetProductsByCategoryId(categoryId);
    }
}