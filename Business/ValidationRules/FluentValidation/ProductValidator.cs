using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class ProductValidator:AbstractValidator<Car>
	{
		public ProductValidator()
		{
			RuleFor(p => p.CarName).NotEmpty();
			RuleFor(p => p.CarName).MinimumLength(2);
			RuleFor(p => p.DailyPrice).NotEmpty();
			RuleFor(p => p.DailyPrice).GreaterThan(0);
			RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.BrandId == 1);
			RuleFor(p => p.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");

        }

        private bool StartWithA(string arg)
        {
			return arg.StartsWith("A");
        }
    }
}

