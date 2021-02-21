using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfRentalDal:EfEntityRepository<Rental,RentACarContext>,IRentalDal
    {
    }
}
