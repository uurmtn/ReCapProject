using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;
using Color = Entities.Concrete.Color;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarRentalContext> , IColorDal
    {
        public void Add(Color entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public List<Color> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
