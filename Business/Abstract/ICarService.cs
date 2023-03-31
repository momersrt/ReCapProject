using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICarService
	{
        void Add(Car car);
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);
    }
}

