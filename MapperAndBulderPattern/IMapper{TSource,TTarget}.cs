namespace MapperAndBulderPattern
{
    /// <summary>
    /// Interface for mapping a <typeparamref name="TSource" /> into <typeparamref name="TTarget" />.
    /// </summary>
    /// <typeparam name="TSource">Represents the source type.</typeparam>
    /// <typeparam name="TTarget">Represents the target type.</typeparam>
    public interface IMapper<in TSource, in TTarget>
        where TSource : notnull
        where TTarget : class
    {
        /// <summary>
        /// Map <typeparamref name="TSource" /> into a <typeparamref name="TTarget" />.
        /// </summary>
        /// <param name="source">The source for the mapper.</param>
        /// <param name="target">The value that will be mapped into.</param>
        void Map(TSource source, TTarget target);
    }
}
