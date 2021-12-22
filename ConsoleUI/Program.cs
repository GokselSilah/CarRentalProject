using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //List<Brand> brands = new List<Brand>()
            //{
            //    new Brand() { BrandId = 1, BrandName = "Mercedes"},
            //    new Brand() { BrandId = 2, BrandName = "Audi"},
            //    new Brand() { BrandId = 3, BrandName = "Peugeot"},
            //    new Brand() { BrandId = 4, BrandName = "Citroen"},
            //    new Brand() { BrandId = 5, BrandName = "Dacia"},
            //    new Brand() { BrandId = 6, BrandName = "BMW"},
            //};

            //foreach (var brand in brands)
            //{
            //    brandManager.Add(brand);
            //}

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //List<Color> colors = new List<Color>()
            //{
            //    new Color() { ColorId = 1, ColorName = "Beyaz" },
            //    new Color() { ColorId = 2, ColorName = "Siyah" },
            //    new Color() { ColorId = 3, ColorName = "Gri" },
            //    new Color() { ColorId = 4, ColorName = "Mavi" },
            //    new Color() { ColorId = 5, ColorName = "Turuncu" },

            //};

            //foreach (var color in colors)
            //{
            //    colorManager.Add(color);
            //}

            CarManager carManager = new CarManager(new EfCarDal());

            //List<Car> cars = new List<Car>()
            //{
            //    new Car() { Id = 1, BrandId = 1, ColorId = 2, DailyPrice= 500, Description= "E250 CDI", ModelYear= 2019 },
            //    new Car() { Id = 2, BrandId = 3, ColorId = 5, DailyPrice= 350, Description= "2008", ModelYear= 2021 },
            //    new Car() { Id = 3, BrandId = 4, ColorId = 1, DailyPrice= 300, Description= "C3 AirCross", ModelYear= 2020 },
            //    new Car() { Id = 4, BrandId = 5, ColorId = 4, DailyPrice= 200, Description= "Sandero Stepway", ModelYear= 2017 },
            //    new Car() { Id = 5, BrandId = 2, ColorId = 1, DailyPrice= 400, Description= "A3", ModelYear= 2019 },

            //};


            //foreach (var car in cars)
            //{
            //    carManager.Add(car);
            //}



            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}-{1} markalı {2} aracı günlük {3} TL karşılığında kiralayabilirsiniz.",car.BrandName,car.Description,car.ColorName,car.DailyPrice);
            }

        }
    }
}
