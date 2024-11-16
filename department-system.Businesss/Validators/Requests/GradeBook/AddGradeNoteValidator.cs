using department_system.Business.DTO.RequestDTO.GradeBookDTOs;
using department_system.DataAccess.Entities;
using FluentValidation;

namespace department_system.Business.Validators.Requests.GradeBookValidators;

public class AddGradeNoteValidator : AbstractValidator<AddGradeNoteDto>
{
	public AddGradeNoteValidator()
	{
		RuleFor(x => x.Student)
			.NotNull()
			.WithMessage("Student can not be null");

		RuleFor(x => x.Teacher)
			.NotNull()
			.WithMessage("Teacher can not be null");

		RuleFor(x => x.Discipline)
			.NotNull()
			.WithMessage("Discipline can not be null");

		RuleFor(x => (int)x.Grade)
			.GreaterThan(-1)
			.LessThan(11)
			.WithMessage("Grade must be in [0..10] range");

		RuleFor(x => x.AssessmentDay);
	}
}
