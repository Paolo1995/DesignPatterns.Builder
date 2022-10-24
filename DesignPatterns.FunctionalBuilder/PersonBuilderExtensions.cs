namespace DesignPatterns.FunctionalBuilder
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAsA(this PersonBuilder builder, string position) => builder.Do(p => p.Position = position);
    }
}
