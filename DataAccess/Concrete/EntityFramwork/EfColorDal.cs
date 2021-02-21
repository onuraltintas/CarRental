using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfColorDal:EfEntityRepository<Color,RentACarContext>,IColorDal
    {
       
    }
}
