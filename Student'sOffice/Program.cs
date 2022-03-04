using System;

namespace StudentsOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor("DumbBellDoor");
            Assistant assistant = new Assistant("Galadrijela");
            

            Exam onTimeExam = new Exam("Primenjeno kvantno likovno",new DateTime(2021,12,21), professor, assistant);
            Exam outOffTimeExam = new Exam("Programiranje na fiksnom telefonu",new DateTime(2021,12,15), professor, assistant);
            

            Student student = new Student();
            student.ApplyForExam(onTimeExam);
            student.ApplyForExam(outOffTimeExam);

            onTimeExam.GradeExam(10);
            student.AddPassedExam(onTimeExam);
            student.ApplyForExam(onTimeExam);
            student.AddPassedExam(onTimeExam);

            

            Console.WriteLine(student.GetAverageGrade());
        }
    }
}
