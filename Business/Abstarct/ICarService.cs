using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);

        List<Car> GetByUnitPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
    }
}
