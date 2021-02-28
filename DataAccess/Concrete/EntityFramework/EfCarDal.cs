using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from ca in filter is null ? context.Cars : context.Cars.Where(filter)
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = ca.CarId,
                                 BrandId = br.BrandId,
                                 ColorId = co.ColorId,
                                 BrandName = br.BrandName,
                                 CarName = ca.Name,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear= ca.ModelYear
                                 
                             };

                return result.ToList();
            }
        }

        
    }
}