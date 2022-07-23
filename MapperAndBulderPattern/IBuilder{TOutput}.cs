namespace MapperAndBulderPattern
{
    /// <summary>
    /// Interface to create an <typeparamref name="TOutput" />.
    /// </summary>
    /// <typeparam name="TOutput">Represents the type of value that will be returned.</typeparam>
    public interface IBuilder<out TOutput>
    {
        /// <summary>
        /// Creates a new instance of <typeparamref name="TOutput" />.
        /// </summary>
        /// <returns>New instance of the <typeparamref name="TOutput" />.</returns>
        TOutput Build();
    }
}
