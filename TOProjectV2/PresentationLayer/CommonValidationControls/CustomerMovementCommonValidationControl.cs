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
	public class CustomerMovementCommonValidationControl
	{
		public bool CustomerMovementValidatorAndMessage(CustomerMovement customerMovement)
		{
			CustomerMovementValidator customerMovementValidator=new CustomerMovementValidator();
			ValidationResult result = customerMovementValidator.Validate(customerMovement);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
			return (new AAAValidatorCommonArea().CheckAndRotate(result));
		}
				
	}
}
