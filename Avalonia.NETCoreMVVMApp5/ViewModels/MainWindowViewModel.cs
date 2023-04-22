using System.Linq;
using Avalonia.NETCoreMVVMApp5.ModelImpl;

namespace Avalonia.NETCoreMVVMApp5.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Test = ModelManager.Students.ElementAt(0).Grades.ElementAt(0).Subject.Name;
        }

        private string Test = "";
        public string Greeting => Test;
    }
}