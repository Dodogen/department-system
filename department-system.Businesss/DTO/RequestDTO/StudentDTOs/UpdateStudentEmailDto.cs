namespace department_system.Business.DTO.RequestDTO.StudentDTOs;

public class UpdateStudentEmailDto
{
	public int StudId { get; set; }
	public required string OldEmail { get; set; }
	public required string NewEmail { get; set; }
}
