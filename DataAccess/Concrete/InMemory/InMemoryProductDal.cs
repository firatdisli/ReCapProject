using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=200,ModelYear=2015,Description="Spor Araba" },
                new Car{Id=2,BrandId=1,ColorId=4,DailyPrice=150,ModelYear=2016,Description="Aile arabası" },
                new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=120,ModelYear=2017,Description="Ticari Araba" },
                new Car{Id=4,BrandId=2,ColorId=5,DailyPrice=240,ModelYear=2018,Description="SUV Araba" },
                new Car{Id=5,BrandId=2,ColorId=1,DailyPrice=110,ModelYear=2019,Description="Ticari Araba" },
                new Car{Id=6,BrandId=3,ColorId=3,DailyPrice=150,ModelYear=2014,Description="Aile Araba" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GelAll()
        {
            return _cars;
        }

       
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

      
    }
}
