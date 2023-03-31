using System;
using Entities.Abstract;

namespace Entities.Concrete
{
	public class Color:IEntities
	{
		public int Id { get; set; }
		public string ColorName { get; set; }
	}
}

