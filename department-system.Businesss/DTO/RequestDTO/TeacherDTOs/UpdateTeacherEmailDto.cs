namespace department_system.Business.DTO.RequestDTO.TeacherDTOs;

public class UpdateTeacherEmailDto
{
	public int TeacherId { get; set; }
	public required string OldEmail { get; set; }
	public required string NewEmail { get; set; }
}
