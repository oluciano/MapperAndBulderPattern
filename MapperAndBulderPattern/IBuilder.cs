namespace MapperAndBulderPattern
{
    /// <summary>
    /// The Wrapper to centralize Builder dependency injection.
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" />.
        /// </summary>
        /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        TOutput Build<TOutput>();

        /// <summary>
        /// Interface to create an <typeparamref name="TOutput" /> given an <typeparamref name="TInput" />.
        /// </summary>
        /// <typeparam name="TInput">Represents the type of value that will be given.</typeparam>
        /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
        /// <param name="input">Input value.</param>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        TOutput Build<TInput, TOutput>(TInput input)
            where TInput : notnull;

        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" /> given an <paramref name="input1" />, <paramref name="input2"/>.
        /// </summary>
        /// <typeparam name="TInput1">Represents the type of the first input value.</typeparam>
        /// <typeparam name="TInput2">Represents the type of the second input value.</typeparam>
        /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
        /// <param name="input1">First input value.</param>
        /// <param name="input2">Second input value.</param>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        TOutput Build<TInput1, TInput2, TOutput>(TInput1 input1, TInput2 input2)
            where TInput1 : notnull
            where TInput2 : notnull;

        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" /> given an <paramref name="input1" />, <paramref name="input2" />
        /// and <paramref name="input3" />.
        /// </summary>
        /// <typeparam name="TInput1">Represents the type of the first input value.</typeparam>
        /// <typeparam name="TInput2">Represents the type of the second input value.</typeparam>
        /// <typeparam name="TInput3">Represents the type of the third input value.</typeparam>
        /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
        /// <param name="input1">First input value.</param>
        /// <param name="input2">Second input value.</param>
        /// <param name="input3">Third input value.</param>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        TOutput Build<TInput1, TInput2, TInput3, TOutput>(TInput1 input1, TInput2 input2, TInput3 input3)
            where TInput1 : notnull
            where TInput2 : notnull
            where TInput3 : notnull;
    }
}
