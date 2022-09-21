using Core.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
       List<ProductWithCategoryDto> GetProductWithCategoryName();
    }
}
