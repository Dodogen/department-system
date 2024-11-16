﻿using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.GradeBookDTOs;

public class GetGradeBookNotesByDisciplineDto
{
	public required Discipline Discipline { get; set; }
	public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
}