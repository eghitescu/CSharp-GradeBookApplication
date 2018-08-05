namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        /// <inheritdoc />
        public StandardGradeBook(string name, bool isWeighted)
            : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}