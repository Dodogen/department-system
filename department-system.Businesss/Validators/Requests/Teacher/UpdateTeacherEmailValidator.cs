using department_system.Business.DTO.RequestDTO.TeacherDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.TeacherValidators;

public class UpdateTeacherEmailValidator : AbstractValidator<UpdateTeacherEmailDto>
{
	public UpdateTeacherEmailValidator() 
	{
		RuleFor(x => x.TeacherId)
			.NotEmpty()
			.WithMessage("Id can not be null");

		RuleFor(x => x.NewEmail)
			.NotNull()
			.NotEmpty()
			.WithMessage("Email can not be null or empty")
			.NotEqual(x => x.OldEmail);

		RuleFor(x => x.OldEmail)
			.NotNull()
			.NotEmpty()
			.WithMessage("Email can not be null or empty");
	}
}
