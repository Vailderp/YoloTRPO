using System.ComponentModel.DataAnnotations;

namespace Avalonia.NETCoreMVVMApp5.Models;

public class Grade
{
    [Key]
    public int gradeid { get; set; }
    public string yeargrade { get; set; } 
    public int ratings { get; set; } 
    public int idstudents { get; set; } 
    public int idsubject { get; set; } 
    public virtual Students student { get; set; }
    public virtual Subject subject { get; set; }
}