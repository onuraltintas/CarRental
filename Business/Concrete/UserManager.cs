using System.Collections.Generic;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            return new DataResult<List<User>>(_userDal.GetAll(), true);
        }

        public IDataResult<User> GetById(int userId)
        {
            return new DataResult<User>(_userDal.GetById(u => u.Id == userId), true);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new Result(true);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.GetById(u => u.Email == email));
        }
    }
}
