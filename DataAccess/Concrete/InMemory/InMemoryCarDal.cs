using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {CarId=1,BrandId=1,ColorId=2,ModelYear=2015,DailyPrice=300,Description="Voswogen Golf"},
                new Car {CarId=2,BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=350,Description="Voswogen Polo"},
                new Car {CarId=3,BrandId=2,ColorId=5,ModelYear=2010,DailyPrice=200,Description="Fiat Linea"},
                new Car {CarId=4,BrandId=2,ColorId=3,ModelYear=2016,DailyPrice=350,Description="Fiat Doblo"},
                new Car {CarId=5,BrandId=2,ColorId=1,ModelYear=2020,DailyPrice=400,Description="Fiat Linea"}
            };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
