using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int colorId);
    }
}
