using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.DisciplineDTOs;

public class GetDisciplineDto : BaseResponseModelDto
{
	public required string DisciplineName { get; set; }
	public required Department Department{ get; set; }
	public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
}
