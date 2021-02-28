using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Color = Entities.Concrete.Color;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}
