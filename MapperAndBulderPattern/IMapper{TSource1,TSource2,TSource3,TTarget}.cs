namespace MapperAndBulderPattern
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Interface for mapping a <typeparamref name="TSource1" />, and <typeparamref name="TSource2" /> and <typeparamref name="TSource3" />
    /// into <typeparamref name="TTarget" />.
    /// </summary>
    /// <typeparam name="TSource1">Represents the first source type.</typeparam>
    /// <typeparam name="TSource2">Represents the the second source type.</typeparam>
    /// <typeparam name="TSource3">Represents the the third source type.</typeparam>
    /// <typeparam name="TTarget">Represents the type of the target that will be mapped.</typeparam>
    [SuppressMessage("", "S2436:Types and methods should not have too many generic parameters", Justification = "Interface for mapping objects")]
    public interface IMapper<in TSource1, in TSource2, in TSource3, in TTarget>
        where TSource1 : notnull
        where TSource2 : notnull
        where TSource3 : notnull
        where TTarget : class
    {
        /// <summary>
        /// Map <typeparamref name="TSource1" />, <typeparamref name="TSource2" /> and <typeparamref name="TSource3" />
        /// into a <typeparamref name="TTarget" />.
        /// </summary>
        /// <param name="source1">The first source for the mapper.</param>
        /// <param name="source2">The second source for the mapper.</param>
        /// <param name="source3">The third source for the mapper.</param>
        /// <param name="target">The value that will be mapped into.</param>
        void Map(TSource1 source1, TSource2 source2, TSource3 source3, TTarget target);
    }
}
