using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfBrandDal:EfEntityRepository<Brand,RentACarContext>,IBrandDal
    {
        
    }
}
