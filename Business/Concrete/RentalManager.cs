using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new DataResult<List<Rental>>(_rentalDal.GetAll(), true);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new DataResult<Rental>(_rentalDal.GetById(r => r.Id == rentalId), true);
        }

        public IResult Add(Rental rental)
        {
            var result = new DataResult<Rental>(_rentalDal.GetById(r => r.Id == rental.Id), true);

            if (result.Data.ReturnDate != null)
            {
                return new Result(false, "Araç zaten kirada..");
            }

            _rentalDal.Add(rental);
            return new Result(true);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new Result(true);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new Result(true);
        }
    }
}
