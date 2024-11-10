using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.GradeBookDTOs;

public class GetGradeBookNoteDto : BaseResponseModelDto
{
	public required Student Student { get; set; }
	public required Teacher Teacher { get; set; }
	public required Discipline Discipline { get; set; }
	public required short Grade { get; set; }
	public required DateTime AssessmentDate { get; set; }
}
