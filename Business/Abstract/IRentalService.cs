﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetById();
        IDataResult<List<Rental>> GetAll();
        IResult Add();
        IResult Update();
        IResult Delete();
    }
}
