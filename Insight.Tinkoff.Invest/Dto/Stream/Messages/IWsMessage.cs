namespace Insight.Tinkoff.Invest.Dto.Messages
{
    /// <summary>
    /// Исходящее WebSocket сообщение
    /// </summary>
    public interface IWsMessage
    {
        string Event { get; }
    }
}