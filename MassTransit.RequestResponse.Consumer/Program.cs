using MassTransit;
using MassTransit.RequestResponsePattern.Consumer.Consumers;
Console.WriteLine("Consumer");

string rabbitMqUri = "amqps://utmrfjnx:5EAFe_eJPnPfK04-bk1qfDp6YVP51MbT@chimpanzee.rmq.cloudamqp.com/utmrfjnx";
string requestQueue = "request-queue";

var bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMqUri);
    factory.ReceiveEndpoint(requestQueue, ep =>
    {
        ep.Consumer<RequestMessageConsumer>();
    });
});

await bus.StartAsync();

Console.Read();
