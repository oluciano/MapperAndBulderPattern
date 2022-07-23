namespace MapperAndBulderPattern
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for mapping <typeparamref name="TTarget" />.
    /// </summary>
    /// <typeparam name="TTarget">Represents the target that will be mapped.</typeparam>
    public interface IAsyncMapper<in TTarget>
        where TTarget : class
    {
        /// <summary>
        /// Map <typeparamref name="TTarget" />.
        /// </summary>
        /// <param name="target">Represents the target that will be mapped.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task MapAsync(TTarget target, CancellationToken cancellationToken = default);
    }
}
