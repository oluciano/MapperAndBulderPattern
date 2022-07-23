namespace MapperAndBulderPattern
{
    /// <summary>
    /// The Wrapper to centralize Mapper dependency injection.
    /// </summary>
    public interface IMapper
    {
        /// <summary>
        /// Map <typeparamref name="TTarget" />.
        /// </summary>
        /// <typeparam name="TTarget">Represents the type target that will be mapped.</typeparam>
        /// <param name="target">Represents the target that will be mapped.</param>
        void Map<TTarget>(TTarget target)
            where TTarget : class;

        /// <summary>
        /// Map <typeparamref name="TSource" /> into a <typeparamref name="TTarget" />.
        /// </summary>
        /// <typeparam name="TSource">Represents the source type.</typeparam>
        /// <typeparam name="TTarget">Represents the target type.</typeparam>
        /// <param name="source">The source for the mapper.</param>
        /// <param name="target">The value that will be mapped into.</param>
        void Map<TSource, TTarget>(TSource source, TTarget target)
            where TSource : notnull
            where TTarget : class;

        /// <summary>
        /// Map <typeparamref name="TSource1" /> and <typeparamref name="TSource2" /> into a <typeparamref name="TTarget" />.
        /// </summary>
        /// <typeparam name="TSource1">Represents the first source type.</typeparam>
        /// <typeparam name="TSource2">Represents the the second source type.</typeparam>
        /// <typeparam name="TTarget">Represents the type of the target that will be mapped.</typeparam>
        /// <param name="source1">The first source for the mapper.</param>
        /// <param name="source2">The second source for the mapper.</param>
        /// <param name="target">The value that will be mapped into.</param>
        void Map<TSource1, TSource2, TTarget>(TSource1 source1, TSource2 source2, TTarget target)
            where TSource1 : notnull
            where TSource2 : notnull
            where TTarget : class;

        /// <summary>
        /// Map <typeparamref name="TSource1" />, <typeparamref name="TSource2" /> and <typeparamref name="TSource3" />
        /// into a <typeparamref name="TTarget" />.
        /// </summary>
        /// <typeparam name="TSource1">Represents the first source type.</typeparam>
        /// <typeparam name="TSource2">Represents the the second source type.</typeparam>
        /// <typeparam name="TSource3">Represents the the third source type.</typeparam>
        /// <typeparam name="TTarget">Represents the type of the target that will be mapped.</typeparam>
        /// <param name="source1">The first source for the mapper.</param>
        /// <param name="source2">The second source for the mapper.</param>
        /// <param name="source3">The third source for the mapper.</param>
        /// <param name="target">The value that will be mapped into.</param>
        void Map<TSource1, TSource2, TSource3, TTarget>(TSource1 source1, TSource2 source2, TSource3 source3, TTarget target)
            where TSource1 : notnull
            where TSource2 : notnull
            where TSource3 : notnull
            where TTarget : class;
    }
}
