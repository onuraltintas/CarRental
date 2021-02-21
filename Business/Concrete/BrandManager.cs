using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new DataResult<List<Brand>>(_brandDal.GetAll().ToList(),true,"Marka Listelendi...");
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new DataResult<Brand>(_brandDal.GetById(b => b.Id == brandId),true,"Marka getirildi.");
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new Result(true, "Marka Eklendi...");
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true, "Marka Güncellendi");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(true, "Marka Silindi...");
        }
    }
}
