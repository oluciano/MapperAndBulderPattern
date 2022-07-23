namespace MapperAndBulderPattern
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface to create an <typeparamref name="TOutput" />.
    /// </summary>
    /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
    public interface IAsyncBuilder<TOutput>
    {
        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" />.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        Task<TOutput> BuildAsync(CancellationToken cancellationToken = default);
    }
}
