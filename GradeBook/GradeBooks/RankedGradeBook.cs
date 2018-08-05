namespace GradeBook.GradeBooks
{
    using System;
    using System.Linq;

    public class RankedGradeBook : BaseGradeBook
    {
        /// <inheritdoc />
        public RankedGradeBook(string name, bool isWeighted)
            : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if ( NotEnoughStudents())
                throw new InvalidOperationException();
            if (averageGrade == 0)
                return 'F';
            var biggerGradesCount = this.Students.Select(s => s.AverageGrade).Where( g => g>averageGrade).Count();
            var percentage = 100d * biggerGradesCount / this.Students.Count;
            var position = (int)Math.Ceiling(percentage / 20);
            return (char)((int)'A' + position);
        }

        private bool NotEnoughStudents()
        {
            return this.Students == null || this.Students.Count < 5;
        }

        public override void CalculateStatistics()
        {
            if (NotEnoughStudents())
            {
                Console.WriteLine(
                    "Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }

            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (NotEnoughStudents())
            {
                Console.WriteLine(
                    "Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }
}