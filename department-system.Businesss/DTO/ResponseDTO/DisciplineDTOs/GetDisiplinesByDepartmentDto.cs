using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.DisciplineDTOs;

public class GetDisciplinesByDepartmentDto
{
	public required Department Department { get; set; }
	public List<Discipline> Disciplines { get; set; } = new List<Discipline>();
}
