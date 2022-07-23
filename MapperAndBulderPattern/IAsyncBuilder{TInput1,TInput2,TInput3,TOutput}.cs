namespace MapperAndBulderPattern
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for creating an <typeparamref name="TOutput" /> given an <typeparamref name="TInput1" />, <typeparamref name="TInput2" />
    /// and <typeparamref name="TInput3" />.
    /// </summary>
    /// <typeparam name="TInput1">Represents the type of the first input value.</typeparam>
    /// <typeparam name="TInput2">Represents the type of the second input value.</typeparam>
    /// <typeparam name="TInput3">Represents the type of the third input value.</typeparam>
    /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
    [SuppressMessage("", "S2436:Types and methods should not have too many generic parameters", Justification = "Interface for mapping objects")]
    public interface IAsyncBuilder<in TInput1, in TInput2, in TInput3, TOutput>
        where TInput1 : notnull
        where TInput2 : notnull
        where TInput3 : notnull
    {
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
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        Task<TOutput> BuildAsync(TInput1 input1, TInput2 input2, TInput3 input3, CancellationToken cancellationToken = default);
    }
}
