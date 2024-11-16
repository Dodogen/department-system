namespace department_system.Business.DTO.RequestDTO.DepartmentDTOs;

public class UpdateDepartmentNameDto
{
	public int DepId {  get; set; }
	public required string NewName { get; set; }
}
