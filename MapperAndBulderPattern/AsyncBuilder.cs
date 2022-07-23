namespace MapperAndBulderPattern
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Threading.Tasks;

    /// <inheritdoc/>
    [ExcludeFromCodeCoverage]
    [SuppressMessage("Microsoft.Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Instantiated through reflection")]
    internal sealed class AsyncBuilder : IAsyncBuilder
    {
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncBuilder"/> class.
        /// </summary>
        /// <param name="serviceProvider">The ServiceProvider interface.</param>
        public AsyncBuilder(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <inheritdoc/>
        Task<TOutput> IAsyncBuilder.BuildAsync<TOutput>(CancellationToken cancellationToken)
        {
            return this.serviceProvider
                .GetRequiredService<IAsyncBuilder<TOutput>>()
                .BuildAsync(cancellationToken);
        }

        /// <inheritdoc/>
        Task<TOutput> IAsyncBuilder.BuildAsync<TInput, TOutput>(
            TInput input,
            CancellationToken cancellationToken)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));

            return this.serviceProvider
                .GetRequiredService<IAsyncBuilder<TInput, TOutput>>()
                .BuildAsync(input, cancellationToken);
        }

        /// <inheritdoc/>
        Task<TOutput> IAsyncBuilder.BuildAsync<TInput1, TInput2, TOutput>(
            TInput1 input1,
            TInput2 input2,
            CancellationToken cancellationToken)
        {
            _ = input1 ?? throw new ArgumentNullException(nameof(input1));
            _ = input2 ?? throw new ArgumentNullException(nameof(input2));

            return this.serviceProvider
                .GetRequiredService<IAsyncBuilder<TInput1, TInput2, TOutput>>()
                .BuildAsync(input1, input2, cancellationToken);
        }

        /// <inheritdoc/>
        Task<TOutput> IAsyncBuilder.BuildAsync<TInput1, TInput2, TInput3, TOutput>(
            TInput1 input1,
            TInput2 input2,
            TInput3 input3,
            CancellationToken cancellationToken)
        {
            _ = input1 ?? throw new ArgumentNullException(nameof(input1));
            _ = input2 ?? throw new ArgumentNullException(nameof(input2));
            _ = input3 ?? throw new ArgumentNullException(nameof(input3));

            return this.serviceProvider
                .GetRequiredService<IAsyncBuilder<TInput1, TInput2, TInput3, TOutput>>()
                .BuildAsync(input1, input2, input3, cancellationToken);
        }
    }
}
