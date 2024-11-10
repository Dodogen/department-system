using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.DisciplineDTOs;

public class GetAllDisciplinesDto
{
	public List<Discipline> Disciplines { get; set; } = new List<Discipline>();
}
