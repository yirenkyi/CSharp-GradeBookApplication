﻿using System;
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
            gradeList.Sort();
            int threshold = (int)Math.Ceiling(gradeList.Count * 0.2);

            if (averageGrade >= gradeList[threshold -1] )
            {
                return 'A';
            }
            if (averageGrade >= gradeList[(threshold -1)*2])
            {
                return 'B';
            }
            if (averageGrade >= gradeList[(threshold - 1) * 3])
            {
                return 'C';
            }
            if((averageGrade >= gradeList[(threshold - 1) * 4]))
            {
                return 'D';
            }
                return 'F';

           
        }


    }
}
