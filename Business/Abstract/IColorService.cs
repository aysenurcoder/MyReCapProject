﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
        IDataResult<List<Color>> GetCarsByColorId(int id);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);
    }
}
