using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        ICarDal _cardal;
        List<Car> _cars;


        public InMemoryCarDal()
        {            
            _cars = new List<Car>
            {
                new Car{ Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 750, ModelYear = 2020 , Description = "MERCEDES E250 CDI" },
                new Car{ Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 1050, ModelYear = 2018 , Description = "MERCEDES S500 LONG" },
                new Car{ Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 650, ModelYear = 2019 , Description = "AUDİ A6 S-LINE" },
                new Car{ Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 550, ModelYear = 2020 , Description = "AUDİ A4 SPORTBACK" },
                new Car{ Id = 5, BrandId = 3, ColorId = 4, DailyPrice = 350, ModelYear = 2021 , Description = "PEUGEOT 3008" },
                new Car{ Id = 6, BrandId = 3, ColorId = 4, DailyPrice = 250, ModelYear = 2022 , Description = "PEUGEOT 2008" },
                new Car{ Id = 7, BrandId = 4, ColorId = 1, DailyPrice = 150, ModelYear = 2019 , Description = "RENAULT MEGANE DCI" }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var result = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(result);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
