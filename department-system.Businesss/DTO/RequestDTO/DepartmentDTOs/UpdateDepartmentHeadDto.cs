using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.RequestDTO.DepartmentDTOs;

public class UpdateDepartmentHeadDto
{
    public int DepId { get; set; }
    public required Teacher NewDepartmentHead { get; set; }
}
