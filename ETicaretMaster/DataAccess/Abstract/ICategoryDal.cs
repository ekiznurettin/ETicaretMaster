using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.WebPages.Html;

namespace DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
        List<SelectListItem> GetCategoriesSelect();
    }
}
