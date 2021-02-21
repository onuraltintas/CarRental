using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new DataResult<List<Color>>(_colorDal.GetAll().ToList(),true);
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new DataResult<Color>(_colorDal.GetById(c=>c.Id==colorId),true);
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new Result(true, "Renk Eklendi...");
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new Result(true, "Renk Güncellendi...");
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new Result(true, "Renk Silindi...");
        }
    }
}
