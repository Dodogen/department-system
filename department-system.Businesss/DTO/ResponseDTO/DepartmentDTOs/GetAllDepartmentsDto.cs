using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.DepartmentDTOs;

public class GetAllDepartmentsDto
{
	public List<Department> Departments { get; set; } = new List<Department>();
}
