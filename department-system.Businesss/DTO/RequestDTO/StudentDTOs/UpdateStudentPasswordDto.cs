namespace department_system.Business.DTO.RequestDTO.TeacherDTOs;

public class UpdateStudentPasswordDto
{
	public int StudId { get; set; }
	public required	string OldPassword { get; set; }
	public required	string NewPassword { get; set; }
}
