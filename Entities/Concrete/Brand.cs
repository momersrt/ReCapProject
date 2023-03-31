using System;
using Entities.Abstract;

namespace Entities.Concrete
{
	public class Brand:IEntities
	{
		public int Id { get; set; }
		public string BrandName { get; set; }
	}
}

