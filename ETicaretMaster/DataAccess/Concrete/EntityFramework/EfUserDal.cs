using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var db = new NorthwindContext())
            {
                var result = (from operationclaim in db.OperationClaims
                              join userOperationClaim in db.UserOperationClaims on operationclaim.Id equals userOperationClaim.OperationClaimId
                              where userOperationClaim.UserId == user.Id
                              select new OperationClaim
                              {
                                  Id = operationclaim.Id,
                                  Name = operationclaim.Name,
                                 // UserName=user.FirstName +" "+user.LastName
                              });
                return result.ToList();
            }
        }
    }
}
