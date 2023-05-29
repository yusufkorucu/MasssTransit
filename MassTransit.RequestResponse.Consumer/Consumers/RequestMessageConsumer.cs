using MassTransit.Shared.RequestRespomseMessages;

namespace MassTransit.RequestResponsePattern.Consumer.Consumers
{
    public class RequestMessageConsumer : IConsumer<RequestMessage>
    {
       
        public async Task Consume(ConsumeContext<RequestMessage> context)
        {
            Console.WriteLine(context.Message.Text);

             await context.RespondAsync<ResponseMessage>( new 
             {
                 Text = $"{context.Message.MessageId}. response to Request",
             });
        }
    }
}
