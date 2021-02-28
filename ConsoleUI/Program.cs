using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static ICarService _carService = new CarManager(new EfCarDal());
        static void Main(string[] args)
        {
            GetAll();
            Console.WriteLine(Environment.NewLine);
            GetCarsByBrandId();
            Console.WriteLine(Environment.NewLine);
            GetCarsByColorId();
            Console.WriteLine(Environment.NewLine);
            Add();
            Console.ReadKey();
        }
        static void Add()
        {
            try
            {
                Car car = new Car
                {
                    BrandId = 7,
                    ColorId = 9,
                    DailyPrice = 0,
                    Description = "Yeni Araç",
                    ModelYear = 2015,
                    Name = "Audi"
                    
                };
                _carService.Add(car);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        static void GetCarsByBrandId()
        {
            List<CarDetailDto> cars = _carService.GetCarsByBrandId(4);
            foreach (var car in cars)
            {
                Console.WriteLine(String.Format($"Id : {car.CarId}, Name : {car.CarName}, BrandId : {car.ColorId}"));
            }
        }
        static void GetCarsByColorId()
        {
            List<CarDetailDto> cars = _carService.GetCarsByColorId(8);
            foreach (var car in cars)
            {
                Console.WriteLine(String.Format($"Id : {car.CarId}, Name : {car.CarName}, ColorId : {car.ColorId}"));

            }
        }
        static void GetAll()
        {
            foreach (Car car in _carService.GetAll())
            {
                Console.WriteLine(String.Format($"Id : {car.CarId}, Name : {car.Name}"));

            }

        }

    }
}
