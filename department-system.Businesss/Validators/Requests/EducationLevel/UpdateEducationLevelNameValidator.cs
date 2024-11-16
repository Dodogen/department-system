using department_system.Business.DTO.RequestDTO.EducationLevelDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.EducationLevelValidators;

public class UpdateEducationLevelNameValidator : AbstractValidator<UpdateEducationLevelNameDto>
{
	public UpdateEducationLevelNameValidator()
	{
		RuleFor(x => x.LevelId)
			.NotEmpty()
			.WithMessage("Id can not be null");

		RuleFor(x => x.NewName)
			.NotNull()
			.NotEmpty()
			.WithMessage("Name can not be null or empty");
	}
}
