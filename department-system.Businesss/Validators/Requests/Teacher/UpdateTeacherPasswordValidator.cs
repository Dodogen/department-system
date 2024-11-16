using department_system.Business.DTO.RequestDTO.TeacherDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.TeacherValidators;

public class UpdateTeacherPasswordValidator : AbstractValidator<UpdateTeacherPasswordDto>
{
	public UpdateTeacherPasswordValidator() 
	{
		RuleFor(x => x.TeacherId)
			.NotEmpty()
			.WithMessage("Id can not be null");

		RuleFor(x => x.NewPassword)
			.NotNull()
			.NotEmpty()
			.WithMessage("Password can not be null or empty")
			.NotEqual(x => x.OldPassword);

		RuleFor(x => x.OldPassword)
			.NotNull()
			.NotEmpty()
			.WithMessage("Password can not be null or empty");
	}
}
