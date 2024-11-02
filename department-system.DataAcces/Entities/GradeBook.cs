namespace department_system.DataAccess.Entities;

public class GradeBook : BaseEntity
{
	public required Student Student { get; set; }
	public required Teacher Teacher { get; set; }
	public required Discipline Discipline { get; set; }
	public required short Grade {  get; set; }
	public required DateTime AssessmentDay { get; set; }
}
