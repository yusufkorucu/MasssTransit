using MassTransit;
using MassTransit.Shared.Messages;

namespace MasssTransit.Consumer.Consumers
{
    public class ExampleMessageConsumer : IConsumer<IMessage>
    {
        public Task Consume(ConsumeContext<IMessage> context)
        {
            Console.WriteLine($"Gelen Message: {context.Message.Text}");

            return Task.CompletedTask;
        }
    }
}
