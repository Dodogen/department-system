using department_system.Business.DTO.RequestDTO.TeacherDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.TeacherValidators;

public class AddTeacherValidator : AbstractValidator<AddTeacherDto>
{
	public AddTeacherValidator()
	{
		RuleFor(x => x.Name)
	.NotNull()
	.NotEmpty()
	.WithMessage("Name can not be null or empty");

		RuleFor(x => x.Surname)
			.NotNull()
			.NotEmpty()
			.WithMessage("Surname can not be null or empty");

		RuleFor(x => x.Email)
			.NotNull()
			.NotEmpty()
			.WithMessage("Email can not be null or empty");

		RuleFor(x => x.Password)
			.NotNull()
			.NotEmpty()
			.WithMessage("Password can not be null or empty");
	}
}
