using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.WebPages.Html;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
      Category GetById(int categoryId);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(int categoryId);
        IDataResult<List<SelectListItem>> GetCategoriesSelect();
    }
}
