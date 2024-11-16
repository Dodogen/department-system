using department_system.Business.DTO.RequestDTO.DisciplineDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.DisciplineValidators;

public class AddDisciplineValidator : AbstractValidator<AddDisciplineDto>
{
	public AddDisciplineValidator()
	{
		RuleFor(x => x.DepartmentId)
			.NotEmpty()
			.WithMessage("Id can not be null");

		RuleFor(x => x.Name)
			.NotNull()
			.NotEmpty()
			.WithMessage("Name can not be null or empty");
	}
}
