﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetById(int rentalId);
        IDataResult<List<Rental>> GetByCarId(int carId);
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
