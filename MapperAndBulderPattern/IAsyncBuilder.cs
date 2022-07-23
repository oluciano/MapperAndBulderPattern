namespace MapperAndBulderPattern
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Wrapper to centralize IAsyncBuilder dependency injection.
    /// </summary>
    public interface IAsyncBuilder
    {
        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" />.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        Task<TOutput> BuildAsync<TOutput>(CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" /> given an <paramref name="input" />.
        /// </summary>
        /// <param name="input">Input value.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <typeparam name="TInput">Represents the type of value that will be given.</typeparam>
        /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        Task<TOutput> BuildAsync<TInput, TOutput>(
            TInput input,
            CancellationToken cancellationToken = default)
            where TInput : notnull;

        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" /> given an <paramref name="input1" /> and <paramref name="input2" />.
        /// </summary>
        /// <param name="input1">First input value.</param>
        /// <param name="input2">Second input value.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <typeparam name="TInput1">Represents the type of the first input value.</typeparam>
        /// <typeparam name="TInput2">Represents the type of the second input value.</typeparam>
        /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        Task<TOutput> BuildAsync<TInput1, TInput2, TOutput>(
            TInput1 input1,
            TInput2 input2,
            CancellationToken cancellationToken = default)
            where TInput1 : notnull
            where TInput2 : notnull;

        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" /> given an <paramref name="input1" />, <paramref name="input2" />
        /// and <paramref name="input3" />.
        /// </summary>
        /// <param name="input1">First input value.</param>
        /// <param name="input2">Second input value.</param>
        /// <param name="input3">Third input value.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive
        ///     notice of cancellation.
        /// </param>
        /// <typeparam name="TInput1">Represents the type of the first input value.</typeparam>
        /// <typeparam name="TInput2">Represents the type of the second input value.</typeparam>
        /// <typeparam name="TInput3">Represents the type of the third input value.</typeparam>
        /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        Task<TOutput> BuildAsync<TInput1, TInput2, TInput3, TOutput>(
            TInput1 input1,
            TInput2 input2,
            TInput3 input3,
            CancellationToken cancellationToken = default)
            where TInput1 : notnull
            where TInput2 : notnull
            where TInput3 : notnull;
    }
}
