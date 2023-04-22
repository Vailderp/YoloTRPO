using System.Collections.Generic;
using System.Linq;

namespace Avalonia.NETCoreMVVMApp5.ModelImpl;

public class Subject
{
    public int SubjectId { get; set; }
    public string Name { get; set; }
    public List<Grade> Grades =>
        ModelManager.Grades.Where(g => g.SubjectId == SubjectId).ToList();
}