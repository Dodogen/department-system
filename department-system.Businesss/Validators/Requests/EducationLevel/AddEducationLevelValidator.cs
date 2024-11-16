using department_system.Business.DTO.RequestDTO.EducationLevelDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.EducationLevelValidators;

public class AddEducationLevelValidator : AbstractValidator<AddEducationLevelDto>
{
	public AddEducationLevelValidator()
	{
		RuleFor(x => x.Name)
			.NotNull()
			.NotEmpty()
			.WithMessage("Name can not be null or empty");
	}
}
