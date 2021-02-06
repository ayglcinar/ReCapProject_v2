using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ ID=1, BrandID=1, ColorID=1, ModelYear= "2015", DailyPrice = 290, Description = "Benzin"},
                new Car{ ID=2, BrandID=1, ColorID=2, ModelYear= "2018", DailyPrice = 450, Description = "Dizel"},
                new Car{ ID=3, BrandID=2, ColorID=1, ModelYear= "2015", DailyPrice = 590, Description = "Benzin"},
                new Car{ ID=4, BrandID=2, ColorID=2, ModelYear= "2018", DailyPrice = 590, Description = "Benzin"},
                new Car{ ID=5, BrandID=2, ColorID=3, ModelYear= "2020", DailyPrice = 590, Description = "Dizel"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.ID == car.ID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GeyById(int BrandID)
        {
            return _cars.Where(c => c.BrandID == BrandID).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.ID == car.ID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}