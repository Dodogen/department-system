using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.DepartmentDTOs;

public class GetDepartmentDto : BaseResponseModelDto
{
	public required string DepartmentName { get; set; }
	public List<Teacher> Teachers { get; set; } = new List<Teacher>();
	public List<Discipline> Disciplines { get; set; } = new List<Discipline>();	
}
