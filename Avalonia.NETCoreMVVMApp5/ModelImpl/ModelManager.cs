using System.Collections.Generic;

namespace Avalonia.NETCoreMVVMApp5.ModelImpl;

public static class ModelManager
{
    public static List<Grade> Grades
    {
        get
        {
            var grades = new List<Grade>();
            var ctx = new YoloContext();
            foreach (var gr in ctx.grade)
            {
                var grade = new Grade();
                grade.GradeId = gr.gradeid;
                grade.Rating = gr.ratings;
                grade.Year = gr.yeargrade;
                grade.StudentId = gr.idstudents;
                grade.SubjectId = gr.idsubject;
                grades.Add(grade);
            }
            return grades;
        }
    }
    
    public static List<Student> Students
    {
        get
        {
            var students = new List<Student>();
            var ctx = new YoloContext();
            foreach (var st in ctx.students)
            {
                var student = new Student();
                student.StudentId = st.studentsid;
                student.Birthday = st.birthday;
                student.Course = st.course;
                student.Group = st.grope;
                student.FirstName = st.firstname;
                student.LastName = st.lastname;
                student.MiddleName = st.patronymic;
                student.YearAdmission = st.yearadmission;
                students.Add(student);
            }
            return students;
        }
    }
    
    public static List<Subject> Subjects
    {
        get
        {
            var subjects = new List<Subject>();
            var ctx = new YoloContext();
            foreach (var sj in ctx.subject)
            {
                var subject = new Subject();
                subject.SubjectId = sj.subjectid;
                subject.Name = sj.namesubject;
                subjects.Add(subject);
            }
            return subjects;
        }
    }
    
}