using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOffice
{
    class Exam
    {
        private string _examName;
        private DateTime _applyDate;
        private DateTime _eventDate;
        private Professor _professor;
        private Assistant _assistant;
        private int _grade;
        private bool _isGraded = false;

        public Exam(string name, DateTime eventDate, Professor professor, Assistant assistant)
        {//ođe privatnim poljima dodeljujemo parametre prilikom inicijalizacije.
            _examName = name;
            _applyDate = DateTime.Now; //postavljanje trenutnog vremena
            _eventDate = eventDate;
            _professor = professor;
            _assistant = assistant;
        }

        public void GradeExam(int grade) //ocena ispita
        {
            if (_isGraded == true) //failsafe
            {
                Console.WriteLine("Exam is already graded");
                return;
            }
            if(grade < 5 || grade > 10) //2th failsafe
            {
                Console.WriteLine("Invalid grade");
                return;
            }
             
            _grade = grade;
            _isGraded = true; //ako su svi preduslovi ispunjeni
        }
        public bool IsExamGraded()
        {
            return _isGraded;
        }
        public string GetExamName() 
        {
            return _examName;
        }

        public DateTime GetExamApplyDate()
        {
            return _applyDate;
        }
        public DateTime GetExamEventDate()
        {
            return _eventDate;
        }

        public Professor GetExamProfessor() 
        {
            return _professor;
        }

        public Assistant GetExamAssistant()
        {
            return _assistant;
        }

        public int GetExamGrade()
        {
            return _grade;
        }
    }
}
