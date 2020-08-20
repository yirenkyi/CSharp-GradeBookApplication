using System;
using System.Collections.Generic;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count<5)
            {
                throw new InvalidOperationException("Ranked Grading requires at least 5 students");

            }

            var gradeList = new List<double>();

            foreach (var student in Students)
            {
                gradeList.Add(student.AverageGrade);
            }
            gradeList.Reverse();
            int threshold = (int)Math.Ceiling(Students.Count * 0.2);


                return 'F';

           
        }


    }
}
