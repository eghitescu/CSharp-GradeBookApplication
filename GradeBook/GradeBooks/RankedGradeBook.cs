namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        /// <inheritdoc />
        public RankedGradeBook(string name)
            : base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}