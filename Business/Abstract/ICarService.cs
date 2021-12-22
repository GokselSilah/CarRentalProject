﻿using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int id);
        List<Car> GetByRentalPrice(decimal max, decimal min);
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<CarDetailDto> GetCarDetails();

    }
}