using System.Linq;

namespace Avalonia.NETCoreMVVMApp5.ModelImpl;

public class Grade
{
    public int GradeId { get; set; }
    public string Year { get; set; } 
    public int Rating { get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public virtual Student? Student => 
        ModelManager.Students.FirstOrDefault(s => s.StudentId == StudentId);
    public virtual Subject? Subject => 
        ModelManager.Subjects.FirstOrDefault(s => s.SubjectId == SubjectId);
}