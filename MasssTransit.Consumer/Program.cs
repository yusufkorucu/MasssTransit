using MasssTransit.Consumer.Consumers;
using MassTransit;

string rabbitMqUri = "amqps://utmrfjnx:5EAFe_eJPnPfK04-bk1qfDp6YVP51MbT@chimpanzee.rmq.cloudamqp.com/utmrfjnx";

string queueName = "example-queue";

IBusControl bus = Bus.Factory.CreateUsingRabbitMq(
    factory =>
    {
        factory.Host(rabbitMqUri);

        factory.ReceiveEndpoint(queueName, endpoint =>
        {
            endpoint.Consumer<ExampleMessageConsumer>();
        });
    });

await bus.StartAsync();

Console.Read();