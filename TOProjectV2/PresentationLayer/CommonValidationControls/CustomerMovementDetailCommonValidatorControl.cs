using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.CommonValidationControls
{
	public class CustomerMovementDetailCommonValidatorControl
	{
		public bool CustomerMovementDetailValidatorAndMessage(CustomerMovementDetail customerMovementDetail)
		{
			CustomerMovementDetailValidator customerMovementDetailValidator = new CustomerMovementDetailValidator();
			ValidationResult result = customerMovementDetailValidator.Validate(customerMovementDetail);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
			return (new AAAValidatorCommonArea().CheckAndRotate(result));

		}
	}
}
