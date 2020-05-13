using GradeBook.Enums;
using System;


namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        int index = 5;
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count <= 5)
            {
                throw new InvalidOperationException();
            }
            if (averageGrade >= 80)
                return 'A';
            else if (averageGrade >= 60)
                return 'B';
            else if (averageGrade >= 40)
                return 'C';
            else if (averageGrade >= 20)
                return 'D';
            else
                return 'F';
        }
    }
}