namespace MapperAndBulderPattern
{
    /// <summary>
    /// Interface to create an <typeparamref name="TOutput" /> given an <typeparamref name="TInput" />.
    /// </summary>
    /// <typeparam name="TInput">Represents the type of value that will be given.</typeparam>
    /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
    public interface IBuilder<in TInput, out TOutput>
        where TInput : notnull
    {
        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" /> given an <paramref name="input" />.
        /// </summary>
        /// <param name="input">Input value.</param>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        TOutput Build(TInput input);
    }
}
