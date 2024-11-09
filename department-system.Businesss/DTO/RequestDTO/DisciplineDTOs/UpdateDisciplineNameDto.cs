namespace department_system.Business.DTO.RequestDTO.DisciplineDTOs;

public class UpdateDisciplineNameDto
{
	public int DisId { get; set; }
	public required string NewName { get; set; }
}
