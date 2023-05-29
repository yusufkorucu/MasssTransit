using MassTransit;
using MassTransit.Shared.Messages;

string rabbitMqUri = "amqps://utmrfjnx:5EAFe_eJPnPfK04-bk1qfDp6YVP51MbT@chimpanzee.rmq.cloudamqp.com/utmrfjnx";

string queueName = "example-queue";

IBusControl bus = Bus.Factory.CreateUsingRabbitMq(
    factory =>
    {
        factory.Host(rabbitMqUri);
    });

var sendMessage = await bus.GetSendEndpoint(new($"{rabbitMqUri}/{queueName}"));

Console.Write("Gönderilecek Mesaj: ");

string message= Console.ReadLine();
await sendMessage.Send<IMessage>(new ExampleMessage()
{
    Text=message
});

Console.Read();