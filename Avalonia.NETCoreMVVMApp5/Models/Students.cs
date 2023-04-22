using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Avalonia.NETCoreMVVMApp5.Models;

public class Students
{
    [Key]
    public int studentsid { get; set; }
    public string lastname { get; set; }
    public string firstname { get; set; }
    public string patronymic { get; set; }
    public DateOnly birthday { get; set; }
    public DateOnly yearadmission { get; set; }
    public string grope { get; set; }
    public int course { get; set; }
    public virtual List<Grade> grades { get; set; }
}