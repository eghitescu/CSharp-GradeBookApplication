namespace GradeBook.GradeBooks
{
    using System;
    using System.Linq;

    public class RankedGradeBook : BaseGradeBook
    {
        /// <inheritdoc />
        public RankedGradeBook(string name)
            : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if ( this.Students == null || this.Students.Count < 5)
                throw new InvalidOperationException();
            if (averageGrade == 0)
                return 'F';
            var biggerGradesCount = this.Students.Select(s => s.AverageGrade).Where( g => g>averageGrade).Count();
            var percentage = 100d * biggerGradesCount / this.Students.Count;
            var position = (int)Math.Ceiling(percentage / 20);
            return (char)((int)'A' + position);
        }


    }
}