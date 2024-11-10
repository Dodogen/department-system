using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.GradeBookDTOs;

public class GetGradeBookNotesByDateDto
{
	public required DateTime AssesmentDate {  get; set; }
	public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
}
