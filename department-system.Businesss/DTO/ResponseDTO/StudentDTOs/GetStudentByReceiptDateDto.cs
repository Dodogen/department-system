using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.StudentDTOs;

public class GetStudentByReceiptDateDto
{
	public DateTime ReceiptDate { get; set; }
	public List<Student> Students { get; set; } = new List<Student>();
}
