using System;
using Entities.Concrete;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
	public interface IBrandService
	{
        IResult Add(Brand brand);
        IDataResult<List<Brand>> GetAll();
    }
}

