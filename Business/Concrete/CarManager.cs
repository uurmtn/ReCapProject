using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public List<Car> GetCarsByBrandId(int v)
        {
            return _carDal.GetAll(p => p.BrandId == v);
        }

        public List<Car> GetCarsByColorId(int v)
        {
            return _carDal.GetAll(p => p.DailyPrice == v);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
