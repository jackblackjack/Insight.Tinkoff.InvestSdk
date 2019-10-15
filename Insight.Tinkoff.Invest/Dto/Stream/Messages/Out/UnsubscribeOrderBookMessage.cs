namespace Insight.Tinkoff.Invest.Dto.Stream.Messages.Out
{
    public sealed class UnsubscribeOrderBookMessage : IWsMessage
    {
        public string Event { get; } = "orderbook:unsubscribe";
        
        public string Figi { get; set; }
        
        public int Depth { get; set; }
    }
}