using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace ETicaretWebUI.Models
{
    public class ProductListViewModel
    {
        public Product Product { get; set; }
        public IDataResult<List<ProductWithCategoryDto>> Products { get; set; }
        public IDataResult<List<SelectListItem>> Categories { get; set; }
    }
}
