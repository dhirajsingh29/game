using CardGame.Infrastructure.Contracts;

namespace CardGame.Models
{
    public class Card : ICard
    {
        private Suit _suit;
        private CardRank _rank;

        public Suit Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        public CardRank Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }
    }
}
