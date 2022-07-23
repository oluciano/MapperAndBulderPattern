namespace MapperAndBulderPattern
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for mapping a <typeparamref name="TSource" /> into <typeparamref name="TTarget" />.
    /// </summary>
    /// <typeparam name="TSource">Represents the source type.</typeparam>
    /// <typeparam name="TTarget">Represents the target type.</typeparam>
    public interface IAsyncMapper<in TSource, in TTarget>
        where TSource : notnull
        where TTarget : class
    {
        /// <summary>
        /// Map <typeparamref name="TSource" /> into a <typeparamref name="TTarget" />.
        /// </summary>
        /// <param name="source">The source for the mapper.</param>
        /// <param name="target">The value that will be mapped into.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task MapAsync(TSource source, TTarget target, CancellationToken cancellationToken = default);
    }
}
