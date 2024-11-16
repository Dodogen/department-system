using department_system.Business.DTO.RequestDTO.StudentDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.StudentValidators;

public class AddStudentValidator : AbstractValidator<AddStudentDto>
{
	public AddStudentValidator()
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

		RuleFor(x => x.EducationLevel)
			.NotNull()
			.WithMessage("Level can not be null");

		RuleFor(x => x.Password)
			.NotNull()
			.NotEmpty()
			.WithMessage("Password can not be null or empty");

		RuleFor(x => x.Birthday)
			.NotNull()
			.WithMessage("Birthday can not be null")
			.LessThan(DateTime.Now)
			.WithMessage("Birthday can not be less than current time");		
	}
}
