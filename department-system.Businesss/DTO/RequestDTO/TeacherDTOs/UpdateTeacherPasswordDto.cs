namespace department_system.Business.DTO.RequestDTO.TeacherDTOs;

public class UpdateTeacherPasswordDto
{
	public int TeacherId { get; set; }
	public required	string OldPassword { get; set; }
	public required	string NewPassword { get; set; }
}
