using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Web.WebPages.Html;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        public List<SelectListItem> GetCategoriesSelect()
        {
            using (var db = new NorthwindContext())
            {
                var result = (from a in db.Categories
                              select new SelectListItem
                              {
                                  Value = a.CategoryId.ToString(),
                                  Text = a.CategoryName
                              });
                return result.ToList();
            }

        }
    }
}
