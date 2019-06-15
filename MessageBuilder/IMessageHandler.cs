namespace MessageBuilder
{
    public interface IMessageHandler
    {
        string MessageBody { get; set; }
        string MessageCode { get; set; }
        string MessageTitle { get; set; }
        MessageTypes MessageType { get; set; }
    }
}