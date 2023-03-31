using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public List<Car> _Cars;
        public InMemoryCarDal() => _Cars = new List<Car> {
            new Car{Id = 1, BrandId=1, ColorId=1, ModelYear=2000, DailyPrice=100, Description="BMW"  },
            new Car{Id = 2, BrandId=2, ColorId=2, ModelYear=3000, DailyPrice=200, Description="Mercedes"  },
            new Car{Id = 3, BrandId=3, ColorId=3, ModelYear=2000, DailyPrice=400, Description="Volvo"  },
            new Car{Id = 4, BrandId=4, ColorId=4, ModelYear=5000, DailyPrice=500, Description="Audi"  },

        };
        public List<Car> GetAll()
        {
            return _Cars;
        }

        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _Cars.FirstOrDefault(c => c.Id == car.Id);
            _Cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _Cars.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }

        public Car GetById(int id)
        {
            return _Cars.FirstOrDefault(c => c.Id == id);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}