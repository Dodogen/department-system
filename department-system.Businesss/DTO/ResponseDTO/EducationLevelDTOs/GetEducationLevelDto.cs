using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.EducationLevelDTOs;

public class GetEducationLevelDto : BaseResponseModelDto
{
	public required string LevelName { get; set; }
	public List<Student> Students { get; set; } = new List<Student>();
}
