using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOffice
{
    class Student
    {
        private double _averageGrade;
        private List<Exam> _passedExams;
        private List<Exam> _appliedExams;
        private decimal _balance;

        public Student() //konstruktor
        {
            _passedExams = new List<Exam>();
            _appliedExams = new List<Exam>();
        }

        public void ApplyForExam(Exam exam)
        {
            if (_balance < 0) 
            {
                Console.WriteLine("Money balance is to low my liege");
            }
            
            TimeSpan timeToExam = exam.GetExamEventDate() - exam.GetExamApplyDate();

            if (timeToExam > new TimeSpan(2, 0, 0, 0)) 
            {
                _appliedExams.Add(exam);
                Console.WriteLine($"Exam is applied for, don't forget it is on: {exam.GetExamEventDate().Date.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine("To little to late...");
            }
        }
        public void AddPassedExam(Exam exam) 
        {
            if (_appliedExams.Contains(exam) == false) 
            {
                Console.WriteLine("Can't add exams that are not in applied list");
                return;
            }
            _passedExams.Add(exam);
            _appliedExams.Remove(exam);
            UpdateAverageGrade();
        }
        public Exam[] GetPassedExams()
        {
            Exam[] arr = new Exam[_passedExams.Count()];

            for (int i = 0; i < _passedExams.Count; i++)
            {
                arr[i] = _passedExams[i];
            }

            return arr;
        }
        public double GetAverageGrade()
        {
            return _averageGrade;
        }

        public void AddMoneyToBalance(decimal amount)
        {
            _balance += amount;
        }
        public void DeductMoneyFromBalance(decimal amount)
        {
            _balance -= amount;
        }
        public decimal GetBalance()
        {
            return _balance;
        }

        private void UpdateAverageGrade() 
        {
            if (_passedExams.Count == 0)
            {
                _averageGrade = 0;

                return;
            }
            double nextAvarageGrade = 0;
            foreach (Exam e in _passedExams)

            {
                nextAvarageGrade += e.GetExamGrade();
            }
            nextAvarageGrade /= _passedExams.Count();

            _averageGrade = nextAvarageGrade;
        }
    }
}
