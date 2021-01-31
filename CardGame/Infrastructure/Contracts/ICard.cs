using CardGame.Models;

namespace CardGame.Infrastructure.Contracts
{
    public interface ICard
    {
        Suit Suit { get; set; }
        CardRank Rank { get; set; }
    }
}
