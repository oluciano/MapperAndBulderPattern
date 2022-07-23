namespace MapperAndBulderPattern
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface to create an <typeparamref name="TOutput" /> given an <typeparamref name="TInput" />.
    /// </summary>
    /// <typeparam name="TInput">Represents the type of value that will be given.</typeparam>
    /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
    public interface IAsyncBuilder<in TInput, TOutput>
        where TInput : notnull
    {
        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" /> given an <paramref name="input" />.
        /// </summary>
        /// <param name="input">Input value.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        Task<TOutput> BuildAsync(TInput input, CancellationToken cancellationToken = default);
    }
}
