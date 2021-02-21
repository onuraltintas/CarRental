using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfCarDal : EfEntityRepository<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarProductDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                    join col in context.Colors
                        on c.ColorId equals col.Id
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    select new CarDetailDto
                    {
                        BrandName = b.Name,
                        CarName = c.Description,
                        ColorName = col.Name,
                        DailyPrice = c.DailyPrice
                    };
                return result.ToList();
            }
        }

        public List<Car> GetAll()
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Cars.ToList();
            }
        }

        public Car GetById(int carId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Cars.SingleOrDefault(c => c.Id == carId);
            }
        }
    }
}
