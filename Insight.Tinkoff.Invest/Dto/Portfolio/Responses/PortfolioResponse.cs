using System.Collections.Generic;
using Insight.Tinkoff.Invest.Dto.Responses.Payloads;
using Insight.Tinkoff.Invest.Infrastructure;
using Newtonsoft.Json;

namespace Insight.Tinkoff.Invest.Dto.Responses
{
    public sealed class PortfolioResponse : ResponseBase
    {
        [JsonProperty]
        public IReadOnlyCollection<PortfolioPosition> Positions { get; }

        [JsonConstructor]
        public PortfolioResponse(PortfolioResponsePayload payload)
        {
            Positions = payload.Positions;
        }
    }
}