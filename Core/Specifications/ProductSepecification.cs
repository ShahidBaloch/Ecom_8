﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductSepecification : BaseSpecification<Product>
    {
        public ProductSepecification(string? brand, string? type, string? sort) : base(x =>
           (string.IsNullOrWhiteSpace(brand) || x.Brand == brand)
            && (string.IsNullOrWhiteSpace(type) || x.Type == type))
        {
            switch (sort)
            {
                case "priceAsc":
                    AddOrderBy(x=>x.Price); 
                    break;
                case "priceDesc":
                    AddOrderBy(x => x.Price);
                    break;
                default:AddOrderBy(x=>x.Name);
                    break;

            }
        }
    }
}
