﻿using System;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases;
public class ViewProductsUseCase : IViewProductsUseCase
{
    private readonly IProductRepository _productRepository;

    public ViewProductsUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> Execute()
    {
        return _productRepository.GetProducts();
    }
}