using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=4,DailyPrice= 150,ModelYear="1950",Description="Antika araba"},
                new Car{CarId=2,BrandId=2,ColorId=47,DailyPrice= 250,ModelYear="1947",Description="Antika araba"},
                new Car{CarId=3,BrandId=2,ColorId=7,DailyPrice= 350,ModelYear="2010",Description="Otomatik vites"},
                new Car{CarId=4,BrandId=1,ColorId=5,DailyPrice= 500,ModelYear="2021",Description="Otomatik vites"},
                new Car{CarId=5,BrandId=1,ColorId=6,DailyPrice= 240,ModelYear="2000",Description="Manuel vites"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public Car Get()
        {
            throw new NotImplementedException();
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
            return _cars;
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
