namespace MapperAndBulderPattern
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for mapping a <typeparamref name="TSource1" /> and <typeparamref name="TSource2" /> into <typeparamref name="TTarget" />.
    /// </summary>
    /// <typeparam name="TSource1">Represents the first source type.</typeparam>
    /// <typeparam name="TSource2">Represents the the second source type.</typeparam>
    /// <typeparam name="TTarget">Represents the type of the target that will be mapped.</typeparam>
    [SuppressMessage("", "S2436:Types and methods should not have too many generic parameters", Justification = "Interface for mapping objects")]
    public interface IAsyncMapper<in TSource1, in TSource2, in TTarget>
        where TSource1 : notnull
        where TSource2 : notnull
        where TTarget : class
    {
        /// <summary>
        /// Map <typeparamref name="TSource1" /> and <typeparamref name="TSource2" /> into a <typeparamref name="TTarget" />.
        /// </summary>
        /// <param name="source1">The first source for the mapper.</param>
        /// <param name="source2">The second source for the mapper.</param>
        /// <param name="target">The value that will be mapped into.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task MapAsync(TSource1 source1, TSource2 source2, TTarget target, CancellationToken cancellationToken = default);
    }
}
