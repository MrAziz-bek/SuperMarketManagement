﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness;

public class Category
{
    public int CategoryId { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    public List<Product> Products { get; set; }
}