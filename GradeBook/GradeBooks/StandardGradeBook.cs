namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        /// <inheritdoc />
        public StandardGradeBook(string name)
            : base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}