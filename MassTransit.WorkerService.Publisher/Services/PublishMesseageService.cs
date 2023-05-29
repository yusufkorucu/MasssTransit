using MassTransit.Shared.Messages;

namespace MassTransit.WorkerService.Publisher.Services
{
    public class PublishMesseageService : BackgroundService
    {
        readonly IPublishEndpoint _publishEndpoint;

        public PublishMesseageService(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int i = 0;
            while (true)
            {
                ExampleMessage message = new()
                {
                    Text = $"{++i} .mesaj"
                };

                await _publishEndpoint.Publish(message);
            }
        }
    }
}
