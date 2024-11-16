using department_system.Business.DTO.RequestDTO.DepartmentDTOs;
using department_system.Business.Validators.Constants;
using FluentValidation;

namespace department_system.Business.Validators.Requests.DepartmentValidators;

public class AddDepartmentValidator : AbstractValidator<AddDepartmentDto>
{
	public AddDepartmentValidator()
	{
		RuleFor(x => x.DepartmentName)
			.NotEmpty()
			.NotNull()
			.MinimumLength(1)
			.WithMessage("Name can not be empty")
			.MaximumLength(ValidatorRestricts.NAMING_MAX_LEN)
			.WithMessage("Name is too long");

		RuleFor(x => x.DepartmentHead)
			.NotNull()
			.WithMessage("Department must already have Head");
	}
}
