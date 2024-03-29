﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<UserDetailDto>> GetUserDetails();
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int userId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
