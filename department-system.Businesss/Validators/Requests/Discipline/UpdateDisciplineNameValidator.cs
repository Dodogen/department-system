using department_system.Business.DTO.RequestDTO.DisciplineDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.DisciplineValidators;

public class UpdateDisciplineNameValidator : AbstractValidator<UpdateDisciplineNameDto>
{
	public UpdateDisciplineNameValidator()
	{
		RuleFor(x => x.DisId)
			.NotEmpty()
			.WithMessage("Id can not be null");

		RuleFor(x => x.NewName)
			.NotNull()
			.NotEmpty()
			.WithMessage("Name can not be null or empty");
	}
}
