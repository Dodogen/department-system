using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.TeacherDTOs;

public class GetAllTeachers
{
	public List<Teacher> Teachers { get; set; } = new List<Teacher>();
}
