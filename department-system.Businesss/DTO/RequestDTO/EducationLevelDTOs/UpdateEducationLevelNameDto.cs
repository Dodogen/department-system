namespace department_system.Business.DTO.RequestDTO.EducationLevelDTOs;

public class UpdateEducationLevelNameDto
{
	public int LevelId { get; set; }
	public required string NewName { get; set; }
}
