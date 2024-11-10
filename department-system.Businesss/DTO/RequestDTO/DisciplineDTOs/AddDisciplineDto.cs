namespace department_system.Business.DTO.RequestDTO.DisciplineDTOs;

public class AddDisciplineDto
{
	public required string Name { get; set; }
	public int DepartmentId{ get; set; }
}
