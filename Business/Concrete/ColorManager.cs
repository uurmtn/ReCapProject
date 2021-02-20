using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using ReCapProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetColors()
        {
            return _colorDal.GetAll();
        }
    }
}