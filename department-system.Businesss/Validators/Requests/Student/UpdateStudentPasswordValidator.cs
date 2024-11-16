using department_system.Business.DTO.RequestDTO.StudentDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.StudentValidators;

public class UpdateStudentPasswordValidator : AbstractValidator<UpdateStudentPasswordDto>
{
	public UpdateStudentPasswordValidator()
	{
		RuleFor(x => x.StudId)
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
