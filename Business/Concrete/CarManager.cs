using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.BrandName.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba basariyla eklendi.");
            }
            else
            {
                Console.WriteLine("Lutfen gunluk fiyat kismini 0'dan buyuk giriniz ve/veya araba ismi 2 karakterden olusmalidir.");
            }
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandID == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorID == id);
        }
    }
}
