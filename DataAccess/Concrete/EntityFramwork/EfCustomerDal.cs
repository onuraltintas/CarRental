using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfCustomerDal:EfEntityRepository<Customer,RentACarContext>, ICustomerDal
    {
    }
}
