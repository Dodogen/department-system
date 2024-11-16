using department_system.Business.DTO.RequestDTO.StudentDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.StudentValidators;

public class UpdateStudentEmailValidator : AbstractValidator<UpdateStudentEmailDto>
{
	public UpdateStudentEmailValidator()
	{
		RuleFor(x => x.StudId)
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
