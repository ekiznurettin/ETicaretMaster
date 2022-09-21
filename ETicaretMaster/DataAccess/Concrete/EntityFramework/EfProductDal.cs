using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductWithCategoryDto> GetProductWithCategoryName()
        {
            using (var db = new NorthwindContext())
            {
                var result = (from product in db.Products
                              join category in db.Categories on product.CategoryId equals category.CategoryId
                              select new ProductWithCategoryDto
                              {
                                  CategoryId = category.CategoryId,
                                  CategoryName=category.CategoryName,
                                  ProductId = product.ProductId,
                                  ProductName=product.ProductName,
                                  QuantityPerUnit=product.QuantityPerUnit,
                                  UnitPrice=product.UnitPrice,
                                  UnitsInStock=product.UnitsInStock
                              });
                return result.ToList();
            }

        }
    }
}
