namespace MapperAndBulderPattern
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Microsoft.Extensions.DependencyInjection;

    /// <inheritdoc/>
    [ExcludeFromCodeCoverage]
    [SuppressMessage("Microsoft.Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Instantiated through reflection")]
    internal sealed class Builder : IBuilder
    {
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="Builder"/> class.
        /// </summary>
        /// <param name="serviceProvider">The ServiceProvider interface.</param>
        public Builder(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <inheritdoc/>
        public TOutput Build<TOutput>()
        {
            return this.serviceProvider
                .GetRequiredService<IBuilder<TOutput>>()
                .Build();
        }

        /// <inheritdoc/>
        public TOutput Build<TInput, TOutput>(TInput input)
            where TInput : notnull
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));

            return this.serviceProvider
                .GetRequiredService<IBuilder<TInput, TOutput>>()
                .Build(input);
        }

        /// <inheritdoc/>
        public TOutput Build<TInput1, TInput2, TOutput>(TInput1 input1, TInput2 input2)
            where TInput1 : notnull
            where TInput2 : notnull
        {
            _ = input1 ?? throw new ArgumentNullException(nameof(input1));
            _ = input2 ?? throw new ArgumentNullException(nameof(input2));

            return this.serviceProvider
                .GetRequiredService<IBuilder<TInput1, TInput2, TOutput>>()
                .Build(input1, input2);
        }

        /// <inheritdoc/>
        public TOutput Build<TInput1, TInput2, TInput3, TOutput>(TInput1 input1, TInput2 input2, TInput3 input3)
            where TInput1 : notnull
            where TInput2 : notnull
            where TInput3 : notnull
        {
            _ = input1 ?? throw new ArgumentNullException(nameof(input1));
            _ = input2 ?? throw new ArgumentNullException(nameof(input2));
            _ = input3 ?? throw new ArgumentNullException(nameof(input3));

            return this.serviceProvider
                .GetRequiredService<IBuilder<TInput1, TInput2, TInput3, TOutput>>()
                .Build(input1, input2, input3);
        }
    }
}
