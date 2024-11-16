using department_system.Business.DTO.RequestDTO.DepartmentDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.DepartmentValidators;

public class UpdateDepartmentHeadValidator : AbstractValidator<UpdateDepartmentHeadDto>
{
	public UpdateDepartmentHeadValidator()
	{
		RuleFor(x => x.DepId)
			.NotEmpty()
			.WithMessage("Id can not be empty");

		RuleFor(x => x.NewDepartmentHead)
			.NotNull()
			.WithMessage("Teacher must be not null");
	}
}
