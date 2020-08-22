﻿using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool check): base(name, check)
        {
            Type = GradeBookType.Standard;
        }

    }
}
