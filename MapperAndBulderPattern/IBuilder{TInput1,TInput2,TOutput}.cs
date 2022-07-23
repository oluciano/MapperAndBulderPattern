namespace MapperAndBulderPattern
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Interface for creating an <typeparamref name="TOutput" /> given an <typeparamref name="TInput1" /> and <typeparamref name="TInput2" />.
    /// </summary>
    /// <typeparam name="TInput1">Represents the type of the first input value.</typeparam>
    /// <typeparam name="TInput2">Represents the type of the second input value.</typeparam>
    /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
    [SuppressMessage("", "S2436:Types and methods should not have too many generic parameters", Justification = "Interface for mapping objects")]
    public interface IBuilder<in TInput1, in TInput2, out TOutput>
        where TInput1 : notnull
        where TInput2 : notnull
    {
        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" /> given an <paramref name="input1" /> and <paramref name="input2" />.
        /// </summary>
        /// <param name="input1">First input value.</param>
        /// <param name="input2">Second input value.</param>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        TOutput Build(TInput1 input1, TInput2 input2);
    }
}
