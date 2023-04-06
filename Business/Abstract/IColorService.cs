using System;
using Entities.Concrete;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
	public interface IColorService
	{
        IResult Add(Color color);
        IDataResult<List<Color>> GetAll();
    }
}

