using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum AuctionType
    {
        [Description("RFP")]
        RFP = 1,
        [Description("Auction - Live")]
        AuctionLive,
        [Description("Auction - Online")]
        AuctionOnline,
        [Description("Negotiated Contract")]
        NegotiatedContract,
    }
}
