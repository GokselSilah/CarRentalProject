using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.UserId equals c.UserId
                             select new UserDetailDto { UserId = u.UserId, FirstName = u.FirstName, LastName = u.LastName, Email = u.Email, CompanyName = c.CompanyName };

                return result.ToList();
            }
        }
    }
}
