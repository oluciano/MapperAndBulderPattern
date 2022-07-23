namespace MapperAndBulderPattern
{
    /// <summary>
    /// Interface for mapping <typeparamref name="TTarget" />.
    /// </summary>
    /// <typeparam name="TTarget">Represents the target that will be mapped.</typeparam>
    public interface IMapper<in TTarget>
        where TTarget : class
    {
        /// <summary>
        /// Map <typeparamref name="TTarget" />.
        /// </summary>
        /// <param name="target">Represents the target that will be mapped.</param>
        void Map(TTarget target);
    }
}
