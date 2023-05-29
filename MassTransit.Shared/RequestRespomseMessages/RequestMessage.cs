namespace MassTransit.Shared.RequestRespomseMessages
{
    public record RequestMessage
    {
        public int MessageId { get; set; }
        public string Text { get; set; }
    }
}
