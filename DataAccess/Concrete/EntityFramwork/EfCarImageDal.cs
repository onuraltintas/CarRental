using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfCarImageDal: EfEntityRepository<CarImage,RentACarContext>, ICarImageDal
    {

    }
}
