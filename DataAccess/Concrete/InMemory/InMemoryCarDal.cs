using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1, ColorId = 1, BrandId = 1, ModelYear = "2014", DailyPrice = 50,
                    Description = "Mazda 3 SkyActive"
                },
                new Car
                {
                    Id = 2, ColorId = 4, BrandId = 2, ModelYear = "1999", DailyPrice = 50,
                    Description = "Opel Corsa"
                },
                new Car
                {
                    Id = 3, ColorId = 3, BrandId = 2, ModelYear = "2005", DailyPrice = 50,
                    Description = "Fiat Punto"
                },
                new Car
                {
                    Id = 4, ColorId = 5, BrandId = 4, ModelYear = "2020", DailyPrice = 50,
                    Description = "Ford Mondeo"
                },
                new Car
                {
                    Id = 5, ColorId = 2, BrandId = 3, ModelYear = "2008", DailyPrice = 50,
                    Description = "Ford Kuga"
                },
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
                carToUpdate.ModelYear = car.ModelYear;
            }
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
    }
}
