using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Bussiness.Constants;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new DataResult<List<Car>>(_carDal.GetAll(), true, Messages.CarListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(carId));
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new Result(true, Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, "Araç Güncellendi");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, "Araç Silindi");
        }
    }
}
