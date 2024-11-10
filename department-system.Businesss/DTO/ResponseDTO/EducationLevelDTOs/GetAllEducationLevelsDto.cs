using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.EducationLevelDTOs;

public class GetAllEducationLevelsDto
{
	public List<EducationLevel> Levels { get; set; } = new List<EducationLevel>();
}
