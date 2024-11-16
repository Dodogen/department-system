using department_system.Business.DTO.RequestDTO.DisciplineDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.DisciplineValidators;

public class UpdateDicsiplineDepartmentValidator : AbstractValidator<UpdateDisciplineDepartmentDto>
{
	public UpdateDicsiplineDepartmentValidator()
	{
		RuleFor(x => x.DisId)
			.NotEmpty()
			.WithMessage("Id can not be null");

		RuleFor(x => x.NewDepartment)
			.NotNull()
			.WithMessage("Department can not be null or empty");

	}
}
