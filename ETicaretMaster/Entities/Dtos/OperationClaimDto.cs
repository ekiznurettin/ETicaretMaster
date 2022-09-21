using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
  public  class OperationClaimDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
    }
}
