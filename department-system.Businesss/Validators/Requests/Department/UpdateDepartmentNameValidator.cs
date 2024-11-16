using department_system.Business.DTO.RequestDTO.DepartmentDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.DepartmentValidators;

public class UpdateDepartmentNameValidator :AbstractValidator<UpdateDepartmentNameDto>
{
	public UpdateDepartmentNameValidator() 
	{
		RuleFor(x => x.DepId)
			.NotEmpty() // int empty???
			.WithMessage("Id can not be empty");

		RuleFor(x => x.NewName)
			.NotEmpty()
			.NotNull()
			.WithMessage("Name can not be empty");
	}
}
