﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join c2 in context.Colors
                             on c.ColorId equals c2.ColorId
                             select new CarDetailDto { Id = c.Id, DailyPrice = c.DailyPrice, BrandName = b.BrandName, ColorName = c2.ColorName, Description = c.Description, ModelYear = c.ModelYear };

                return result.ToList();
                             

            }
        }
    }
}
