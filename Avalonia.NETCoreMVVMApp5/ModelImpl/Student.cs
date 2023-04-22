using System;
using System.Collections.Generic;
using System.Linq;

namespace Avalonia.NETCoreMVVMApp5.ModelImpl;

public class Student
{
    public int StudentId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public DateOnly Birthday { get; set; }
    public DateOnly YearAdmission { get; set; }
    public string Group { get; set; }
    public int Course { get; set; }
    public List<Grade> Grades => 
        ModelManager.Grades.Where(g => g.StudentId == StudentId).ToList();
}