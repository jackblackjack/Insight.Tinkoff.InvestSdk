namespace Insight.Tinkoff.Invest.Dto.Portfolio
{
    public sealed class PortfolioPosition
    {
        public string Figi { get; set; }

        public string Ticker { get; set; }

        public string Isin { get; set; }

        public InstrumentType InstrumentType { get; set; }

        public double Balance { get; set; }

        public double Blocked { get; set; }

        public MoneyAmount ExpectedYield { get; set; }

        public int Lots { get; set; }
    }
}