using department_system.Business.DTO.RequestDTO.GradeBookDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.GradeBookValidators;

public class UpdateGradeValidator : AbstractValidator<UpdateGradeDto>
{
	public UpdateGradeValidator()
	{
		RuleFor(x => x.NoteId)
			.NotEmpty()
			.WithMessage("Id can not be null");

		RuleFor(x => x.NewGrade)
			.GreaterThan(-1)
			.LessThan(11)
			.WithMessage("Grade must be in [0..10] range");
	}
}
