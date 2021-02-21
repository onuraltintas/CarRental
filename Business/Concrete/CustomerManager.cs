using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new DataResult<List<Customer>>(_customerDal.GetAll().ToList(), true);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new DataResult<Customer>(_customerDal.GetById(c => c.Id == customerId), true);
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new Result(true);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new Result(true);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new Result(true);
        }
    }
}
