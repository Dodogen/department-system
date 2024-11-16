using department_system.Business.DTO.RequestDTO.TeacherDTOs;
using FluentValidation;

namespace department_system.Business.Validators.Requests.TeacherValidators;

public class UpdateTeacherDepartmentValidator : AbstractValidator<UpdateTeacherDepartmentDto>
{
	public UpdateTeacherDepartmentValidator()
	{
		RuleFor(x => x.TeacherId)
			.NotEmpty()
			.WithMessage("Id can not be null");

		RuleFor(x => x.NewDepartment)
			.NotNull()
			.WithMessage("Department can not be null or empty");
	}
}
