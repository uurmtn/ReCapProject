﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);

            }
            else
            {
                Console.WriteLine("Araç ekleme başarısız");
            }
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.DailyPrice == id);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
        public List<CarDetailDto> GetCarDetailDto()
        {
            //return _carDal.GetCarDetailDtos();
            throw new NotImplementedException();
        }

        List<CarDetailDto> ICarService.GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        List<CarDetailDto> ICarService.GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
