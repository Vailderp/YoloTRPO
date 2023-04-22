using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Avalonia.NETCoreMVVMApp5.Models;

public class Subject
{
    [Key]
    public int subjectid { get; set; }
    public string namesubject { get; set; }
    public virtual List<Grade> grades { get; set; }
}