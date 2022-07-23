namespace MapperAndBulderPattern
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using Microsoft.Extensions.DependencyInjection;

    /// <inheritdoc/>
    [ExcludeFromCodeCoverage]
    internal sealed class AsyncMapper : IAsyncMapper
    {
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncMapper"/> class.
        /// </summary>
        /// <param name="serviceProvider">The ServiceProvider interface.</param>
        public AsyncMapper(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <inheritdoc/>
        void IAsyncMapper.MapAsync<TTarget>(
            TTarget target,
            CancellationToken cancellationToken)
        {
            _ = target ?? throw new ArgumentNullException(nameof(target));

            _ = this.serviceProvider
                .GetRequiredService<IAsyncMapper<TTarget>>()
                .MapAsync(target, cancellationToken);
        }

        /// <inheritdoc/>
        void IAsyncMapper.MapAsync<TSource, TTarget>(
            TSource source,
            TTarget target,
            CancellationToken cancellationToken)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));
            _ = target ?? throw new ArgumentNullException(nameof(target));

            _ = this.serviceProvider
                .GetRequiredService<IAsyncMapper<TSource, TTarget>>()
                .MapAsync(source, target, cancellationToken);
        }

        /// <inheritdoc/>
        void IAsyncMapper.MapAsync<TSource1, TSource2, TTarget>(
            TSource1 source1,
            TSource2 source2,
            TTarget target,
            CancellationToken cancellationToken)
        {
            _ = source1 ?? throw new ArgumentNullException(nameof(source1));
            _ = source2 ?? throw new ArgumentNullException(nameof(source2));
            _ = target ?? throw new ArgumentNullException(nameof(target));

            _ = this.serviceProvider
                .GetRequiredService<IAsyncMapper<TSource1, TSource2, TTarget>>()
                .MapAsync(source1, source2, target, cancellationToken);
        }

        /// <inheritdoc/>
        void IAsyncMapper.MapAsync<TSource1, TSource2, TSource3, TTarget>(
            TSource1 source1,
            TSource2 source2,
            TSource3 source3,
            TTarget target,
            CancellationToken cancellationToken)
        {
            _ = source1 ?? throw new ArgumentNullException(nameof(source1));
            _ = source2 ?? throw new ArgumentNullException(nameof(source2));
            _ = source3 ?? throw new ArgumentNullException(nameof(source3));
            _ = target ?? throw new ArgumentNullException(nameof(target));

            _ = this.serviceProvider
                .GetRequiredService<IAsyncMapper<TSource1, TSource2, TSource3, TTarget>>()
                .MapAsync(source1, source2, source3, target, cancellationToken);
        }
    }
}
