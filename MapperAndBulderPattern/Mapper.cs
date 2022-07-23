namespace MapperAndBulderPattern
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Microsoft.Extensions.DependencyInjection;

    /// <inheritdoc/>
    [ExcludeFromCodeCoverage]
    [SuppressMessage("Microsoft.Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Instantiated through reflection")]
    internal sealed class Mapper : IMapper
    {
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        ///   Initializes a new instance of the <see cref="Mapper"/> class.
        /// </summary>
        /// <param name="serviceProvider">The ServiceProvider interface.</param>
        public Mapper(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <inheritdoc/>
        void IMapper.Map<TTarget>(TTarget target)
        {
            _ = target ?? throw new ArgumentNullException(nameof(target));

            this.serviceProvider
                .GetRequiredService<IMapper<TTarget>>()
                .Map(target);
        }

        /// <inheritdoc/>
        void IMapper.Map<TSource, TTarget>(
            TSource source,
            TTarget target)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));
            _ = target ?? throw new ArgumentNullException(nameof(target));

            this.serviceProvider
                .GetRequiredService<IMapper<TSource, TTarget>>()
                .Map(source, target);
        }

        /// <inheritdoc/>
        void IMapper.Map<TSource1, TSource2, TTarget>(
            TSource1 source1,
            TSource2 source2,
            TTarget target)
        {
            _ = source1 ?? throw new ArgumentNullException(nameof(source1));
            _ = source2 ?? throw new ArgumentNullException(nameof(source2));
            _ = target ?? throw new ArgumentNullException(nameof(target));

            this.serviceProvider
                .GetRequiredService<IMapper<TSource1, TSource2, TTarget>>()
                .Map(source1, source2, target);
        }

        /// <inheritdoc/>
        void IMapper.Map<TSource1, TSource2, TSource3, TTarget>(
            TSource1 source1,
            TSource2 source2,
            TSource3 source3,
            TTarget target)
        {
            _ = source1 ?? throw new ArgumentNullException(nameof(source1));
            _ = source2 ?? throw new ArgumentNullException(nameof(source2));
            _ = source3 ?? throw new ArgumentNullException(nameof(source3));

            this.serviceProvider
                .GetRequiredService<IMapper<TSource1, TSource2, TSource3, TTarget>>()
                .Map(source1, source2, source3, target);
        }
    }
}
