using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretWebUI.Models
{
    public class CategoryListViewModel
    {
      public  IDataResult<List<Category>> Categories { get; set; }
      public  Category Category { get; set; }
    }
}
